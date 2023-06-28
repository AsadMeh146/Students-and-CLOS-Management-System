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
    public partial class Student_Info_Update : Form
    {
        public Student_Info_Update()
        {
            InitializeComponent();
        }
        
        private void refresh_btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stn_info_grid.DataSource = dt;
        }

        private void delete_stn_btn_Click(object sender, EventArgs e)
        {
            int rowIndex  = stn_info_grid.CurrentCell.RowIndex;
            int colIndex = stn_info_grid.CurrentCell.ColumnIndex;
            string stu_id_text = stn_info_grid.Rows[rowIndex].Cells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Delete from StudentResult WHERE StudentId = @Id;Delete from StudentAttendance WHERE StudentId = @Id;Delete from Student WHERE Id = @Id   ", con);
            cmd1.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");
        }

        private void update_stn_btn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = stn_info_grid.CurrentCell.RowIndex;
            int colIndex = stn_info_grid.CurrentCell.ColumnIndex;
            string updateValue = stn_info_grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            string stu_id = stn_info_grid.Rows[rowIndex].Cells[0].Value.ToString();
            string columnHeader = stn_info_grid.Columns[colIndex].HeaderText;
            string query = columnHeader + " =@" + columnHeader;
            SqlCommand cmd = new SqlCommand("Update Student SET " + query + " WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@" + columnHeader, updateValue);
            cmd.Parameters.AddWithValue("@Id", stu_id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Successfully Updated");
            stn_info_grid.DataSource = dt;
        }
    }
}
