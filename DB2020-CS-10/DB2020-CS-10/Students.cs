using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2020_CS_10
{

    public partial class Students : Form
    {
 
        int status_id = 0;
        int att_status_id = 0;
        int att_id = 0;
        int stn_id = 0;
        Dictionary<string, string> LookUp = null;
        Dictionary<string, string> StudentId = null;
        Dictionary<string, string> getStudentAttendence = null;
        Dictionary<string, string> AttendenceId = null;
        Dictionary<string, string> AttendenceId2 = null;
        Dictionary<string, string> AssessmentId = null;
        Dictionary<string, string> RubricLevelId = null;
        Dictionary<string, string> RubricLevelId2 = null;
        string dt = " ";
        Dictionary<string, string> getAssessId = null;
        bool isFound = false;
        bool isFound1 = false;
        public Students()
        {
            InitializeComponent();
        }

   
        private void Students_Load(object sender, EventArgs e)
        {
            LookUp = new Dictionary<string, string>();
            StudentId = new Dictionary<string, string>();
            AttendenceId = new Dictionary<string, string>();
            AttendenceId2 = new Dictionary<string, string>();
            AssessmentId = new Dictionary<string, string>();
            RubricLevelId = new Dictionary<string, string>();
            RubricLevelId2 = new Dictionary<string, string>();
            getAssessId = new Dictionary<string, string>();
            getStudentAttendence = new Dictionary<string, string>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Lookup", con);
            SqlCommand cmd1 = new SqlCommand("Select * from Student WHERE Status = 5", con);
            SqlCommand cmd2 = new SqlCommand("Select * from ClassAttendance", con);
            SqlCommand cmd3 = new SqlCommand("Select * from AssessmentComponent", con);
            SqlCommand cmd4 = new SqlCommand("Select * from RubricLevel", con);
            SqlCommand cmd5 = new SqlCommand("Select * from ClassAttendance", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            da.Fill(dt);
            da1.Fill(dt1);
            da2.Fill(dt2);
            da3.Fill(dt3);
            da4.Fill(dt4);
            da5.Fill(dt5);
            foreach (DataRow rows in dt.Rows)
            {
                LookUp.Add(rows["Name"].ToString(),rows["LookupId"].ToString());
            }
            foreach (DataRow rows1 in dt1.Rows)
            {
                StudentId.Add(rows1["Id"].ToString(), rows1["RegistrationNumber"].ToString());
            }
            foreach (DataRow rows2 in dt2.Rows)
            {
                AttendenceId.Add(rows2["Id"].ToString(), rows2["AttendanceDate"].ToString());
            }
            foreach (DataRow rows3 in dt3.Rows)
            {
                AssessmentId.Add(rows3["Id"].ToString(), rows3["Name"].ToString());
            }
            foreach (DataRow rows4 in dt4.Rows)
            {
                RubricLevelId.Add(rows4["Id"].ToString(), rows4["Details"].ToString());
                RubricLevelId2.Add(rows4["Id"].ToString(), rows4["MeasurementLevel"].ToString());
            }
            foreach (DataRow rows5 in dt5.Rows)
            {
                AttendenceId2.Add(rows5["Id"].ToString(), rows5["AttendanceDate"].ToString());
            }
            foreach (string value in StudentId.Values)
            {
                stn_id_Box.Items.Add(value);
                Student_ID_Box.Items.Add(value);
            }
            foreach (string value in AttendenceId.Values)
            {
                att_id_box.Items.Add(value);
            }
            foreach (string value in AssessmentId.Values)
            {
                assess_comp_Box.Items.Add(value);
            }
            foreach (string value in RubricLevelId.Values)
            {
                RubricLevel_Box.Items.Add(value);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (stn_fname.Text != "" && stn_lname.Text != "" && stn_contact.Text != "" && stn_email.Text != "" && stn_regno.Text != "" && status_Box.Text != "--select")
            {
                if (Regex.IsMatch(stn_fname.Text, @"^[a-zA-Z]+$"))
                {
                    if (Regex.IsMatch(stn_lname.Text, @"^[a-zA-Z]+$"))
                    {
                        if (Regex.IsMatch(stn_email.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")) 
                        {
                            if (Regex.IsMatch(stn_regno.Text, @"^[2]{1}[0]{1}[0-9]{2}-[A-Z]{2}-[0-9]{1,3}$"))
                            {
                                exceptioncheck();
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Valid Registration Number");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid email address");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please Add Valid Name");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        
        }
        private void exceptioncheck()
        {
            if (status_Box.Text == "Active")
            {
                status_id = int.Parse(LookUp["Active"]);

            }
            else if (status_Box.Text == "InActive")
            {
                status_id = int.Parse(LookUp["InActive"]);
            }
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@FirstName, @LastName, @Contact,@Email,@RegistrationNumber,@Status)", con);
            cmd.Parameters.AddWithValue("@FirstName", stn_fname.Text);
            cmd.Parameters.AddWithValue("@LastName", stn_lname.Text);
            cmd.Parameters.AddWithValue("@Contact", stn_contact.Text);
            cmd.Parameters.AddWithValue("@Email", stn_email.Text);
            cmd.Parameters.AddWithValue("@RegistrationNumber", stn_regno.Text);
            cmd.Parameters.AddWithValue("@Status", status_id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            status_Box.Text = "--select";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void add_class_attend_btn_Click(object sender, EventArgs e)
        {
            dt = class_att_date.Value.Year.ToString() + "-" + class_att_date.Value.Month.ToString() + "-" + class_att_date.Value.Day.ToString();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into ProjectB.dbo.ClassAttendance(AttendanceDate) values (CAST(@AttendanceDate AS datetime))", con);
            cmd.Parameters.AddWithValue("@AttendanceDate", dt);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
        }

        private void add_attendence_Click(object sender, EventArgs e)
        {
            if (attendence_Box.Text == "--select" || stn_id_Box.Text == "--select" || att_id_box.Text == "--select")
            {
                MessageBox.Show("Please Fill All fields");
            }
            else
            {
                if (attendence_Box.Text == "Present")
                {
                    att_status_id = int.Parse(LookUp["Present"]);
                }
                else if (attendence_Box.Text == "Absent")
                {
                    att_status_id = int.Parse(LookUp["Absent"]);
                }
                else if (attendence_Box.Text == "Leave")
                {
                    att_status_id = int.Parse(LookUp["Leave"]);
                }
                else if (attendence_Box.Text == "Late")
                {
                    att_status_id = int.Parse(LookUp["Late"]);
                }
                foreach (KeyValuePair<string, string> rows in StudentId)
                {
                    if (rows.Value == stn_id_Box.Text)
                    {
                        stn_id = int.Parse(rows.Key);
                    }
                }
                foreach (KeyValuePair<string, string> row1 in AttendenceId)
                {
                    if (row1.Value == att_id_box.Text)
                    {
                        att_id = int.Parse(row1.Key);
                    }
                }
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("SELECT StudentId,AttendanceId FROM StudentAttendance", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                foreach (DataRow rows in dt1.Rows)
                {
                    string studentid = rows["StudentId"].ToString();
                    int get_id = int.Parse(studentid);
                    string attenid = rows["AttendanceId"].ToString();
                    int get_att_id = int.Parse(attenid);
                    if (get_id == stn_id && att_id == get_att_id)
                    {
                        isFound1 = true;
                    }
                }
                //getStudentAttendence.Add(rows["StudentId"].ToString(), rows["AttendanceId"].ToString());
                //foreach (KeyValuePair<string, string> getKeys in getStudentAttendence)
                //{
                //    if (int.Parse(getKeys.Key) == stn_id && att_id == int.Parse(getKeys.Value))
                //    {
                //        isFound1 = true;
                //    }
                //}
                if (isFound1 == true)
                {
                    MessageBox.Show("Attendance of this student on this date already exist");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@AttendanceId, @StudentId, @AttendanceStatus)", con);
                    cmd.Parameters.AddWithValue("@AttendanceId", att_id);
                    cmd.Parameters.AddWithValue("@StudentId", stn_id);
                    cmd.Parameters.AddWithValue("@AttendanceStatus", att_status_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    stn_id_Box.Text = "--select";
                    att_id_box.Text = "--select";
                    attendence_Box.Text = "--select";
                }
                
            }
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.stn_crud_panel.Controls.Clear();
            Student_Info_Update stn_info_up_Form = new Student_Info_Update() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stn_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.stn_crud_panel.Controls.Add(stn_info_up_Form);
            stn_info_up_Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.stn_crud_panel.Controls.Clear();
            Class_Attendance_Info class_att_info_up_Form = new Class_Attendance_Info() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            class_att_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.stn_crud_panel.Controls.Add(class_att_info_up_Form);
            class_att_info_up_Form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.stn_crud_panel.Controls.Clear();
            Attendence_Info_Update att_info_up_Form = new Attendence_Info_Update() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            att_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.stn_crud_panel.Controls.Add(att_info_up_Form);
            att_info_up_Form.Show();
        }

        private void stn_crud_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Student_ID_Box.Text == "--select" || assess_comp_Box.Text == "--select" || RubricLevel_Box.Text == "--select")
            {
                MessageBox.Show("Please Fill All fields");
            }
            int selectedIndex = Student_ID_Box.SelectedIndex;
            int get_studentid = int.Parse(StudentId.Keys.ElementAt(selectedIndex));
            int selectedIndex1 = assess_comp_Box.SelectedIndex;
            int get_assess_comp_id = int.Parse(AssessmentId.Keys.ElementAt(selectedIndex1));
            int selectedIndex2 = RubricLevel_Box.SelectedIndex;
            int get_rubric_id = int.Parse(RubricLevelId.Keys.ElementAt(selectedIndex2));
            string get_date = evaluation_Date.Value.Year.ToString() + "-" + evaluation_Date.Value.Month.ToString() + "-" + evaluation_Date.Value.Day.ToString();            
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("SELECT AssessmentComponentId,StudentId FROM StudentResult WHERE StudentId = @Id AND AssessmentComponentId = @Id2", con);
            cmd1.Parameters.AddWithValue("@Id", get_studentid);
            cmd1.Parameters.AddWithValue("@Id2", get_assess_comp_id);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            foreach (DataRow row in dt1.Rows)
            {
                getAssessId.Add(row["AssessmentComponentId"].ToString(), row["StudentId"].ToString());
            }
            foreach (KeyValuePair<string, string> getKey in getAssessId)
            {
                int value = int.Parse(getKey.Value);
                int value1 = int.Parse(getKey.Key);
                if (value == get_studentid && value1 == get_assess_comp_id)
                {
                    isFound = true;
                }

            }
            if (isFound == true)
            {
                MessageBox.Show("Assessment for that component already exists");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into StudentResult values (@StudentId, @AssessmentComponentId, @RubricMeasurementId,CAST(@EvaluationDate AS Datetime))", con);
                cmd.Parameters.AddWithValue("@StudentId", get_studentid);
                cmd.Parameters.AddWithValue("@AssessmentComponentId", get_assess_comp_id);
                cmd.Parameters.AddWithValue("@RubricMeasurementId", get_rubric_id);
                cmd.Parameters.AddWithValue("@EvaluationDate", get_date);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
                stn_id_Box.Text = "--select";
                att_id_box.Text = "--select";
                attendence_Box.Text = "--select";
            }

            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.stn_crud_panel.Controls.Clear();
            Student_Result_Info stn_res_info_up_Form = new Student_Result_Info() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            stn_res_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.stn_crud_panel.Controls.Add(stn_res_info_up_Form);
            stn_res_info_up_Form.Show();
        }
    }
}
