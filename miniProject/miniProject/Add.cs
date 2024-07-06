using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProject
{
    public partial class Add : Form
    {

        string Status = "";
        private LList data; // Declare LList instance
        public Add()
        {
            InitializeComponent();
            
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // Set the Text property for each RadioButton
            rbInProgress.Text = "In Progress";
            rbCompleted.Text = "Completed";
            rbAdvanced.Text = "Advanced";
            rbRejected.Text = "Rejected";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            //adding text to label for warning
            lblNameReq.Text = "";


            if (ValidateFields())
            {
                // adding data
                string name = txtName.Text;
                string role = txtRole.Text;
                string description = txtDescription.Text;
                DateTime lastdate = dtLastDate.Value;

                // assign data
                data = Data.GetData();

                // added id as 0 which will be replced by actual number
                /*data.AddLast(0, name, role, description, lastdate, Status);
                data.SaveToCsv(Data.filePath);*/

                // using Data Manager
                Data.AddNewData(name, role, description, lastdate, Status);
                Data.SaveData();

                // clear all the fields
                ClearFileds();
            }
            else
            {
                lblNameReq.Text = "*Please fill in all required fields.";
            }

        }

        private void ClearFileds()
        {
            // Clear all fields after adding new data
            txtName.Text = "";
            txtRole.Text = "";
            txtDescription.Text = "";
            dtLastDate.Value = DateTime.Now; 

            // Reset radio buttons
            rbInProgress.Checked = false;
            rbCompleted.Checked = false;
            rbAdvanced.Checked = false;
            rbRejected.Checked = false;
        }

        private void rbInProgress_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInProgress.Checked)
            {
                Status = "In Progress";
            }
        }

        private void rbCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCompleted.Checked)
            {
                Status = "Completed";
            }
        }

        private void rbAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdvanced.Checked)
            {
                Status = "Advanced";
            }
        }

        private void rbRejected_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRejected.Checked)
            {
                Status = "Rejected";
            }
        }

        private bool ValidateFields()
        {
            // Validate all fields
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("Please enter a role.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return false;
            }

            if (!(rbInProgress.Checked || rbCompleted.Checked || rbAdvanced.Checked || rbRejected.Checked))
            {
                MessageBox.Show("Please select a status.");
                return false;
            }

            return true;
        }

    }
}
