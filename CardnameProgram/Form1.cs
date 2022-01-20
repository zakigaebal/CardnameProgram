using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CardnameProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string seqCount()
        {
            try
            {
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
               
                string Query = "SELECT MAX(perSeq)+1 AS seqMax FROM dawoon.dw_persons;";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MyConn2.Open();
                MySqlCommand cmd = new MySqlCommand(Query, MyConn2);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {


                    return rdr["seqMax"].ToString();

                }

                rdr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void showData()
        {
            try
            {
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                //쿼리
                string Query = "select * from dawoon.dw_persons;";//체크박스를 하면 보여주고 안보이면 안보여주는형식
                if (checkBoxDelShow.Checked == true)
                {

                    Query = "select * from dawoon.dw_persons";
                }
                else
                {
                    Query = "select * from dawoon.dw_persons WHERE flagYN = 'Y';";

                }
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2 열어라 
                //오프라인 연결을 위해서 우리는 MySqlDataAdapter class를 사용할것이다.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;             
                //여기서 나는 data를 보여주기 위해서 dataGridView1 객체를 dTable 객체에 할당한다.
                                                   // MyConn2를 닫아라
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 4].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 3].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
                dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void checkBoxDelShow_CheckedChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요");
                textBoxName.Focus();
                return;
            }
            try
            {
                // 이것은 나의 내가 데이터베이스 파일 주소 path에 할당했던 연결 문자열이다.
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                // 이것은 내가 윈도우폼을 통해 유저로부터 받았던 나의 insert 쿼리이다.
                string Query = "insert into dawoon.dw_persons(perSeq,perName,perComp,perAge,perJob,perHp,perTask,perAddr,flagYN,regDate,issueDate,IssueID) values('"
                    + seqCount() + "','" + this.textBoxName.Text + "','" + this.textBoxComp.Text + "','" + this.textBoxAge.Text + "','" + this.textBoxJob.Text + "','" 
                    + this.textBoxTel.Text + "','" + this.textBoxTask.Text + "','" + this.textBoxAddress.Text + "','Y',now(),now(),'CDY');";
                
                // 이것은 내가 객체와 패스워드를 나의 연결 스트링에 생성했었던 MySqlConnection이다.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //이것은 객체를 연결하고 쿼리를 핸들링 할 커맨드 클래스이다.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();      
                // 여기서 쿼리를 실행할것이고 데이터를 데이터베이스에 저장할것이다.
                MessageBox.Show("저장완료");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
                showData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
                string Query = "update dawoon.dw_persons set flagYN='N' WHERE perSeq=" + seqstr;
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("삭제완료");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
                showData();
                textBoxName.Text = "";
                textBoxAge.Text = "";
                textBoxComp.Text = "";
                textBoxJob.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string seqstr = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                
                // 이것은 나의 내가 데이터베이스 파일 주소 path에 할당했던 연결 문자열이다.

                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=ekdnsel;Charset=utf8";
              
                // 이것은 레코드를 업데이트를 할 내가 윈도움폼을 통해 유저로부터 받아왔던 나의 업데이트 쿼리이다 
                string Query = "update dawoon.dw_persons set perSeq='" + seqstr + "',perName='" + this.textBoxName.Text + "',perComp='" + this.textBoxComp.Text + "',perAge='" 
                    + this.textBoxAge.Text + "',perJob='" + this.textBoxJob.Text + "',perHp='" + this.textBoxTel.Text + "',perTask='" + this.textBoxTask.Text + "',perAddr='" 
                    + this.textBoxAddress.Text + "' where perSeq='" + seqstr + "';";
                // 이것은 내가 객체와 패스워드를 나의 연결 스트링에 생성했었던 MySqlConnection이다.

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("수정완료");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();// 여기서 연결을 닫을것이다.
                showData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxComp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAge.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxJob.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxJob.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxJob.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxJob.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showData();

        }
    }
}
