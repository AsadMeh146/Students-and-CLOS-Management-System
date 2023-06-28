
namespace DB2020_CS_10
{
    partial class Student_Info_Update
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.stn_info_grid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.delete_stn_btn = new System.Windows.Forms.Button();
            this.update_stn_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stn_info_grid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 511);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.stn_info_grid, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(900, 449);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // stn_info_grid
            // 
            this.stn_info_grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stn_info_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stn_info_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stn_info_grid.Location = new System.Drawing.Point(61, 84);
            this.stn_info_grid.Name = "stn_info_grid";
            this.stn_info_grid.Size = new System.Drawing.Size(778, 281);
            this.stn_info_grid.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.30478F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.69522F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel2.Controls.Add(this.refresh_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.delete_stn_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.update_stn_btn, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(900, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.refresh_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(88, 12);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(98, 37);
            this.refresh_btn.TabIndex = 0;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // delete_stn_btn
            // 
            this.delete_stn_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete_stn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.delete_stn_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.delete_stn_btn.ForeColor = System.Drawing.Color.White;
            this.delete_stn_btn.Location = new System.Drawing.Point(394, 12);
            this.delete_stn_btn.Name = "delete_stn_btn";
            this.delete_stn_btn.Size = new System.Drawing.Size(94, 37);
            this.delete_stn_btn.TabIndex = 1;
            this.delete_stn_btn.Text = "Delete";
            this.delete_stn_btn.UseVisualStyleBackColor = false;
            this.delete_stn_btn.Click += new System.EventHandler(this.delete_stn_btn_Click);
            // 
            // update_stn_btn
            // 
            this.update_stn_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_stn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(93)))));
            this.update_stn_btn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.update_stn_btn.ForeColor = System.Drawing.Color.White;
            this.update_stn_btn.Location = new System.Drawing.Point(708, 12);
            this.update_stn_btn.Name = "update_stn_btn";
            this.update_stn_btn.Size = new System.Drawing.Size(91, 37);
            this.update_stn_btn.TabIndex = 2;
            this.update_stn_btn.Text = "Update";
            this.update_stn_btn.UseVisualStyleBackColor = false;
            this.update_stn_btn.Click += new System.EventHandler(this.update_stn_btn_Click);
            // 
            // Student_Info_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(906, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Student_Info_Update";
            this.Text = "Student_Info_Update";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stn_info_grid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button delete_stn_btn;
        private System.Windows.Forms.Button update_stn_btn;
        private System.Windows.Forms.DataGridView stn_info_grid;
    }
}