using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //使用sql

namespace 程式化語法存取資料庫
{
    //DataGridView 與 DataBinding 精靈產生的表格一樣

    public partial class Form1 : Form
    {
        //定義 SQL 
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDb連線字串 = ""; //資料庫連線字串

        //婚姻狀態
        int int婚姻狀態 = 0; //0:全部 1.單身 2.已婚 --> 搜尋用

        //存進階搜尋結果 --> 符合條件的會員資料 (存ID int型態)
        List<int> list進階搜尋ID = new List<int>();

        //資料筆數
        int DGV筆數 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在Form建立資料庫連線字串 --> 參考DataBinding檔中的 App.Config檔中

            //伺服器名稱 @忽略字元(.本機)
            scsb.DataSource = @".";

            //資料庫名稱
            scsb.InitialCatalog = "mydb";

            //SQL驗證 = false
            scsb.IntegratedSecurity = true;

            //加密金鑰
            scsb.Encrypt = false; 

            //指定到strDb連線字串
            strDb連線字串 = scsb.ConnectionString;

            cbox欄位名稱.Items.Add("姓名");
            cbox欄位名稱.Items.Add("電話");
            cbox欄位名稱.Items.Add("地址");
            cbox欄位名稱.Items.Add("email");
            cbox欄位名稱.SelectedIndex = 0;

            radio婚姻全部.Checked = true;
            int婚姻狀態 = 0;

            產生會員資料列表DataGridView();

        }

        private void btn資料測試_Click(object sender, EventArgs e)
        {
            //建立資料庫連線物件 (連線字串)
            SqlConnection con = new SqlConnection(strDb連線字串);
            
            //開啟
            con.Open();

            //建立SQL查詢語法
            string str查詢語法 = "select * from persons;";

            //SQL命令物件 (查詢語法,連線物件)
            SqlCommand cmd = new SqlCommand(str查詢語法, con);

            //建立SQL data讀取器 = 基於Sql命令物件
            //讀到的資料放到 reader
            SqlDataReader reader = cmd.ExecuteReader();

            string str讀取資料 = "";
            int count資料筆數 = 0;

            //用while迴圈來讀全部資料
            while (reader.Read() == true) //reader.Read()讀到一筆資料 == true 資料讀完就會回傳false
            {
                //reader讀出來的是物件 --> (欲轉型別)轉型
                //讀到的資料類似hashtable key-value 不定型別
                //[key]
                int id = (int)reader["Id"];
                string 姓名 = (string)reader["姓名"];
                string 電話 = (string)reader["電話"];
                string email = (string)reader["email"];
                string 地址 = (string)reader["地址"];
                DateTime 生日 = (DateTime)reader["生日"];
                bool 婚姻狀態 = (bool)reader["婚姻狀態"];
                //int 點數 = (int)reader["點數"];
                //點數遇到null欄位 用三原運算子來處理
                int 點數 = reader["點數"] != DBNull.Value ? (int)reader["點數"] : 0;

                str讀取資料 += $"{id} {姓名} {電話} {email} {地址} {生日} {婚姻狀態} 點數:{點數}\n";
                count資料筆數 += 1;
            }
            str讀取資料 += $"資料筆數:{count資料筆數}";

            //關讀取器(後建先關)
            reader.Close();
            //關連線(先建後關)
            con.Close();

            MessageBox.Show(str讀取資料);
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if(txt姓名.Text != "")
            {
                //建立SQL連線物件
                SqlConnection con = new SqlConnection(strDb連線字串);
                //開啟連線
                con.Open();

                //SQL查詢語法 
                //避免注入式攻擊 SQL injection
                //==> 在UI Text中輸入-- > ; 停止SQL執行 輸入新語法(駭客入侵) 必須參數化
                string str查詢語法 = $"select * from persons where 姓名 like @SearchName;";
                //SQL命令物件
                SqlCommand cmd = new SqlCommand(str查詢語法, con);

                //在cmd注入參數  ("參數","值")
                cmd.Parameters.AddWithValue("@SearchName", $"{txt姓名.Text}");

                //建立讀取器
                SqlDataReader reader = cmd.ExecuteReader(); //有回傳值

                if (reader.Read() == true)
                {
                    //txtID.Text = (string)reader["Id"]; 小括號轉型失敗
                    txtID.Text = reader["Id"].ToString();
                    txt姓名.Text = reader["姓名"].ToString(); //int需要用ToString()
                    txt電話.Text = (string)reader["電話"];
                    txtEmail.Text = (string)reader["email"];
                    txt地址.Text = (string)reader["地址"];
                    dtp生日.Value = (DateTime)reader["生日"];
                    chk婚姻狀態.Checked = (bool)reader["婚姻狀態"];
                    txt點數.Text = reader["點數"] != DBNull.Value ? reader["點數"].ToString() : 0.ToString(); //int需要用ToString()
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
            
                //關讀取器
                reader.Close();
                //關連線
                con.Close();
            }
        }

        void 清空欄位()
        {
            txtID.Clear();
            txt姓名.Clear();
            txtEmail.Clear();
            txt地址.Clear();
            txt電話.Clear();
            txt點數.Clear();
            DateTime 預設生日 = new DateTime(1990, 1, 1, 0, 0,0);
            dtp生日.Value = 預設生日;
            chk婚姻狀態.Checked = false;
        }

        //要先取得id 與刪除相同
        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtID.Text, out intId);

            //驗欄位
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtEmail.Text != ""))
            {
                
                SqlConnection con = new SqlConnection(strDb連線字串);
                con.Open();
                string str查詢語法 = "update persons set 姓名=@NewName, 電話=@NewPhone, 地址=@NewAddress, email=@NewEmail, 生日=@NewBirth, 婚姻狀態=@NewMarriage, 點數=@NewPoints where id=@SearchId;";
                SqlCommand cmd = new SqlCommand(str查詢語法, con);
                cmd.Parameters.AddWithValue("@SearchId",intId);
                cmd.Parameters.AddWithValue("@NewName",txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone",txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress",txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail",txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth",dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage",chk婚姻狀態.Checked);

                int intPoints = 0;
                Int32.TryParse(txt點數.Text, out intPoints);

                cmd.Parameters.AddWithValue("@NewPoints",txt點數.Text);

                

                int rows受影響資料 = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料修改成功\n{rows受影響資料}個資料列受到影響");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        //查詢語法values(@參數化,@參數化...)
        //注意 :("@參數化",值)
        private void btn資料新增_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt電話.Text != "") && (txt地址.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDb連線字串);
                con.Open();
                //string str查詢語法 = "insert into persons values('王大佬','0987-878-878','台北市信義區中正路8號','wangfly@gmail.com','1977-10-10','1','1000','1000');";
                //string str查詢語法 = "insert into persons values('@NewName','@NewPhone','@NewAddress','@NewEmail','@NewBirth','@NewMarriage','@NewPoints','@NewPower');";
                string str查詢語法 = "insert into persons (姓名,電話,地址,email,生日,婚姻狀態,點數) values (@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirth,@NewMarriage,@NewPoints);"; //values(@參數化,@參數化...)

                SqlCommand cmd = new SqlCommand(str查詢語法, con);

                //注意 :("@參數化",值)
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewMarriage", chk婚姻狀態.Checked);

                int int點數 = 0;
                Int32.TryParse(txt點數.Text, out int點數);
                cmd.Parameters.AddWithValue("@NewPoints", int點數);

                //只執行不查詢 --> 不用SqlDataReader(讀取器)

                int row受影響的資料 = cmd.ExecuteNonQuery(); //傳回受影響的資料列 沒有回傳值
                con.Close();
                MessageBox.Show($"{row受影響的資料}個資料列受到影響");
            }
            else
            {
                MessageBox.Show("欄位資料不齊全");
            }
        }

        //刪除資料要先確認id 因為有同姓名的可能
        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtID.Text, out intId);

            //確認是否要刪除
            DialogResult r = MessageBox.Show("是否確定要刪除此筆資料?", "確認刪除", MessageBoxButtons.YesNo);

            if ((intId > 0) && (r == DialogResult.Yes))
            {
                
                SqlConnection con = new SqlConnection(strDb連線字串);
                con.Open();
                string str查詢語法 = "delete from persons where id = @DeleteId;";
                SqlCommand cmd = new SqlCommand(str查詢語法, con);
                cmd.Parameters.AddWithValue("@DeleteId", intId);

                int rows受影響的資料 = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"資料已刪除\n {rows受影響的資料} 個資料列受到影響");
            }
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void txt搜尋關鍵字_TextChanged(object sender, EventArgs e)
        {

        }

        //針對欄位模糊搜尋 生日 婚姻狀態
        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if(txt搜尋關鍵字.Text != "")
            {
                lbox進階搜尋結果.Items.Clear(); //搜尋時將上一個結果清除
                list進階搜尋ID.Clear(); //進階搜尋結果要清空

                //cbox的屬性DropDownStyle =>  --> DropDownList 讓使用者不能輸入
                string str欄位名稱 = cbox欄位名稱.SelectedItem.ToString(); //物件轉型 object --> string

                string str婚姻狀態查詢語法 = "";
                switch (int婚姻狀態)
                {
                    case 0://全部
                        str婚姻狀態查詢語法 = "";
                        break;
                    case 1://單身
                        str婚姻狀態查詢語法 = "and 婚姻狀態 = 0;";
                        break;
                    case 2://已婚
                        str婚姻狀態查詢語法 = "and 婚姻狀態 = 1;";
                        break;
                    default:
                        str婚姻狀態查詢語法 = "";
                        break;
                }

                SqlConnection con = new SqlConnection(strDb連線字串);
                con.Open();

                //這裡的欄位使用字串插值 因為欄位名稱不能參數化(使用者用選的不能輸入所以沒有SQL injection的危險)
                //注意語法關鍵字之間要空白
                string str查詢語法 = $"select * from persons where (生日 >= @StartBirth and 生日 <= @EndBirth) and ({str欄位名稱} like @SearchKeyword) {str婚姻狀態查詢語法};";
                SqlCommand cmd = new SqlCommand(str查詢語法, con);
                cmd.Parameters.AddWithValue("@StartBirth",dtp開始時間.Value);
                cmd.Parameters.AddWithValue("@EndBirth",dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@SearchKeyword",$"%{txt搜尋關鍵字.Text}%");
                SqlDataReader reader = cmd.ExecuteReader(); //有回傳值

                //經過轉換(datatable) 將DataReader讀到的資料顯示再DataGridView上
                //if (reader.HasRows == true) //HasRows 多個資料筆 == true
                //{
                //    DataTable dt轉換成datatable = new DataTable();
                //    dt轉換成datatable.Load(reader);
                //    dataGridView1.DataSource = dt轉換成datatable;
                //}
                //else
                //{
                //    MessageBox.Show("查無資料");
                //}

                int count = 0;
                while (reader.Read() == true)
                {
                    //加入搜尋結果的id
                    list進階搜尋ID.Add((int)reader["id"]);

                    //搜尋結果加入姓名 電話 可以做多資訊
                    lbox進階搜尋結果.Items.Add($"姓名:{reader["姓名"]} 電話:{reader["電話"]}");

                    count++;
                }

                //查無此人
                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }

        //將模糊搜尋搜到的資料 透過點擊listbox來呈現到資料欄位
        private void lbox進階搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox進階搜尋結果.SelectedIndex >= 0)
            {
                int 選擇資料的id = list進階搜尋ID[lbox進階搜尋結果.SelectedIndex]; 
                產生會員資料欄位byId(選擇資料的id);
            }
        }

        void 產生會員資料欄位byId(int 搜尋id)
        {
            //抓lbox中選擇姓名的ID 
            //int int選擇姓名的ID = list進階搜尋ID[lbox進階搜尋結果.SelectedIndex];

            //建立SQL連線物件
            SqlConnection con = new SqlConnection(strDb連線字串);
            //開啟連線
            con.Open();

            //SQL查詢語法 
            //避免注入式攻擊 SQL injection
            //==> 在UI Text中輸入-- > ; 停止SQL執行 輸入新語法(駭客入侵) 必須參數化
            string str查詢語法 = $"select * from persons where id = @SearchId;";
            //SQL命令物件
            SqlCommand cmd = new SqlCommand(str查詢語法, con);

            //在cmd注入參數  ("參數","值")

            //Int32.TryParse(txtID.Text, out int取得資料Id);
            cmd.Parameters.AddWithValue("@SearchId", 搜尋id);

            //建立讀取器
            SqlDataReader reader = cmd.ExecuteReader(); //有回傳值


            if (reader.Read() == true)
            {
               //txtID.Text = (string)reader["Id"]; 小括號轉型失敗
               txtID.Text = reader["Id"].ToString();
               txt姓名.Text = reader["姓名"].ToString(); //int需要用ToString()
               txt電話.Text = (string)reader["電話"];
               txtEmail.Text = (string)reader["email"];
               txt地址.Text = (string)reader["地址"];
               dtp生日.Value = (DateTime)reader["生日"];
               chk婚姻狀態.Checked = (bool)reader["婚姻狀態"];
               txt點數.Text = reader["點數"] != DBNull.Value ? reader["點數"].ToString() : 0.ToString(); //int需要用ToString()
            }
            else
            {
               MessageBox.Show("查無此人");
               清空欄位();
            }

            //關讀取器
            reader.Close();
            //關連線
            con.Close();
        }

        //用數字來辨認
        private void radio婚姻全部_CheckedChanged(object sender, EventArgs e)
        {
            int婚姻狀態 = 0;
        }

        private void radio婚姻單身_CheckedChanged(object sender, EventArgs e)
        {
            int婚姻狀態 = 1;
        }

        private void radio婚姻已婚_CheckedChanged(object sender, EventArgs e)
        {
            int婚姻狀態 = 2;
        }

        //程式化語法應用datagridview
        //沒有雙向繫結!!
        void 產生會員資料列表DataGridView()
        {
            SqlConnection con = new SqlConnection(strDb連線字串);
            con.Open();
            //string str查詢語法 = "select * from persons;";
            string str查詢語法 = "select id as 會員編號,姓名,電話,地址, email as 電子郵件,生日,婚姻狀態,點數 from persons;";
            SqlCommand cmd = new SqlCommand(str查詢語法, con);
            SqlDataReader reader = cmd.ExecuteReader();

            //經過轉換(datatable) 將DataReader讀到的資料顯示再DataGridView上
            if(reader.HasRows == true) //HasRows 多個資料筆 == true
            {
                DataTable dt轉換成datatable = new DataTable();
                dt轉換成datatable.Load(reader);
                DGV筆數 = dt轉換成datatable.Rows.Count; //取得筆數 第一筆 :　Rows[0]
                dataGridView1.DataSource = dt轉換成datatable;
            }
            else
            {
                MessageBox.Show("查無資料");
            }
            reader.Close();
            con.Close();
        }

        //點擊datagridview中的儲存格(Cell) 事件(e)包含使用者點擊與儲存格的資訊
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //如何選到資料像 lbox的SelectIndex
            //e.RowIndex 點擊列的索引值 大於0要小於資料筆數

            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                //取得id
                //儲存格中的資料是物件型態 取得列的索引值再取得第一個儲存格的資料 0 = id
                string strId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //Console.WriteLine(strId); //任何資料都可以轉字串 方便除錯

                int 選擇資料的Id = 0;
                Int32.TryParse(strId, out 選擇資料的Id);

                產生會員資料欄位byId(選擇資料的Id);
            }
            else
            {

            }
        }
    }
}
