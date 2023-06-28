
namespace DB2020_CS_10
{
    partial class Assessments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.assess_title = new System.Windows.Forms.TextBox();
            this.assess_marks = new System.Windows.Forms.TextBox();
            this.assess_weightage = new System.Windows.Forms.TextBox();
            this.add_clo_btn = new System.Windows.Forms.Button();
            this.assess_date = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.assess_comp_name = new System.Windows.Forms.TextBox();
            this.assess_comp_marks = new System.Windows.Forms.TextBox();
            this.assess_comp_datecreated = new System.Windows.Forms.DateTimePicker();
            this.rubricID_Box = new System.Windows.Forms.ComboBox();
            this.assess_Id_Box = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.assess_update_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.assessment_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.assess_update_panel.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(897, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 522);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(883, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Assessment";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.assess_title, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.assess_marks, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.assess_weightage, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.add_clo_btn, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.assess_date, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.44118F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.55882F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(877, 490);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Created : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Marks : ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Weightage : ";
            // 
            // assess_title
            // 
            this.assess_title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_title.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_title.Location = new System.Drawing.Point(222, 7);
            this.assess_title.Name = "assess_title";
            this.assess_title.Size = new System.Drawing.Size(361, 30);
            this.assess_title.TabIndex = 4;
            // 
            // assess_marks
            // 
            this.assess_marks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_marks.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_marks.Location = new System.Drawing.Point(222, 125);
            this.assess_marks.Name = "assess_marks";
            this.assess_marks.Size = new System.Drawing.Size(361, 30);
            this.assess_marks.TabIndex = 6;
            // 
            // assess_weightage
            // 
            this.assess_weightage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_weightage.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_weightage.Location = new System.Drawing.Point(222, 187);
            this.assess_weightage.Name = "assess_weightage";
            this.assess_weightage.Size = new System.Drawing.Size(361, 30);
            this.assess_weightage.TabIndex = 7;
            // 
            // add_clo_btn
            // 
            this.add_clo_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_clo_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.add_clo_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.add_clo_btn.ForeColor = System.Drawing.Color.White;
            this.add_clo_btn.Location = new System.Drawing.Point(452, 245);
            this.add_clo_btn.Name = "add_clo_btn";
            this.add_clo_btn.Size = new System.Drawing.Size(191, 41);
            this.add_clo_btn.TabIndex = 9;
            this.add_clo_btn.Text = "ADD";
            this.add_clo_btn.UseVisualStyleBackColor = false;
            this.add_clo_btn.Click += new System.EventHandler(this.add_clo_btn_Click);
            // 
            // assess_date
            // 
            this.assess_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_date.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_date.Location = new System.Drawing.Point(222, 62);
            this.assess_date.Name = "assess_date";
            this.assess_date.Size = new System.Drawing.Size(361, 30);
            this.assess_date.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(883, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assessment Component";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.71627F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.28373F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.assess_comp_name, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.assess_comp_marks, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.assess_comp_datecreated, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.rubricID_Box, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.assess_Id_Box, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.74194F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.25806F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(877, 490);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(75, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name : ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rubric Id : ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Marks : ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date Created : ";
            // 
            // assess_comp_name
            // 
            this.assess_comp_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_comp_name.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_comp_name.Location = new System.Drawing.Point(219, 11);
            this.assess_comp_name.Name = "assess_comp_name";
            this.assess_comp_name.Size = new System.Drawing.Size(361, 30);
            this.assess_comp_name.TabIndex = 6;
            // 
            // assess_comp_marks
            // 
            this.assess_comp_marks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_comp_marks.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_comp_marks.Location = new System.Drawing.Point(219, 140);
            this.assess_comp_marks.Name = "assess_comp_marks";
            this.assess_comp_marks.Size = new System.Drawing.Size(361, 30);
            this.assess_comp_marks.TabIndex = 7;
            // 
            // assess_comp_datecreated
            // 
            this.assess_comp_datecreated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_comp_datecreated.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_comp_datecreated.Location = new System.Drawing.Point(219, 202);
            this.assess_comp_datecreated.Name = "assess_comp_datecreated";
            this.assess_comp_datecreated.Size = new System.Drawing.Size(361, 30);
            this.assess_comp_datecreated.TabIndex = 8;
            // 
            // rubricID_Box
            // 
            this.rubricID_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rubricID_Box.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.rubricID_Box.FormattingEnabled = true;
            this.rubricID_Box.Location = new System.Drawing.Point(219, 73);
            this.rubricID_Box.Name = "rubricID_Box";
            this.rubricID_Box.Size = new System.Drawing.Size(361, 31);
            this.rubricID_Box.TabIndex = 10;
            this.rubricID_Box.Text = "--select";
            // 
            // assess_Id_Box
            // 
            this.assess_Id_Box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.assess_Id_Box.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.assess_Id_Box.FormattingEnabled = true;
            this.assess_Id_Box.Location = new System.Drawing.Point(219, 260);
            this.assess_Id_Box.Name = "assess_Id_Box";
            this.assess_Id_Box.Size = new System.Drawing.Size(361, 31);
            this.assess_Id_Box.TabIndex = 11;
            this.assess_Id_Box.Text = "--select";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Assessment Id : ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(451, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(883, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update/Delete";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.assess_update_panel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(877, 490);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // assess_update_panel
            // 
            this.assess_update_panel.Controls.Add(this.tableLayoutPanel6);
            this.assess_update_panel.Controls.Add(this.tableLayoutPanel5);
            this.assess_update_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assess_update_panel.Location = new System.Drawing.Point(3, 3);
            this.assess_update_panel.Name = "assess_update_panel";
            this.assess_update_panel.Size = new System.Drawing.Size(871, 484);
            this.assess_update_panel.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.assessment_panel, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(871, 430);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // assessment_panel
            // 
            this.assessment_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assessment_panel.Location = new System.Drawing.Point(3, 3);
            this.assessment_panel.Name = "assessment_panel";
            this.assessment_panel.Size = new System.Drawing.Size(865, 424);
            this.assessment_panel.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(871, 54);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(124, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 48);
            this.button2.TabIndex = 0;
            this.button2.Text = "Assessment Info.";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(525, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 47);
            this.button3.TabIndex = 1;
            this.button3.Text = "Assessment Component Info.";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Assessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(897, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Assessments";
            this.Text = "Assessments";
            this.Load += new System.EventHandler(this.Assessments_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.assess_update_panel.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox assess_title;
        private System.Windows.Forms.TextBox assess_marks;
        private System.Windows.Forms.TextBox assess_weightage;
        private System.Windows.Forms.Button add_clo_btn;
        private System.Windows.Forms.DateTimePicker assess_date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox assess_comp_name;
        private System.Windows.Forms.TextBox assess_comp_marks;
        private System.Windows.Forms.DateTimePicker assess_comp_datecreated;
        private System.Windows.Forms.ComboBox rubricID_Box;
        private System.Windows.Forms.ComboBox assess_Id_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel assess_update_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel assessment_panel;
    }
}