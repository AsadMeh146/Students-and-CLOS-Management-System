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
    public partial class Attendence_Info_Update : Form
    {
        public Attendence_Info_Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT ClassAttendance.Id AS ClassAttendenceId,Student.Id AS StudentId,Student.RegistrationNumber,ClassAttendance.AttendanceDate,StudentAttendance.AttendanceStatus FROM Student, StudentAttendance, ClassAttendance WHERE Student.Id = StudentAttendance.StudentId AND ClassAttendance.Id = StudentAttendance.AttendanceId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            attendence_Grid.DataSource = dt;
            attendence_Grid.Columns["StudentId"].Visible = false;
            attendence_Grid.Columns["ClassAttendenceId"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = attendence_Grid.CurrentCell.RowIndex;
            int colIndex = attendence_Grid.CurrentCell.ColumnIndex;
            string stu_id_text0 = attendence_Grid.Rows[rowIndex].Cells[0].Value.ToString();
            string stu_id_text1 = attendence_Grid.Rows[rowIndex].Cells[1].Value.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Delete FROM StudentAttendance WHERE AttendanceId = @AttenId AND StudentId = @StnId", con);
            cmd1.Parameters.AddWithValue("@AttenId", stu_id_text0);
            cmd1.Parameters.AddWithValue("@StnId", stu_id_text1);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            MessageBox.Show("Deleted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            int rowIndex = attendence_Grid.CurrentCell.RowIndex;
            int colIndex = attendence_Grid.CurrentCell.ColumnIndex;
            string updateValue = attendence_Grid.Rows[rowIndex].Cells[colIndex].Value.ToString();
            int updateValue1 = int.Parse(updateValue);
            if (updateValue1 == 0 || updateValue1 > 4)
            {
                MessageBox.Show("Wrong Attendence Status");
            }
             
                else
                {
                string stu_id = attendence_Grid.Rows[rowIndex].Cells[0].Value.ToString();
                string stu_id1 = attendence_Grid.Rows[rowIndex].Cells[1].Value.ToString();
                string columnHeader = attendence_Grid.Columns[colIndex].HeaderText;

                string query = columnHeader + " =@" + columnHeader;
                    SqlCommand cmd = new SqlCommand("Update StudentAttendance SET " + query + " WHERE AttendanceId = @Id AND StudentId = @Id2", con);
                    cmd.Parameters.AddWithValue("@" + columnHeader, updateValue1);
                    cmd.Parameters.AddWithValue("@Id", stu_id);
                    cmd.Parameters.AddWithValue("@Id2", stu_id1);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Successfully Updated");
                    attendence_Grid.DataSource = dt;
                }
                
            }
            
        }
    }
    

