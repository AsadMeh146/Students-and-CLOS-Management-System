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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace DB2020_CS_10
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (report_Box.Text == "Assessment Wise Result")
            {
                Document dp = new Document();
                PdfWriter.GetInstance(dp, new FileStream("E:\\PDF Generate\\Assessment Wise Result.pdf", FileMode.Create));
                dp.Open();
                var p = new Paragraph("Assessment Wise Result Report    \n");
                var p1 = new Paragraph("\n");
                dp.Add(p);
                dp.Add(p1);
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Student.RegistrationNumber, Assessment.Title, ACA.Name, ACA.TotalMarks, RL1.MeasurementLevel, R1.[Maximum Level], ((CAST(RL1.MeasurementLevel as float) * cast(ACA.TotalMarks as float)) / cast(R1.[Maximum Level] as float)) AS ObtainedMarks FROM(SELECT A.Id AS AssessmentID, AC.Id AS AssessmentComponentId, MAX(RL.MeasurementLevel) AS[Maximum Level] FROM Assessment AS A INNER JOIN AssessmentComponent AS AC ON A.Id = AC.AssessmentId INNER JOIN RubricLevel AS RL ON RL.RubricId = AC.RubricId GROUP BY A.Id, AC.Id) AS R1 JOIN StudentResult ON R1.AssessmentComponentId = StudentResult.AssessmentComponentId JOIN AssessmentComponent AS ACA ON R1.AssessmentComponentId = ACA.Id JOIN RubricLevel AS RL1 ON StudentResult.RubricMeasurementId = RL1.Id JOIN Assessment ON Assessment.Id = R1.AssessmentID JOIN Student ON Student.Id = StudentResult.StudentId", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.Padding = 6;
                table.DefaultCell.PaddingTop = 10;
                table.WidthPercentage = 100;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    table.WidthPercentage = 100;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
                        }
                    }
                }
                dp.Add(table);
                dp.Close();
                MessageBox.Show("PDF generated successfully");
            }
            else if (report_Box.Text == "Date Wise Attendance Percentage Report")
            {
                Document dp = new Document();
                PdfWriter.GetInstance(dp, new FileStream("E:\\PDF Generate\\Attendance Details.pdf", FileMode.Create));
                dp.Open();
                var p = new Paragraph("Date Wise Attendance Percentage Report \n");
                var p1 = new Paragraph("\n");

                dp.Add(p);
                dp.Add(p1);


                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT ClassAttendance.AttendanceDate,((Cast(R1.PresentStudents as float) / (CAST(R2.TotalStudents as float))) * 100) AS AttendencePercentage FROM (SELECT StudentAttendance.AttendanceId,COUNT(StudentAttendance.StudentId) AS PresentStudents FROM StudentAttendance INNER JOIN ClassAttendance ON StudentAttendance.AttendanceId = ClassAttendance.Id WHERE AttendanceStatus = 1 GROUP BY StudentAttendance.AttendanceId) AS R1 INNER JOIN ClassAttendance ON R1.AttendanceId = ClassAttendance.Id,(SELECT Count(Id) AS TotalStudents FROM Student WHERE Status = 5) AS R2", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.Padding = 6;
                table.DefaultCell.PaddingTop = 10;
                table.WidthPercentage = 100;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    table.WidthPercentage = 100;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
                        }
                    }
                }
                dp.Add(table);
                dp.Close();
                MessageBox.Show("PDF generated successfully");
                report_Box.Text = "--select";
            }
            else if (report_Box.Text == "CLO Wise Result")
            {
                Document dp = new Document();
                PdfWriter.GetInstance(dp, new FileStream("E:\\PDF Generate\\CLO Wise Result.pdf", FileMode.Create));
                dp.Open();
                var p = new Paragraph("CLO Wise Result Report \n");
                var p1 = new Paragraph("\n");
                dp.Add(p);
                dp.Add(p1);

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Student.RegistrationNumber, Clo.Name, SUM(ACA.TotalMarks) AS TotalMarks, SUM(((CAST(RL1.MeasurementLevel as float) * cast(ACA.TotalMarks as float)) / cast(R1.[Maximum Level] as float))) AS ObtainedMarks FROM(SELECT A.Id AS AssessmentID, AC.Id AS AssessmentComponentId, MAX(RL.MeasurementLevel) AS[Maximum Level] FROM Assessment AS A INNER JOIN AssessmentComponent AS AC ON A.Id = AC.AssessmentId INNER JOIN RubricLevel AS RL ON RL.RubricId = AC.RubricId GROUP BY A.Id, AC.Id) AS R1 JOIN StudentResult ON R1.AssessmentComponentId = StudentResult.AssessmentComponentId JOIN AssessmentComponent AS ACA ON R1.AssessmentComponentId = ACA.Id JOIN RubricLevel AS RL1 ON StudentResult.RubricMeasurementId = RL1.Id JOIN Assessment ON Assessment.Id = R1.AssessmentID JOIN Student ON Student.Id = StudentResult.StudentId JOIN Rubric ON Rubric.Id = RL1.RubricId JOIN Clo ON Rubric.CloId = Clo.Id GROUP BY Student.RegistrationNumber, Clo.Name", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.Padding = 6;
                table.DefaultCell.PaddingTop = 10;
                table.WidthPercentage = 100;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    table.WidthPercentage = 100;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
                        }
                    }
                }
                dp.Add(table);
                dp.Close();
                MessageBox.Show("PDF generated successfully");
                report_Box.Text = "--select";
            }
            else if (report_Box.Text == "Student Attendance Report")
            {
                Document dp = new Document();
                PdfWriter.GetInstance(dp, new FileStream("E:\\PDF Generate\\Student Attendance.pdf", FileMode.Create));
                dp.Open();
                var p = new Paragraph("Student Attendance Report \n");
                var p1 = new Paragraph("\n");
                dp.Add(p);
                dp.Add(p1);


                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT R2.Id,Student.RegistrationNumber,R2.PresentDays,((CAST(R2.PresentDays as float) / CAST(R2.TotalDays AS float)) * 100) AS [Attendance Percentage] FROM (SELECT Student.Id,R1.PresentDays,(SELECT COUNT(Id) FROM ClassAttendance) AS TotalDays FROM (SELECT Student.Id,COUNT(Student.Id) AS PresentDays FROM Student INNER JOIN StudentAttendance ON Student.Id = StudentAttendance.StudentId WHERE StudentAttendance.AttendanceStatus = 1 GROUP BY Student.Id) AS R1 INNER JOIN Student ON Student.Id = R1.Id) AS R2 INNER JOIN Student ON Student.Id = R2.Id", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.Padding = 6;
                table.DefaultCell.PaddingTop = 10;
                table.WidthPercentage = 100;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    table.WidthPercentage = 100;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
                        }
                    }
                }
                dp.Add(table);
                dp.Close();
                MessageBox.Show("PDF generated successfully");
                report_Box.Text = "--select";
            }
            else if (report_Box.Text == "Class Attendence Report")
            {
                Document dp = new Document();
                PdfWriter.GetInstance(dp, new FileStream("E:\\PDF Generate\\Class Attendance.pdf", FileMode.Create));
                dp.Open();
                var p = new Paragraph("Class Attendance Report \n");
                var p1 = new Paragraph("\n");
                dp.Add(p);
                dp.Add(p1);


                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Student.RegistrationNumber,ClassAttendance.AttendanceDate,StudentAttendance.AttendanceStatus FROM Student,StudentAttendance,ClassAttendance WHERE Student.Id = StudentAttendance.StudentId AND ClassAttendance.Id = StudentAttendance.AttendanceId", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                table.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;
                table.DefaultCell.Padding = 6;
                table.DefaultCell.PaddingTop = 10;
                table.WidthPercentage = 100;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD)));
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    table.WidthPercentage = 100;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
                        }
                    }
                }
                dp.Add(table);
                dp.Close();
                MessageBox.Show("PDF generated successfully");
                report_Box.Text = "--select";
            }
            else if (report_Box.Text == "--select")
            {
                MessageBox.Show("Select proper report");
            }
            

        }
    }
}
