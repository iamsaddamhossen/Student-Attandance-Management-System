using SAMS.SourceCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMS.Forms.TimeTableForms
{
    public partial class frmTimeTables : Form
    {
        public frmTimeTables()
        {
            InitializeComponent();
            combo_helpers.Sessions(cmbSession);
            combo_helpers.Programmes(cmbProgramme);
            combo_helpers.SemesterTypes(cmbSemesterType);
            combo_helpers.Subjects(cmbSubject);
            cmbDay.SelectedIndex = 0;
        }

        private void frmTimeTables_Load(object sender, EventArgs e)
        {
            lbllsActive.Visible = false;
            chkIsActive.Visible = false;
            combo_helpers.Sessions(cmbSession);
            combo_helpers.Programmes(cmbProgramme);
            combo_helpers.SemesterTypes(cmbSemesterType);
            combo_helpers.Subjects(cmbSubject);
            FillGrid("");
        }

        private void frmTimeTables_Activated(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSession);
            combo_helpers.Programmes(cmbProgramme);
            combo_helpers.SemesterTypes(cmbSemesterType);
            combo_helpers.Subjects(cmbSubject);
            FillGrid("");
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                //query = string.Format("select SubjectTimeTableID as [ID], Session_ID, SessionName as [Session], dbo.SubjectsTimeTable.Program_ID,ProgramName as [Program],Semester_ID, SemesterName as [Semester], Subject_ID, SubjectName as [Subject], FromTime as [From Time], ToTime as [To Time], [Day], [Year], Reg_Date as [Reg Date], [Description], IsActive as [Active] from v_TimeTablesList");
                query = string.Format("select * from v_TimeTablesList");
            }
            else
            {
                query = string.Format("select SubjectTimeTableID as [ID], Session_ID, SessionName as [Session], dbo.SubjectsTimeTable.Program_ID,ProgramName as [Program],Semester_ID, SemesterName as [Semester], Subject_ID, SubjectName as [Subject], FromTime as [From Time], ToTime as [To Time], [Day], [Year], Reg_Date as [Reg Date], [Description], IsActive as [Active], SemesterType_ID from v_TimeTablesList where (SessionName + ' '+ ProgramName+ ' '+SemesterName+' '+SubjectName+' '+Day+' '+Year+' '+Description) like '%" + searchvalue + "%'");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                dgvTimeTable.DataSource = dt;
                dgvTimeTable.Columns[1].Visible = false;
                dgvTimeTable.Columns[3].Visible = false;
                dgvTimeTable.Columns[5].Visible = false;
                dgvTimeTable.Columns[7].Visible = false;
                dgvTimeTable.Columns[16].Visible = false;
                dgvTimeTable.Columns[0].Width = 100;
                dgvTimeTable.Columns[2].Width = 200;
                dgvTimeTable.Columns[4].Width = 120;
                dgvTimeTable.Columns[6].Width = 120;
                dgvTimeTable.Columns[8].Width = 200;
                dgvTimeTable.Columns[9].Width = 120;
                dgvTimeTable.Columns[10].Width = 120;
                dgvTimeTable.Columns[11].Width = 120;
                dgvTimeTable.Columns[12].Width = 120;
                dgvTimeTable.Columns[13].Width = 120;
                dgvTimeTable.Columns[14].Width = 300;
                dgvTimeTable.Columns[15].Width = 100;
            }
            else
            {
                dgvTimeTable.DataSource = null;
            }
        }

        private  void ResetForm()
        {
            FormClear();
            dtpFromTime.Value = DateTime.Now;
            dtpToTime.Value = DateTime.Now;
            dtpYear.Value = DateTime.Now;
            cmbDay.SelectedIndex = 0;

        } 
        private void FormClear()
        {
   
            txtDescription.Clear();
            cmbSession.SelectedIndex = 0;
            cmbProgramme.SelectedIndex = 0;
            cmbSemesterType.SelectedIndex = 0;
            cmbSubject.SelectedIndex = 0;

        }

        private void DesibleComponents()
        {
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            dgvTimeTable.Enabled = false;
            lbllsActive.Visible = true;
            chkIsActive.Visible = true;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void EnableComponents()
        {
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            dgvTimeTable.Enabled = true;
            lbllsActive.Visible = false;
            chkIsActive.Visible = false;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            ResetForm();
        }

        private void cmbSemesterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_helpers.Semesters(cmbSemester, Convert.ToString(cmbSemesterType.SelectedValue));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(cmbSession.SelectedIndex == 0)
            {
                ep.SetError(cmbSession, "Please Select Session!");
                cmbSession.Focus();
                return;
            }
            if(cmbProgramme.SelectedIndex == 0)
            {
                ep.SetError(cmbProgramme, "Please Select Programme!");
                cmbProgramme.Focus();
                return;
            }
            if (cmbSemesterType.SelectedIndex == 0)
            {
                ep.SetError(cmbSemesterType, "Please Select Semester Type!");
                cmbSemesterType.Focus();
                return;
            }
            if(cmbSemester.SelectedIndex == 0)
            {
                ep.SetError(cmbSemester, "Please Select Semester!");
                cmbSemester.Focus();
                return;
            }
            if (cmbSubject.SelectedIndex == 0)
            {
                ep.SetError(cmbSubject, "Please Select Subject!");
                cmbSubject.Focus();
                return;
            }

            if (cmbDay.SelectedIndex == 0)
            {
                ep.SetError(cmbDay, "Please Select Day!");
                cmbDay.Focus();
                return;
            }

            var fromMints = dtpFromTime.Value.Minute;
            var toMints = dtpToTime.Value.Minute;
            var deffMinuts = toMints - fromMints;

            var fromHours = dtpFromTime.Value.Hour;
            var toHours = dtpToTime.Value.Hour;
            var deffHours = toHours - fromHours;

            if (deffHours == 0 && deffMinuts < 30)
            {
                ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                dtpFromTime.Focus();
                return;
            }

            if (deffHours > 3 && deffMinuts > 0)
            {
                ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                dtpFromTime.Focus();
                return;
            }

            if (deffMinuts > 0)
            {
                if (deffHours >= 3 || deffHours < 0)
                {
                    ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                    dtpFromTime.Focus();
                    return;
                }
            }

            if (deffHours > 3 || deffHours < 0)
            {
                ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                dtpFromTime.Focus();
                return;
            }

            var selectyear = dtpYear.Value.Year;
            var currentyear = DateTime.Now.Year;
            if(selectyear < currentyear)
            {
                ep.SetError(dtpYear, "Can't be Set Time Table for Previous Year. Otherwise please contact to high authority.");
                dtpYear.Focus();
                return;
            }

            DataTable dt = new DataTable();
            dt = DatabaseAccess.SelectData(string.Format("select * from SubjectsTimeTable where ProgramID='{0}' and SemesterID='{1}' and SessionID='{2}' and Subject_ID='{3}' and IsActive='1'", 
                cmbProgramme.SelectedValue, cmbSemester.SelectedValue, cmbSession.SelectedValue, cmbSubject.SelectedValue));

            if(dt !=null)
            {
                if(dt.Rows.Count > 0)
                {
                    ep.SetError(cmbSemester, "Subject is already add in this semester! Please contact to administrator.");
                    cmbSemester.Focus();
                    return;
                }
            }

            dt = null; 
            dt = new DataTable();
            dt = DatabaseAccess.SelectData(string.Format("select * from SubjectsTimeTable where ProgramID='{0}' and SemesterID='{1}' and SessionID='{2}' and IsActive='1' and convert(varchar(5), FromTime, 108) = convert(varchar(5), '{3}', 108) and convert(varchar(5), ToTime, 108) = convert(varchar(5), '{4}', 108) and Day='{5}'",
                cmbProgramme.SelectedValue, cmbSemester.SelectedValue, cmbSession.SelectedValue, dtpFromTime.Value.TimeOfDay, dtpToTime.Value.TimeOfDay, cmbDay.Text));

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(cmbSubject, "Selecteed Time Period is Already Allocated to Another Subject! Please contact to administrator.");
                    cmbSubject.Focus();
                    return;
                }
            }




            string insertquery = string.Format("insert into SubjectsTimeTable(Program_ID, Semester_ID, Session_ID, Subject_ID, FromTime, ToTime,[Day],[Year], Reg_Date,[Description], IsActive)" +
                "Values('{0}','{1}','{2}','{3}', convert(varchar(5), '{4}', 108), convert(varchar(5), '{5}', 108),'{6}','{7}','{8}','{9}','{10}')", cmbProgramme.SelectedValue, cmbSemester.SelectedValue, cmbSession.SelectedValue, cmbSubject.SelectedValue, dtpFromTime.Value.TimeOfDay,
                dtpToTime.Value.TimeOfDay, cmbDay.Text, dtpYear.Value.Year, DateTime.Now.ToString("yyyy/MM/dd"), txtDescription.Text.Trim(), 1);

            bool result = DatabaseAccess.InsertData(insertquery);
            if(result == true)
            {
                MessageBox.Show("Successfully");
                FormClear();
                FillGrid("");
            } else
            {
                MessageBox.Show("Unexpected error is occured! Please contact to administrator");
            }

        }

        private void btnSessionRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSession);
           
        }

        private void btnProgrammeRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Programmes(cmbProgramme);
        }

        private void btnSemesterTypeRefresh_Click(object sender, EventArgs e)
        {
           
            combo_helpers.SemesterTypes(cmbSemesterType);
            
        }

        private void btnSemesterRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Semesters(cmbSemester, Convert.ToString(cmbSemesterType.SelectedValue));
        }

        private void btnSubjectRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Subjects(cmbSubject);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //FormClear();
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableComponents();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbSession.SelectedIndex == 0)
            {
                ep.SetError(cmbSession, "Please Select Session!");
                cmbSession.Focus();
                return;
            }
            if (cmbProgramme.SelectedIndex == 0)
            {
                ep.SetError(cmbProgramme, "Please Select Programme!");
                cmbProgramme.Focus();
                return;
            }
            if (cmbSemesterType.SelectedIndex == 0)
            {
                ep.SetError(cmbSemesterType, "Please Select Semester Type!");
                cmbSemesterType.Focus();
                return;
            }
            if (cmbSemester.SelectedIndex == 0)
            {
                ep.SetError(cmbSemester, "Please Select Semester!");
                cmbSemester.Focus();
                return;
            }
            if (cmbSubject.SelectedIndex == 0)
            {
                ep.SetError(cmbSubject, "Please Select Subject!");
                cmbSubject.Focus();
                return;
            }

            if (cmbDay.SelectedIndex == 0)
            {
                ep.SetError(cmbDay, "Please Select Day!");
                cmbDay.Focus();
                return;
            }

            

            var fromMints = dtpFromTime.Value.Minute;
            var toMints = dtpToTime.Value.Minute;
            var deffMinuts = toMints - fromMints;

            var fromHours = dtpFromTime.Value.Hour;
            var toHours = dtpToTime.Value.Hour;
            var deffHours = toHours - fromHours;

            //int ischeckforupdate = 1;
            int isactive = 1;
            isactive = chkIsActive.Checked == true ? 1 : 0;

            if (deffHours == 0 && deffMinuts < 30)
            {
                ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                dtpFromTime.Focus();
                return;
            }

            if (deffHours > 3 && deffMinuts > 0)
            {
                ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                dtpFromTime.Focus();
                return;
            }

            if (deffMinuts > 0)
            {
                if (deffHours >= 3 || deffHours < 0)
                {
                    ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                    dtpFromTime.Focus();
                    return;
                }
            }

            if (deffHours > 3 || deffHours < 0)
            {
                ep.SetError(dtpFromTime, "Please Set Class Start Time and To Time. Note: Class Min Time is 30mints and Max time is 3 hrs!");
                dtpFromTime.Focus();
                return;
            }

            var selectyear = dtpYear.Value.Year;
            var currentyear = DateTime.Now.Year;
            if (selectyear < currentyear)
            {
                ep.SetError(dtpYear, "Can't be Set Time Table for Previous Year. Otherwise please contact to high authority.");
                dtpYear.Focus();
                return;
            }

            string checkquery = string.Empty;
            if(isactive == 1)
            {
                checkquery = string.Format("select * from SubjectsTimeTable where ProgramID='{0}' and SemesterID='{1}' and SessionID='{2}' and Subject_ID='{3}' and IsActive='1' and SubjectTimeTableID != '{4}'",
               cmbProgramme.SelectedValue, cmbSemester.SelectedValue, cmbSession.SelectedValue, cmbSubject.SelectedValue, dgvTimeTable.CurrentRow.Cells[0].Value);

                DataTable dt = new DataTable();
                dt = DatabaseAccess.SelectData(checkquery);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(cmbSemester, "Subject is already add in this semester! Please contact to administrator.");
                        cmbSemester.Focus();
                        return;
                    }
                }


                checkquery = string.Format("select * from SubjectsTimeTable where ProgramID='{0}' and SemesterID='{1}' and SessionID='{2}' and IsActive='1' and convert(varchar(5), FromTime, 108) = convert(varchar(5), '{3}', 108) and convert(varchar(5), ToTime, 108) = convert(varchar(5), '{4}', 108) and SubjectTimeTableID != '{5}' and Day='{6}'",
                    cmbProgramme.SelectedValue, cmbSemester.SelectedValue, cmbSession.SelectedValue, dtpFromTime.Value.TimeOfDay, dtpToTime.Value.TimeOfDay, dgvTimeTable.CurrentRow.Cells[0].Value, cmbDay.Text.Trim());
                dt = null;
                dt = new DataTable();
                dt = DatabaseAccess.SelectData(checkquery);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        ep.SetError(cmbSubject, "Selecteed Time Period is Already Allocated to Another Subject! Please contact to administrator.");
                        cmbSubject.Focus();
                        return;
                    }
                }

            }

            string updatequery = string.Format("update SubjectsTimeTable set Program_ID = '{0}', Semester_ID = '{1}', Session_ID = '{2}', Subject_ID = '{3}', FromTime = convert(varchar(5), '{4}', 108), ToTime = convert(varchar(5), '{5}', 108),[Day] ='{6}',[Year] = '{7}',[Description]='{8}', IsActive='{9}'" +
                "where SubjectTimeTableID = '{10}'", cmbProgramme.SelectedValue, cmbSemester.SelectedValue, cmbSession.SelectedValue, cmbSubject.SelectedValue, dtpFromTime.Value.TimeOfDay,
                dtpToTime.Value.TimeOfDay, cmbDay.Text, dtpYear.Value.Year, txtDescription.Text.Trim(), isactive,
                Convert.ToString(dgvTimeTable.CurrentRow.Cells[0].Value).Trim());

            bool result = DatabaseAccess.UpdateData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Updated Successfully!");
                EnableComponents();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected error is occured! Please contact to administrator!");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvTimeTable.DataSource != null)
            {
                if (dgvTimeTable.Rows.Count > 0)
                {
                    if (dgvTimeTable.SelectedRows.Count == 1)
                    {
                        cmbSession.SelectedValue = Convert.ToInt32(dgvTimeTable.CurrentRow.Cells[1].Value);
                        cmbProgramme.SelectedValue = Convert.ToInt32(dgvTimeTable.CurrentRow.Cells[3].Value);
                        cmbSemesterType.SelectedValue = Convert.ToInt32(dgvTimeTable.CurrentRow.Cells[16].Value);
                        cmbSemester.SelectedValue = Convert.ToInt32(dgvTimeTable.CurrentRow.Cells[5].Value);
                        cmbSubject.SelectedValue = Convert.ToInt32(dgvTimeTable.CurrentRow.Cells[7].Value);
                        var fromtime = Convert.ToString(DateTime.Now.ToString("M/dd/yyyy") +" "+ dgvTimeTable.CurrentRow.Cells[9].Value);
                        dtpFromTime.Value = Convert.ToDateTime(fromtime);
                        var totime = Convert.ToString(DateTime.Now.ToString("M/dd/yyyy") + " " + dgvTimeTable.CurrentRow.Cells[10].Value);
                        dtpToTime.Value = Convert.ToDateTime(totime);
                        cmbDay.Text = Convert.ToString(dgvTimeTable.CurrentRow.Cells[11].Value);
                        var year = Convert.ToString(DateTime.Now.ToString("M/dd/") + dgvTimeTable.CurrentRow.Cells[12].Value);
                        dtpYear.Value = Convert.ToDateTime(year);
                        txtDescription.Text = Convert.ToString(dgvTimeTable.CurrentRow.Cells[14].Value);
                        chkIsActive.Checked = Convert.ToBoolean(dgvTimeTable.CurrentRow.Cells[15].Value);

                        DesibleComponents();
                }
                else
                {
                    MessageBox.Show("Please Select One Record!");
                }

            }
                else
                {
                    MessageBox.Show("List is Emppty!");
                }

            }
            else
            {
                MessageBox.Show("List is Emppty!");
            }
        }
    }
}
