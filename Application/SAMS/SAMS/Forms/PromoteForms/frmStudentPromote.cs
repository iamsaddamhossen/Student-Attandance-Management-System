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

namespace SAMS.Forms.PromoteForms
{
    public partial class frmStudentPromote : Form
    {
        public frmStudentPromote()
        {
            InitializeComponent();
        }

        private void GetPromotedNotPromotedStudent()
        {
            if(cmbSSSession.SelectedIndex < 1 && cmbSSPrograme.SelectedIndex < 1)
            {
                return;
            }

            string query = string.Empty;
            if(rdbOldPromoted.Checked == true)
            {
                query = string.Format("select * from v_GetPromotedOrNotPromotedStudent where Semester_ID IS NOT NULL AND Session_ID = '{0}' AND PROGRAM_ID='{1}'  AND IsActive=1",
               Convert.ToString(cmbSSSession.SelectedValue), Convert.ToString(cmbSSPrograme.SelectedValue));
            } else if(rdbNotPromoted.Checked == true)
            {
                query = string.Format("select * from v_GetPromotedOrNotPromotedStudent where Semester_ID IS NULL AND Session_ID = '{0}' AND PROGRAM_ID='{1}'",
               Convert.ToString(cmbSSSession.SelectedValue), Convert.ToString(cmbSSPrograme.SelectedValue), Convert.ToString(cmbSSCurrentSemester.SelectedValue));
            }

            DataTable dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                dgvStudentsList.DataSource = dt;
                dgvStudentsList.Columns[1].Visible = false;
                dgvStudentsList.Columns[3].Visible = false;
                dgvStudentsList.Columns[0].Visible = false;
                dgvStudentsList.Columns[2].Width = 100;
                dgvStudentsList.Columns[4].Width = 120;
                dgvStudentsList.Columns[5].Width = 120;
                dgvStudentsList.Columns[6].Width = 120;
                dgvStudentsList.Columns[8].Width = 200;
                dgvStudentsList.Columns[9].Width = 120;
                dgvStudentsList.Columns[10].Width = 120;
                dgvStudentsList.Columns[11].Width = 120;
                dgvStudentsList.Columns[12].Width = 120;
                dgvStudentsList.Columns[13].Width = 120;
                dgvStudentsList.Columns[14].Width = 120;
                dgvStudentsList.Columns[15].Width = 100;
                dgvStudentsList.Columns[16].Width = 300;
                dgvStudentsList.Columns[17].Width = 300;
                dgvStudentsList.Columns[18].Visible = false;
                dgvStudentsList.Columns[19].Visible = false;
                dgvStudentsList.Columns[20].Visible = false;
                dgvStudentsList.Columns[21].Visible = false;
                dgvStudentsList.Columns[22].Width = 70;

                dgvStudentsList.Columns[21].Width = 50;
                dgvStudentsList.Columns[22].Width = 50;

                if (rdbNotPromoted.Checked == true)
                {
                    dgvStudentsList.Columns[5].Visible = false;
                    dgvStudentsList.Columns[22].Visible = false;
                }

                if (rdbOldPromoted.Checked == true)
                {
                    dgvStudentsList.Columns[5].Visible = true;
                    dgvStudentsList.Columns[22].Visible = true;
                }
            }
            else
            {
                dgvStudentsList.DataSource = null;
            }

        }

        private void frmStudentPromote_Load(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSSSession);
            combo_helpers.Programmes(cmbSSPrograme);


        }

        private void btnSSSessionRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSSSession);
        }

        private void btnSSProgrameRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Programmes(cmbSSPrograme);
        }

        //private void btnPSSessionRefresh_Click(object sender, EventArgs e)
        //{
        //    combo_helpers.Sessions(cmbPSSession);
        //}

        //private void btnPSProgrammeRefresh_Click(object sender, EventArgs e)
        //{
        //    combo_helpers.Programmes(cmbPSProgramme);
        //}

        private void cmbSSSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbSSSession.SelectedIndex > 0 && cmbSSPrograme.SelectedIndex > 0)
            //{
                combo_helpers.GetSemestersByProgrameAndSession(cmbSSCurrentSemester, Convert.ToString(cmbSSPrograme.SelectedValue), Convert.ToString(cmbSSSession.SelectedValue));
                combo_helpers.GetSemestersByProgrameAndSession(cmbPSPromoteSemester, Convert.ToString(cmbSSPrograme.SelectedValue), Convert.ToString(cmbSSSession.SelectedValue));
            //}
            //else
            //{

            //}
        }

        private void cmbSSPrograme_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbSSSession.SelectedIndex > 0 && cmbSSPrograme.SelectedIndex > 0)
            //{
                combo_helpers.GetSemestersByProgrameAndSession(cmbSSCurrentSemester, Convert.ToString(cmbSSPrograme.SelectedValue), Convert.ToString(cmbSSSession.SelectedValue));
                combo_helpers.GetSemestersByProgrameAndSession(cmbPSPromoteSemester, Convert.ToString(cmbSSPrograme.SelectedValue), Convert.ToString(cmbSSSession.SelectedValue));
            //}
            //else
            //{

            //}
        }

        private void btnStdRetrieve_Click(object sender, EventArgs e)
        {
            GetPromotedNotPromotedStudent();
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if(dgvStudentsList != null)
            {
                if(dgvStudentsList.Rows.Count > 0)
                {
                    if (chkSelectAll.Checked == true)
                    {
                        dgvStudentsList.SelectAll();
                    }
                    else
                    {
                        dgvStudentsList.ClearSelection();
                    }
                }
            }
            
        }

        private void cmbSSCurrentSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPSPromoteSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbPSPromoteSemester.SelectedIndex = 0;
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(cmbSSSession.SelectedIndex == 0)
            {
                ep.SetError(cmbSSSession, "Please Select Session!");
                cmbSSSession.Focus();
                return;
            }
            if (cmbSSPrograme.SelectedIndex == 0)
            {
                ep.SetError(cmbSSPrograme, "Please Select Programe!");
                cmbSSPrograme.Focus();
                return;
            }

            if(cmbPSPromoteSemester.SelectedIndex == 0)
            {
                ep.SetError(cmbPSPromoteSemester, "Please Select Promote Semeeter!");
                cmbPSPromoteSemester.Focus();
                return;
            }

            if(rdbOldPromoted.Checked == true)
            {
                if (cmbSSCurrentSemester.SelectedIndex == 0)
                {
                    ep.SetError(cmbSSCurrentSemester, "Please Select Current Semester");
                    cmbSSCurrentSemester.Focus();
                    return;
                }

                if(cmbSSCurrentSemester.SelectedIndex >= cmbPSPromoteSemester.SelectedIndex)
                {
                    ep.SetError(cmbPSPromoteSemester, "Promote Semester Must be Greater than Current Semester!");
                    cmbPSPromoteSemester.Focus();
                    return;
                }
            }

            if(rdbNotPromoted.Checked == true)
            {
                if(cmbPSPromoteSemester.SelectedIndex == 0)
                {
                    ep.SetError(cmbPSPromoteSemester, "Please Select Promote Semester!");
                    cmbPSPromoteSemester.Focus();
                    //return;
                }

                cmbSSCurrentSemester.SelectedIndex = 0;
                
            }

            if(dgvStudentsList != null)
            {
                if (dgvStudentsList.Rows.Count > 0)
                {
                    if (dgvStudentsList.SelectedRows.Count > 0)
                    {
                        if (MessageBox.Show("Are you sure to promote selected student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (DataGridViewRow record  in dgvStudentsList.SelectedRows)
                            {
                            string updatecurrentsemester = string.Format("update StudentSemesterRecordTable set IsActive = 0 where Std_ID  = '{0}'", record.Cells[0].Value);
                            DatabaseAccess.InsertData(updatecurrentsemester);
                            string semesterinsert = string.Format("insert into StudentSemesterRecordTable(Semester_ID, Std_ID, IsActive) values ('{0}','{1}','1')", cmbPSPromoteSemester.SelectedValue, record.Cells[0].Value);
                            DatabaseAccess.InsertData(semesterinsert);
                            }

                            MessageBox.Show("Select Students are promoted to "+cmbPSPromoteSemester.Text+"");
                            GetPromotedNotPromotedStudent();
                        }
                    } else
                    {
                        if(rdbNotPromoted.Checked == true)
                        {
                            MessageBox.Show("Please Select Not Promoted Student Records!");
                        }
                        else
                        {
                            MessageBox.Show("Please Select Promoted Student Records!");
                        }
                        
                    }
                } else
                {
                    MessageBox.Show("List Empty!");
                }
            } else
            {
                MessageBox.Show("No Record Found!");
            }
            

        }
    }
}
