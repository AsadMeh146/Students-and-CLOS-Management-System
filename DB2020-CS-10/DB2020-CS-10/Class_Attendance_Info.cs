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
    public partial class Class_Attendance_Info : Form
    {
        public Class_Attendance_Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from ClassAttendance", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            class_attendence_Grid.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = class_attendence_Grid.CurrentCell.RowIndex;
            int colIndex = class_attendence_Grid.CurrentCell.ColumnIndex;
            string stu_id_text = class_attendence_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Delete FROM StudentAttendance WHERE AttendanceId = @Id;Delete FROM ClassAttendance WHERE Id = @Id    ", con);
            cmd1.Parameters.AddWithValue("@Id", stu_id_text);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");
        }
    }
}
