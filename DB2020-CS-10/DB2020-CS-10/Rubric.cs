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
    
    public partial class Rubric : Form
    {
        Dictionary<string, string> clo_ID = null;
        Dictionary<string, string> rubric_ID = null;
        Dictionary<string, string> rubricLevel_ID = null;
        Dictionary<string, string> check_rubricLevel_ID = null;
        int id = 1;
        bool isFound = false;
        public Rubric()
        {
            InitializeComponent();
        }

        private void Rubric_Load(object sender, EventArgs e)
        {
            clo_ID = new Dictionary<string, string>();
            rubric_ID = new Dictionary<string, string>();
            rubricLevel_ID = new Dictionary<string, string>();
            check_rubricLevel_ID = new Dictionary<string, string>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clo", con);
            SqlCommand cmd1 = new SqlCommand("SELECT MAX(Id) AS Id FROM Rubric", con);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
           
            foreach (DataRow rows in dt.Rows)
            {
                clo_ID.Add(rows["Id"].ToString(), rows["Name"].ToString());
            }
            foreach (DataRow rows in dt1.Rows)
            {
                rubric_ID.Add(rows["Id"].ToString(), rows["Id"].ToString());
            }
            
            foreach (DataRow value in dt1.Rows)
            {
               if(value["Id"].ToString() == "")
               {
                    id = 1;    
               }
               else
               {
                    id = int.Parse(value["Id"].ToString());
                    id += 1;
               }
            }
            foreach (string value in clo_ID.Values)
            {
                clo_id_box.Items.Add(value);
            }
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Rubric", con);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            foreach (DataRow rows in dt2.Rows)
            {
                rubricLevel_ID.Add(rows["Id"].ToString(), rows["Details"].ToString());
            }
            foreach (string value in rubricLevel_ID.Values)
            {
                rb_id_Box.Items.Add(value);
            }
        }

        private void add_clo_btn_Click(object sender, EventArgs e)
        {
            int selectedIndex = clo_id_box.SelectedIndex;
            int get_id = int.Parse(clo_ID.Keys.ElementAt(selectedIndex));
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Rubric values(@Id,@Details,@CloId)", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Details", rubric_detail.Text);
            cmd.Parameters.AddWithValue("@CloId", get_id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");
            clo_id_box.Text = "--select";
            measurement_Box.Text = "--select";
        }

        private void add_rlevel_btn_Click(object sender, EventArgs e)
        {
            if (rb_id_Box.Text == "--select" || measurement_Box.Text == "--select" || rb_detail.Text == " ")
            {
                MessageBox.Show("Please fill the fields");
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                int selectedIndex = rb_id_Box.SelectedIndex;
                int get_rubricid = int.Parse(rubricLevel_ID.Keys.ElementAt(selectedIndex));
                SqlCommand cmd1 = new SqlCommand("SELECT Id,MeasurementLevel FROM RubricLevel WHERE RubricId = @Id", con);
                cmd1.Parameters.AddWithValue("@Id", get_rubricid);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                foreach (DataRow rows in dt1.Rows)
                {
                    check_rubricLevel_ID.Add(rows["Id"].ToString(), rows["MeasurementLevel"].ToString());
                }
                
                foreach (KeyValuePair<string, string> getKey in check_rubricLevel_ID)
                {
                    int value = int.Parse(getKey.Value);
                    if (value == int.Parse(measurement_Box.Text))
                    {
                        isFound = true;
                    }
                }
                if (isFound == true)
                {
                    MessageBox.Show("Rubric with same level exists");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("Insert into RubricLevel values(@RubricId,CAST(@Details AS nvarchar(MAX)),@MeasurementLevel)", con);
                    cmd.Parameters.AddWithValue("@RubricId", get_rubricid);
                    cmd.Parameters.AddWithValue("@Details", rb_detail.Text);
                    cmd.Parameters.AddWithValue("@MeasurementLevel", int.Parse(measurement_Box.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                    rb_id_Box.Text = "--select";
                    measurement_Box.Text = "--select";
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.rubric_update_Panel.Controls.Clear();
            Rubric_Info_Update rubric_info_up_Form = new Rubric_Info_Update() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            rubric_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.rubric_update_Panel.Controls.Add(rubric_info_up_Form);
            rubric_info_up_Form.Show(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.rubric_update_Panel.Controls.Clear();
            Rubric_Level_Info rubricLevel_info_up_Form = new Rubric_Level_Info() { Dock = DockStyle.Fill, TopMost = true, TopLevel = false };
            rubricLevel_info_up_Form.FormBorderStyle = FormBorderStyle.None;
            this.rubric_update_Panel.Controls.Add(rubricLevel_info_up_Form);
            rubricLevel_info_up_Form.Show();
        }
    }
}
