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
    public partial class frmSemesterType : Form
    {
        public frmSemesterType()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = string.Format("select SemesterTypeID as [ID], SemetserType as [Semester Type], Description as [Description] from SemesterTypeTable");
            }
            else
            {
                query = string.Format("select SemesterTypeID as [ID], SemetserType as [Semester Type], Description as [Description] from SemesterTypeTable where (SemetserType + ' '+ Description) like '%" + searchvalue + "%'");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                dgvSemesterTypeList.DataSource = dt;
                dgvSemesterTypeList.Columns[0].Width = 100;
                dgvSemesterTypeList.Columns[1].Width = 200;
                dgvSemesterTypeList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dgvSemesterTypeList.DataSource = null;
            }
        }

        private void FormClear()
        {
            txtSemesterType.Clear();
            txtDescription.Clear();
        }

        private void DesibleComponents()
        {
            btnSave.Enabled = false;
            dgvSemesterTypeList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void EnableComponents()
        {
            btnSave.Enabled = true;
            dgvSemesterTypeList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            FormClear();
        }

        private void frmSemesterType_Load(object sender, EventArgs e)
        {
            FillGrid("");
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
            DesibleComponents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtSemesterType.Text.Trim().Length == 0)
            {
                ep.SetError(txtSemesterType, "Please Enter Semester Type Name!");
                txtSemesterType.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from SemesterTypeTable where SemetserType='" + txtSemesterType.Text.Trim() + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSemesterType, "Already Exist!");
                    txtSemesterType.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into SemesterTypeTable(SemetserType, Description) values('{0}','{1}')",
                txtSemesterType.Text.Trim(), txtDescription.Text.Trim());
            bool result = DatabaseAccess.InsertData(insertquery);
            if (result == true)
            {
                MessageBox.Show("Semester Type Added Successfully!");
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
            if (dgvSemesterTypeList.DataSource != null)
            {
                if (dgvSemesterTypeList.Rows.Count > 0)
                {
                    //if(dgvSessionList.Rows.Count == 1)
                    //{
                    txtSemesterType.Text = Convert.ToString(dgvSemesterTypeList.CurrentRow.Cells[1].Value);
                    txtDescription.Text = Convert.ToString(dgvSemesterTypeList.CurrentRow.Cells[2].Value);
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
            if (txtSemesterType.Text.Trim().Length == 0)
            {
                ep.SetError(txtSemesterType, "Please Enter Semester Type Name!");
                txtSemesterType.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from SemesterTypeTable where SemetserType='" + txtSemesterType.Text.Trim() + "' and SemesterTypeID !='" + Convert.ToString(dgvSemesterTypeList.CurrentRow.Cells[0].Value) + "' ");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtSemesterType, "Already Exist!");
                    txtSemesterType.Focus();
                    return;
                }
            }

            string updatequery = string.Format("update SemesterTypeTable set SemetserType ='{0}', Description='{1}' where SemesterTypeID = '{2}'", txtSemesterType.Text.Trim(), dgvSemesterTypeList.CurrentRow.Cells[0].Value);
            bool result = DatabaseAccess.UpdateData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Semester Type Updated Successfully!");
                EnableComponents();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }
    }
}
