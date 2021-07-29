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

namespace SAMS.Forms.GeneralForms
{
    public partial class frmSemesters : Form
    {
        public frmSemesters()
        {
            InitializeComponent();
            combo_helpers.SemesterTypes(cmb_SemesterTypes);


        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                //query = string.Format("select SemesterID as [ID], SemesterTypeID, SemesterType as [Semester Type], SemesterName as [Semester] from v_SemesterList");
                query = string.Format("select * from v_SemesterList");
            }
            else
            {
                query = string.Format("select SemesterID as [ID], SemesterTypeID, SemesterType as [Semester Type], SemesterName as [Semester] from v_SemesterList where (SemesterType + ' '+ SemesterName) like '%" + searchvalue + "%'");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                dgvSemestersList.DataSource = dt;
                dgvSemestersList.Columns[0].Width = 100;
                dgvSemestersList.Columns[1].Width = 200;
                dgvSemestersList.Columns[2].Width = 200;
                dgvSemestersList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvSemestersList.Columns[1].Visible = false;
            }
            else
            {
                dgvSemestersList.DataSource = null;
            }
        }

        private void FormClear()
        {
            txtSemester.Clear();
            cmb_SemesterTypes.SelectedIndex = 0;
            //txtDescription.Clear();
        }

        private void DesibleComponents()
        {
            btnSave.Enabled = false;
            dgvSemestersList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void EnableComponents()
        {
            btnSave.Enabled = true;
            dgvSemestersList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            FormClear();
        }

        private void frmSemester_Load(object sender, EventArgs e)
        {
            combo_helpers.SemesterTypes(cmb_SemesterTypes);
            FillGrid("");
        }

        private void cmb_SemesterTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
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
            if (cmb_SemesterTypes.SelectedIndex == 0)
            {
                ep.SetError(cmb_SemesterTypes, "Please Select Semester Type!");
                cmb_SemesterTypes.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from SemesterTable where SemesterName='" + txtSemester.Text.Trim() + "' and SemesterType_ID='"+ cmb_SemesterTypes.SelectedValue + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSemester, "Already Exist!");
                    txtSemester.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into SemesterTable(SemesterType_ID, SemesterName) values('{0}','{1}')",
                cmb_SemesterTypes.SelectedValue, txtSemester.Text.Trim());
            bool result = DatabaseAccess.InsertData(insertquery);
            if (result == true)
            {
                MessageBox.Show("Semester Added Successfully!");
                FormClear();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvSemestersList.DataSource != null)
            {
                if (dgvSemestersList.Rows.Count > 0)
                {
                    //if(dgvSessionList.Rows.Count == 1)
                    //{
                    cmb_SemesterTypes.Text = Convert.ToString(dgvSemestersList.CurrentRow.Cells[2].Value);
                    txtSemester.Text = Convert.ToString(dgvSemestersList.CurrentRow.Cells[3].Value);
                    DesibleComponents();
                    //} else {
                    //    MessageBox.Show("Please Select One Record!");
                    //} 

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmb_SemesterTypes.SelectedIndex == 0)
            {
                ep.SetError(cmb_SemesterTypes, "Please Select Semester Type!");
                cmb_SemesterTypes.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from SemesterTable where SemesterName='" + txtSemester.Text.Trim() + "' and SemesterType_ID='" + cmb_SemesterTypes.SelectedValue + "' and SemesterID != '"+dgvSemestersList.CurrentRow.Cells[0].Value+"'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSemester, "Already Exist!");
                    txtSemester.Focus();
                    return;
                }
            }

            string updatequery = string.Format("update SemesterTable set SemesterType_ID = '{0}', SemesterName = '{1}' where SemesterID = '{2}'",
                cmb_SemesterTypes.SelectedValue, txtSemester.Text.Trim(), dgvSemestersList.CurrentRow.Cells[0].Value);
            bool result = DatabaseAccess.UpdateData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Semester Updated Successfully!");
                EnableComponents();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }

        private void btnSSSessionRefresh_Click(object sender, EventArgs e)
        {
            combo_helpers.SemesterTypes(cmb_SemesterTypes);
        }
    }
}
