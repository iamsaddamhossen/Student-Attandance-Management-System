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

namespace SAMS.Forms.StudentForms
{
    public partial class frmAddStudents : Form
    {
        public frmAddStudents()
        {
            InitializeComponent();
        }

        private void frmAddStudents_Load(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSession);
            combo_helpers.Programmes(cmbProgramme);
            FillGrid("");
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = string.Format("SELECT [StdID] as ID,[Program_ID], [ProgramName] as [Program],[Session_ID], [SessionName] as [Session],[FullName] as [Name],[FatherName] as [Father Name] "+
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


        private void FormClear()
        {

            txtDescription.Clear();
            cmbSession.SelectedIndex = 0;
            cmbProgramme.SelectedIndex = 0;
            txtFullName.Clear();
            txtFatherName.Clear();
            txtCNIC.Clear();
            txtFatherNIC.Clear();
            dtpDOB.Value = DateTime.Now;
            txtReligion.Clear();
            txtNationality.Clear();
            txtEnrollNo.Clear();
            txtRegNo.Clear();
            dtpRegDate.Value = DateTime.Now;
            txtAddress.Clear();
            txtDescription.Clear();
            txtClassNo.Clear();
            txtMachineFingerNo.Clear();
            pb_Photo.Image = null;
            FillGrid("");
        }

        private void DesibleComponents()
        {
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            dgvStudentsList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void EnableComponents()
        {
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            dgvStudentsList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            //ResetForm();
            FormClear();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            ofd_StudentPic.Title = "Select Student Passport Size photo";
            ofd_StudentPic.Filter = "Image File (*.bmp;*.jpg;*.jpeg;*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if(ofd_StudentPic.ShowDialog() == DialogResult.OK)
            {
                pb_Photo.ImageLocation = ofd_StudentPic.FileName;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pb_Photo.Image = null;
        }

        private void btnProgrammeRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Sessions(cmbSession);
        }

        private void btnSessionRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.Programmes(cmbProgramme);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableComponents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if(cmbSession.SelectedIndex == 0)
            {
                ep.SetError(cmbSession, "Please Select Session");
                cmbSession.Focus();
                return;
            }
            if(cmbProgramme.SelectedIndex == 0)
            {
                ep.SetError(cmbProgramme, "Please Select Program");
                cmbProgramme.Focus();
                return;
            }

            if(txtFullName.Text.Trim().Length == 0)
            {
                ep.SetError(txtFullName, "Please Enter Student Full Name");
                txtFullName.Focus();
                return;
            }

            if (txtFatherName.Text.Trim().Length == 0)
            {
                ep.SetError(txtFatherName, "Please Enter Father Name");
                txtFatherName.Focus();
                return;
            }
            if (txtCNIC.Text.Trim().Length == 0)
            {
                ep.SetError(txtCNIC, "Please Enter Student NIC!");
                txtCNIC.Focus();
                return;
            }
            if (txtFatherNIC.Text.Trim().Length == 0)
            {
                ep.SetError(txtFatherNIC, "Please Enter Father NIC!");
                txtFatherNIC.Focus();
                return;
            }


            int noofyears = DateTime.Now.Year - dtpDOB.Value.Year;
            if(noofyears < 18)
            {
                ep.SetError(dtpDOB, "Please Select Correct Date of Birth!");
                dtpDOB.Focus();
                return;
            }

            if (txtReligion.Text.Trim().Length == 0)
            {
                ep.SetError(txtReligion, "Please Enter Reigion!");
                txtReligion.Focus();
                return;
            }

            if (txtNationality.Text.Trim().Length == 0)
            {
                ep.SetError(txtNationality, "Please Enter Nationality!");
                txtNationality.Focus();
                return;
            }

            if (txtClassNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtClassNo, "Please Click Refresh Button!");
                txtClassNo.Focus();
                return;
            }

            if (txtAddress.Text.Trim().Length == 0)
            {
                ep.SetError(txtAddress, "Please Enter Student Address!");
                txtAddress.Focus();
                return;
            }

            string image64bitstring = string.Empty;
            if(pb_Photo.Image != null)
            {
                image64bitstring = DatabaseAccess.ImageToBase64(pb_Photo.Image, System.Drawing.Imaging.ImageFormat.Png);
            }

            string checkquery = string.Format("select * from StudentsTable where Program_ID = '{0}' and CNIC='{1}'", cmbProgramme.SelectedValue, txtCNIC.Text.Trim());
            DataTable dt = DatabaseAccess.SelectData(checkquery);
            if(dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCNIC, "Already Student CNIC is registered!");
                    txtCNIC.Focus();
                    return;
                }
            }

            string insertquery = string.Format(" insert into StudentsTable ([Program_ID], [Session_ID],[FullName],[FatherName],[EnrollNo],[Reg_No],[ClassNo],[Entry_Date],[NIC],[CNIC],[Address],[Photo],[Dob],[Religion],[Nationality],[Description],[MachineFingerNo]) " +
                " values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')",
                cmbProgramme.SelectedValue,cmbSession.SelectedValue,txtFullName.Text.Trim(), txtFatherName.Text.Trim(), txtEnrollNo.Text.Trim(), 
                txtRegNo.Text.Trim(), txtClassNo.Text.Trim(), dtpRegDate.Value.ToString("yyyy/MM/dd"),txtCNIC.Text.Trim(), txtFatherNIC.Text.Trim(), txtAddress.Text.Trim(), image64bitstring,
                dtpDOB.Value.ToString("yyyy/MM/dd"), txtReligion.Text.Trim(), txtNationality.Text.Trim(), txtDescription.Text.Trim(),
                txtMachineFingerNo.Text.Trim());

            bool Result = DatabaseAccess.InsertData(insertquery);

            string stdinsertid = DatabaseAccess.SelectData("select Max(StdID) from StudentsTable").Rows[0][0].ToString(); 

            string semesterid = string.Format("select Semester_ID, SemesterName from SubjectsTimeTable INNER JOIN SemesterTable on Semester_ID = SemesterID " 
                + "where Program_ID = " + cmbProgramme.SelectedValue + " and Session_ID = " + cmbSession.SelectedValue + " group by Semester_ID,SemesterName");

            dt.Clear();
            dt = DatabaseAccess.SelectData(semesterid);
            foreach (DataRow semesterrow in dt.Rows) 
            {
                if(semesterrow[1].ToString().Contains("1st") || semesterrow[1].ToString().Contains("First"))
                {
                    semesterid = string.Empty;
                    semesterid = semesterrow[0].ToString();
                    break;

                }
            }

            string semesterinsert = string.Format("insert into StudentSemesterRecordTable(Semester_ID, Std_ID, IsActive) values ('{0}','{1}','1')", semesterid, stdinsertid);
            DatabaseAccess.InsertData(semesterinsert);


            if(Result)
            {
                MessageBox.Show("Student Registration Successfully...");
                FormClear();
            } else
            {
                MessageBox.Show("Failed!", "Please contact to administrator!");
            }

        }

        private void btnClassNo_Click(object sender, EventArgs e)
        {
            GetClassNo();
        }

        private void GetClassNo()
        {
            string query = string.Format("select Max(ClassNo) from StudentsTable where Program_ID = '{0}' and Session_ID = '{1}'", cmbProgramme.SelectedValue, cmbSession.SelectedValue);
            txtClassNo.Text = DatabaseAccess.SelectData(query).Rows[0][0] != DBNull.Value ? DatabaseAccess.SelectData(query).Rows[0][0].ToString() : "";
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetClassNo();
        }

        private void cmbProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetClassNo();
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
                ep.SetError(cmbSession, "Please Select Session");
                cmbSession.Focus();
                return;
            }
            if (cmbProgramme.SelectedIndex == 0)
            {
                ep.SetError(cmbProgramme, "Please Select Program");
                cmbProgramme.Focus();
                return;
            }

            if (txtFullName.Text.Trim().Length == 0)
            {
                ep.SetError(txtFullName, "Please Enter Student Full Name");
                txtFullName.Focus();
                return;
            }

            if (txtFatherName.Text.Trim().Length == 0)
            {
                ep.SetError(txtFatherName, "Please Enter Father Name");
                txtFatherName.Focus();
                return;
            }
            if (txtCNIC.Text.Trim().Length == 0)
            {
                ep.SetError(txtCNIC, "Please Enter Student NIC!");
                txtCNIC.Focus();
                return;
            }
            if (txtFatherNIC.Text.Trim().Length == 0)
            {
                ep.SetError(txtFatherNIC, "Please Enter Father NIC!");
                txtFatherNIC.Focus();
                return;
            }


            int noofyears = DateTime.Now.Year - dtpDOB.Value.Year;
            if (noofyears < 18)
            {
                ep.SetError(dtpDOB, "Please Select Correct Date of Birth!");
                dtpDOB.Focus();
                return;
            }

            if (txtReligion.Text.Trim().Length == 0)
            {
                ep.SetError(txtReligion, "Please Enter Reigion!");
                txtReligion.Focus();
                return;
            }

            if (txtNationality.Text.Trim().Length == 0)
            {
                ep.SetError(txtNationality, "Please Enter Nationality!");
                txtNationality.Focus();
                return;
            }

            if (txtClassNo.Text.Trim().Length == 0)
            {
                ep.SetError(txtClassNo, "Please Click Refresh Button!");
                txtClassNo.Focus();
                return;
            }

            if (txtAddress.Text.Trim().Length == 0)
            {
                ep.SetError(txtAddress, "Please Enter Student Address!");
                txtAddress.Focus();
                return;
            }

            string image64bitstring = string.Empty;
            if (pb_Photo.Image != null)
            {
                image64bitstring = DatabaseAccess.ImageToBase64(pb_Photo.Image, System.Drawing.Imaging.ImageFormat.Png);
            }

            string checkquery = string.Format("select * from StudentsTable where Program_ID = '{0}' and CNIC='{1}' and StdID !='{2}'", cmbProgramme.SelectedValue, txtCNIC.Text.Trim(), dgvStudentsList.CurrentRow.Cells[0].Value);
            DataTable dt = DatabaseAccess.SelectData(checkquery);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCNIC, "Already Student NID is registered! Please Enter Correct NID");
                    txtCNIC.Focus();
                    return;
                }
            }

            string updatequery = string.Format("update StudentsTable set [Program_ID] ='{0}', [Session_ID] = '{1}',[FullName]='{2}',[FatherName]='{3}',[EnrollNo] = '{4}',[Reg_No]='{5}',[ClassNo]='{6}',[Entry_Date]='{7}',[NIC]='{8}',[CNIC]='{9}',[Address]='{10}',[Photo]='{11}',[Dob]='{12}',[Religion]='{13}',[Nationality]='{14}',[Description]='{15}',[MachineFingerNo]='{16}'" +
                "where StdID = '{17}'", cmbProgramme.SelectedValue, cmbSession.SelectedValue, txtFullName.Text.Trim(), txtFatherName.Text.Trim(), txtEnrollNo.Text.Trim(), txtRegNo.Text.Trim(), txtClassNo.Text.Trim(), dtpRegDate.Value.ToString("yyyy/MM/dd"), txtCNIC.Text.Trim(), txtFatherNIC.Text.Trim(), txtAddress.Text.Trim(), image64bitstring,
                dtpDOB.Value.ToString("yyyy/MM/dd"), txtReligion.Text.Trim(), txtNationality.Text.Trim(), txtDescription.Text.Trim(),
                txtMachineFingerNo.Text.Trim(), dgvStudentsList.CurrentRow.Cells[0].Value);

            bool Result = DatabaseAccess.UpdateData(updatequery);
            if (Result)
            {
                MessageBox.Show("Student Profile Updated Successfully...");
                EnableComponents();
            }
            else
            {
                MessageBox.Show("Failed!", "Please contact to administrator!");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvStudentsList.DataSource != null)
            {
                if (dgvStudentsList.Rows.Count > 0)
                {
                    if (dgvStudentsList.SelectedRows.Count == 1)
                    {

                        if (dgvStudentsList.CurrentRow.Cells[19].Value != DBNull.Value)
                        {
                            cmbProgramme.SelectedValue = dgvStudentsList.CurrentRow.Cells[1].Value;
                            cmbSession.SelectedValue = dgvStudentsList.CurrentRow.Cells[3].Value;
                            txtFullName.Text = dgvStudentsList.CurrentRow.Cells[5].Value.ToString();
                            txtFatherName.Text = dgvStudentsList.CurrentRow.Cells[6].Value.ToString();
                            txtEnrollNo.Text = dgvStudentsList.CurrentRow.Cells[7].Value.ToString();
                            txtRegNo.Text = dgvStudentsList.CurrentRow.Cells[8].Value.ToString();
                            txtClassNo.Text = dgvStudentsList.CurrentRow.Cells[9].Value.ToString();
                            dtpRegDate.Value = Convert.ToDateTime(dgvStudentsList.CurrentRow.Cells[10].Value);
                            txtCNIC.Text = dgvStudentsList.CurrentRow.Cells[11].Value.ToString();
                            txtFatherNIC.Text = dgvStudentsList.CurrentRow.Cells[12].Value.ToString();
                            txtAddress.Text = dgvStudentsList.CurrentRow.Cells[13].Value.ToString();
                            dtpDOB.Value = Convert.ToDateTime(dgvStudentsList.CurrentRow.Cells[14].Value);
                            txtReligion.Text = dgvStudentsList.CurrentRow.Cells[15].Value.ToString();
                            txtNationality.Text = dgvStudentsList.CurrentRow.Cells[16].Value.ToString();
                            txtDescription.Text = dgvStudentsList.CurrentRow.Cells[17].Value.ToString();
                            txtMachineFingerNo.Text = dgvStudentsList.CurrentRow.Cells[18].Value.ToString();
                            pb_Photo.Image = DatabaseAccess.Base64ToImage(dgvStudentsList.CurrentRow.Cells[19].Value.ToString());
                        }
                        else
                        {
                            pb_Photo.Image = null;
                        }
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
