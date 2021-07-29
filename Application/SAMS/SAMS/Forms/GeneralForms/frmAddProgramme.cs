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
    public partial class frmAddProgramme : Form
    {
        public frmAddProgramme()
        {
            InitializeComponent();
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if (searchvalue.Trim().Length == 0)
            {
                query = string.Format("select ProgramId as [ID], ProgramName as [Program], RegDate as [Reg Date], Description as [Description] from ProgramTable");
            }
            else
            {
                query = string.Format("select ProgramId as [ID], ProgramName as [Program], RegDate as [Reg Date], Description as [Description] from ProgramTable where (ProgramName + ' '+ Description) like '%" + searchvalue + "%'");
            }

            dt = DatabaseAccess.SelectData(query);
            if (dt.Rows.Count > 0)
            {
                dgvProgrammeList.DataSource = dt;
                dgvProgrammeList.Columns[0].Width = 100;
                dgvProgrammeList.Columns[1].Width = 300;
                dgvProgrammeList.Columns[2].Width = 100;
                dgvProgrammeList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dgvProgrammeList.DataSource = null;
            }
        }

        private void FormClear()
        {
            txtProgrammeName.Clear();
            txtDescription.Clear();
            dtpRegDate.Value = DateTime.Now;
        }

        private void DesibleComponents()
        {
            btnSave.Enabled = false;
            dgvProgrammeList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void EnableComponents()
        {
            btnSave.Enabled = true;
            dgvProgrammeList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            FormClear();
        }

        private void frmAddProgramme_Load(object sender, EventArgs e)
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
            EnableComponents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtProgrammeName.Text.Trim().Length == 0)
            {
                ep.SetError(txtProgrammeName, "Please Enter Programme Name!");
                txtProgrammeName.Focus();
                return;
            }

            //DataTable dt = DatabaseAccess.SelectData("select * from ProgramTable where ProgramName='" + txtProgrammeName.Text.Trim() + "' and ProgramId !='" + Convert.ToString(dgvProgrammeList.CurrentRow.Cells[0].Value) + "'");
            //if (dt != null)
            //{
            //    if (dt.Rows.Count > 0)
            //    {
            //        ep.SetError(txtProgrammeName, "Already Exist!");
            //        txtProgrammeName.Focus();
            //        return;
            //    }
            //}

            string insertquery = string.Format("insert into ProgramTable(ProgramName, RegDate, Description) values('{0}','{1}','{2}')",
                txtProgrammeName.Text.Trim(), dtpRegDate.Value.ToString("yyyy/MM/dd"), txtDescription.Text.Trim());
            bool result = DatabaseAccess.InsertData(insertquery);
            if (result == true)
            {
                MessageBox.Show("Programme Added Successfully!");
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
            if (dgvProgrammeList.DataSource != null)
            {
                if (dgvProgrammeList.Rows.Count > 0)
                {
                    //if(dgvSessionList.Rows.Count == 1)
                    //{
                    txtProgrammeName.Text = Convert.ToString(dgvProgrammeList.CurrentRow.Cells[1].Value);
                    dtpRegDate.Value = Convert.ToDateTime(Convert.ToString(dgvProgrammeList.CurrentRow.Cells[2].Value));
                    txtDescription.Text = Convert.ToString(dgvProgrammeList.CurrentRow.Cells[3].Value);
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
            if (txtProgrammeName.Text.Trim().Length == 0)
            {
                ep.SetError(txtProgrammeName, "Please Enter Programme Name!");
                txtProgrammeName.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from ProgramTable where ProgramName='" + txtProgrammeName.Text.Trim() + "' and ProgramId !='" + Convert.ToString(dgvProgrammeList.CurrentRow.Cells[0].Value) + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtProgrammeName, "Already Exist!");
                    txtProgrammeName.Focus();
                    return;
                }
            }

            string updatequery = string.Format("update ProgramTable set ProgramName='{0}', RegDate='{1}', Description='{2}' where ProgramId='{3}'", txtProgrammeName.Text.Trim(), dtpRegDate.Value.ToString("yyyy/MM/dd"), txtDescription.Text.Trim(), dgvProgrammeList.CurrentRow.Cells[0].Value);
            bool result = DatabaseAccess.UpdateData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Programme Updated Successfully!");
                EnableComponents();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }

        //private frmAddProgramme_Activated(object sender, EventArgs e)
        //{
        //    FillGrid("");
        //}
    }
}
