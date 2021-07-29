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
    public partial class frmAddSession : Form
    {
        public frmAddSession()
        {
            InitializeComponent();
        }

        private void frmAddSession_Load(object sender, EventArgs e)
        {
            FillGrid("");
        }

        private void FillGrid(string searchvalue)
        {
            DataTable dt = new DataTable();
            string query = string.Empty;
            if(searchvalue.Trim().Length == 0)
            {
                 query = string.Format("select SessionID as [ID], SessionName as [Session], StartDate as [Start Date], EndDate as [End Date], Description as [Description] from SessionTable");
            } else
            {
                query = string.Format("select SessionID as [ID], SessionName as [Session], StartDate as [Start Date], EndDate as [End Date], Description as [Description] from SessionTable where (SessionName + ' '+ Description) like '%"+searchvalue+"%'");
            }
            
            dt = DatabaseAccess.SelectData(query);
            if(dt.Rows.Count > 0)
            {
                dgvSessionList.DataSource = dt;
                dgvSessionList.Columns[0].Width = 100;
                dgvSessionList.Columns[1].Width = 200;
                dgvSessionList.Columns[2].Width = 100;
                dgvSessionList.Columns[3].Width = 100;
                dgvSessionList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            } else
            {
                dgvSessionList.DataSource = null;
            }
        }

        private void FormClear()
        {
            txtSessionName.Clear();
            txtDescription.Clear();
            dtpEndDate.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
        }

        private void DesibleComponents()
        {
            btnSave.Enabled = false;
            dgvSessionList.Enabled = false;
            txtSearch.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
     
        }

        private void EnableComponents() 
        {
            btnSave.Enabled = true;
            dgvSessionList.Enabled = true;
            txtSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
            FormClear();
        }

        private void btnSave_Click(object sender, EventArgs e)  
        {
            ep.Clear();
            if(txtSessionName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSessionName, "Please Enter Session Name!");
                txtSessionName.Focus();
                return;
            }

            DataTable dt = DatabaseAccess.SelectData("select * from SessionTable where SessionName !='" + txtSessionName.Text.Trim() + "';");
            //DataTable dt = DatabaseAccess.SelectData("select * from SessionTable where SessionName='" + txtSessionName.Text.Trim() + "' and SessionID !='"+Convert.ToString(dgvSessionList.CurrentRow.Cells[0].Value)+"' ");
            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    ep.SetError(txtSessionName, "Already Exist!");
                    txtSessionName.Focus();
                    return;
                }
            }

            string insertquery = string.Format("insert into SessionTable(SessionName, StartDate, EndDate, Description) values('{0}','{1}','{2}','{3}')", 
                txtSessionName.Text.Trim(), dtpStartDate.Value.ToString("yyyy/MM/dd"), dtpEndDate.Value.ToString("yyyy/MM/dd"), txtDescription.Text.Trim());
            bool result = DatabaseAccess.InsertData(insertquery);
            if(result == true)
            {
                MessageBox.Show("Session Added Successfully!");
                FormClear();
                FillGrid("");
            } else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvSessionList.DataSource != null)
            {
                if(dgvSessionList.Rows.Count > 0)
                {
                    //if(dgvSessionList.Rows.Count == 1)
                    //{
                        txtSessionName.Text = Convert.ToString(dgvSessionList.CurrentRow.Cells[1].Value);
                        dtpStartDate.Value = Convert.ToDateTime(Convert.ToString(dgvSessionList.CurrentRow.Cells[2].Value));
                        dtpEndDate.Value = Convert.ToDateTime(Convert.ToString(dgvSessionList.CurrentRow.Cells[3].Value));
                        txtDescription.Text = Convert.ToString(dgvSessionList.CurrentRow.Cells[4].Value);
                       DesibleComponents();
                    //} else {
                    //    MessageBox.Show("Please Select One Record!");
                    //} 

                } else {
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
            if (txtSessionName.Text.Trim().Length == 0)
            {
                ep.SetError(txtSessionName, "Please Enter Session Name!");
                txtSessionName.Focus();
                return;
            }

            string updatequery = string.Format("update SessionTable set SessionName='{0}', StartDate='{1}', EndDate='{2}', Description='{3}' where SessionID='{4}'", txtSessionName.Text.Trim(), dtpStartDate.Value.ToString("yyyy/MM/dd"), dtpEndDate.Value.ToString("yyyy/MM/dd"), txtDescription.Text.Trim(), dgvSessionList.CurrentRow.Cells[0].Value);
            bool result = DatabaseAccess.UpdateData(updatequery);
            if (result == true)
            {
                MessageBox.Show("Session Updated Successfully!");
                EnableComponents();
                FillGrid("");
            }
            else
            {
                MessageBox.Show("Unexpected error is occur! Please try again");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableComponents();
        }
    }
}
