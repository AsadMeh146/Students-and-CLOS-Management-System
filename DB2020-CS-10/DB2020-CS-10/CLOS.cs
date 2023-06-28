using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2020_CS_10
{
    public partial class CLOS : Form
    {
        string get_date = "";
        //string get_updated_date = "";
        Dictionary<string, string> getRubricId = null;
        Dictionary<string, string> getAssessId = null;
        DataTable dt5 = null;
        public CLOS()
        {
            InitializeComponent();
        }

        private void add_clo_btn_Click(object sender, EventArgs e)
        {
            if (clo_name.Text == "")
            {
                MessageBox.Show("Please fill the field");
            }
            else
            {
                get_date = clo_created_date.Value.Year.ToString() + "-" + clo_created_date.Value.Month.ToString() + "-" + clo_created_date.Value.Day.ToString();
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Clo values(@Name ,CAST(@DateCreated AS datetime),CAST(@DateUpdated AS datetime))", con);
                cmd.Parameters.AddWithValue("@Name", clo_name.Text);
                cmd.Parameters.AddWithValue("@DateCreated", get_date);
                cmd.Parameters.AddWithValue("@DateUpdated", get_date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            clo_grid.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = clo_grid.CurrentCell.RowIndex;
            int colIndex = clo_grid.CurrentCell.ColumnIndex;
            string clo_id_text = clo_grid.Rows[rowIndex].Cells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Rubric WHERE CloId = @Id1", con);
            cmd.Parameters.AddWithValue("@Id1", clo_id_text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                getRubricId.Add(row["Id"].ToString(), row["Id"].ToString());
            }
            foreach (KeyValuePair<string, string> rows in getRubricId)
            {
                int rub_id_text = int.Parse(rows.Key);
                SqlCommand cmd5 = new SqlCommand("SELECT Id FROM AssessmentComponent WHERE RubricId = @Id5", con);
                cmd5.Parameters.AddWithValue("@Id5", rub_id_text);
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                da5.Fill(dt5);
            }
            foreach (DataRow row in dt5.Rows)
            {
                getAssessId.Add(row["Id"].ToString(), row["Id"].ToString());
            }
            foreach (KeyValuePair<string, string> getKey in getAssessId)
            {
                int get_assId = int.Parse(getKey.Key);
                SqlCommand cmd2 = new SqlCommand("Delete FROM StudentResult WHERE AssessmentComponentId = @Id2", con);
                cmd2.Parameters.AddWithValue("@Id2", get_assId);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
            }
            foreach (KeyValuePair<string, string> getKey in getRubricId)
            {
                int get_rubricId = int.Parse(getKey.Key);
                SqlCommand cmd2 = new SqlCommand("Delete from RubricLevel WHERE RubricId = @Id2; Delete from AssessmentComponent WHERE RubricId = @Id2 ", con);
                cmd2.Parameters.AddWithValue("@Id2", get_rubricId);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
            }
            SqlCommand cmd1 = new SqlCommand("Delete from Rubric WHERE CloId = @Id;Delete from Clo WHERE Id = @Id", con); 
            cmd1.Parameters.AddWithValue("@Id", clo_id_text);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = clo_grid.CurrentCell.RowIndex;
            int colIndex = clo_grid.CurrentCell.ColumnIndex;
            string updateValue = clo_grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            string stu_id = clo_grid.Rows[rowIndex].Cells[0].Value.ToString();
            string columnHeader = clo_grid.Columns[colIndex].HeaderText;
            if (columnHeader == "DateCreated" || columnHeader == "Id")
            {
                MessageBox.Show("Wrong item selected");
            }
            else
            {
                string query = columnHeader + " =@" + columnHeader;
                string getDate = DateTime.Now.ToString("yyyy/MM/dd");
                SqlCommand cmd = new SqlCommand("Update Clo SET " + query + " , DateUpdated = @Time WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@" + columnHeader, updateValue);
                cmd.Parameters.AddWithValue("@Id", stu_id);
                cmd.Parameters.AddWithValue("@Time", getDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Successfully Updated");
                clo_grid.DataSource = dt;
            }
            
        }

        private void CLOS_Load(object sender, EventArgs e)
        {
            dt5 = new DataTable();
            getRubricId = new Dictionary<string, string>();
            getAssessId = new Dictionary<string, string>();
        }
    }
    }

