using SAMS.Forms.ReportForms;
using SAMS.Forms.StudentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS.Forms.SearchForms
{
    public partial class frmSearch : Form
    {
        public frmPrintReport PrintReportForm;  
        public frmSearch()
        {
            InitializeComponent();
        }

        public frmSearch (frmPrintReport frm, string searchvalue)
        {
            PrintReportForm = frm;
            StudentlistFillGrid(searchvalue);
        }

        private void StudentlistFillGrid(string searchvalue) 
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = string.Format("SELECT [StdID] as ID,[Program_ID], [ProgramName] as [Program],[Session_ID], [SessionName] as [Session],[FullName] as [Name],[FatherName] as [Father Name] " +
                                        ",[EnrollNo] as [Enroll No] ,[Reg_No] as [Registration No],[ClassNo] as [Roll No],[Entry_Date] as [Reg Date],[NIC],[CNIC] as [Father NIC] " +
                                        ",[Address] as [Address],[Dob] as [Date of Birth],[Religion] as [Religion],[Nationality] as [Nationality],[Description],[MachineFingerNo],[Photo]  " +
                                        " FROM [StudentAttendanceSystemDb].[dbo].[v_StudentList]");
                //query = string.Format("select * from v_TimeTablesList");
            }
            else
            {
                query = string.Format("SELECT [StdID] as ID,[Program_ID], [ProgramName] as [Program],[Session_ID], [SessionName] as [Session],[FullName] as [Name],[FatherName] as [Father Name] " +
                                        ",[EnrollNo] as [Enroll No] ,[Reg_No] as [Registration No],[ClassNo] as [Roll No],[Entry_Date] as [Reg Date],[NIC],[CNIC] as [Father NIC] " +
                                        ",[Address] as [Address],[Dob] as [Date of Birth],[Religion] as [Religion],[Nationality] as [Nationality],[Description],[MachineFingerNo], [Photo]  " +
                                        " FROM [StudentAttendanceSystemDb].[dbo].[v_StudentList] where (ProgramName + ' '+ SessionName+ ' '+FullName+' '+FatherName+' '+EnrollNo+' '+Reg_No+' '+Description+' '+NIC+' '+CNIC+ ' '+Religion+' '+Nationality+' '+Address) like '%" + searchvalue + "%'");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                dgvStudentsList.DataSource = dt;
                dgvStudentsList.Columns[1].Visible = false;
                dgvStudentsList.Columns[3].Visible = false;
                //dgvStudentsList.Columns[5].Visible = false;
                //dgvStudentsList.Columns[7].Visible = false;
                //dgvStudentsList.Columns[16].Visible = false;
                dgvStudentsList.Columns[0].Width = 100;
                dgvStudentsList.Columns[4].Width = 120;
                dgvStudentsList.Columns[6].Width = 120;
                dgvStudentsList.Columns[8].Width = 200;
                dgvStudentsList.Columns[9].Width = 120;
                dgvStudentsList.Columns[10].Width = 120;
                dgvStudentsList.Columns[11].Width = 120;
                dgvStudentsList.Columns[12].Width = 120;
                dgvStudentsList.Columns[13].Width = 120;
                dgvStudentsList.Columns[14].Width = 100;
                dgvStudentsList.Columns[15].Width = 100;
                dgvStudentsList.Columns[16].Width = 100;
                dgvStudentsList.Columns[17].Width = 100;
                dgvStudentsList.Columns[18].Visible = false;
                dgvStudentsList.Columns[19].Visible = false;
            }
            else
            {
                dgvStudentsList.DataSource = null;
            }
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvStudentsList != null)
            {
                if(dgvStudentsList.Rows.Count > 0)
                {
                    if (dgvStudentsList.SelectedRows.Count == 1)
                    {
                        PrintReportForm.stdnid = Convert.ToString(dgvStudentsList.CurrentRow.Cells[0].Value);
                        PrintReportForm.txtStdSearch.Text = Convert.ToString(dgvStudentsList.CurrentRow.Cells[1].Value);
                    } else
                    {
                        MessageBox.Show("Please Select One Record!");
                    }

                } else
                {
                    MessageBox.Show("List is Empty! Search Again!");
                }
            } else
            {

            }
        }
    }
}
