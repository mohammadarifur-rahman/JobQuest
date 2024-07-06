using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace miniProject
{


    public partial class Detail : Form
    {
        private LList data; // Declare LList instance

        // get the id
        private int id;
        private string status;

        // JObs form
        private Jobs jobs;

        //public Dashboard DashboardForm { get; set; }

        // constructor
        public Detail()
        {
            InitializeComponent();
        }

        public Detail(string[] details)
        {
            InitializeComponent();
            id = int.Parse(details[0]);
            txtName.Text = details[1].Trim();
            txtRole.Text = details[2].Trim();
            txtDescription.Text = details[3].Trim();
            dtLastDate.Value = DateTime.Parse(details[4]);
            
            switch(details[5])
            {
                case "In Progress":
                    rbInProgress.Checked = true;
                    break;

                case "Completed":
                    rbCompleted.Checked = true; 
                    break;

                case "Advanced":
                    rbAdvanced.Checked = true;
                    break;

                case "Rejected":
                    rbRejected.Checked = true;
                    break;
                default:
                    break;
            }
        }



        private void Detail_Load(object sender, EventArgs e)
        {
            // assign data
            data = Data.GetData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            string name = txtName.Text;
            string role = txtRole.Text;
            string description = txtDescription.Text;
            DateTime lastdate = dtLastDate.Value;

            if (rbInProgress.Checked)
            {
                status = "In Progress";
            }
            else if (rbCompleted.Checked) 
            {
                status = "Completed";
            }
            else if(rbAdvanced.Checked)
            {
                status = "Advanced";
            }
            else if (rbRejected.Checked)
            {
                status = "Rejected";
            }

            /*// updating in the linked list
            data.Update(id, name, role, description, lastdate, status);
            //saving the updated data in csv
            data.SaveToCsv(Data.filePath);*/

            // using Data Manager
            Data.UpdateData(id, name, role, description, lastdate, status);
            Data.SaveData();

            // refresh the Jobs form lists
            //jobs.RefreshJobs();

            //displaying message
            MessageBox.Show("Application updated");

            // closing this window
            this.Close();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to DELETE the record?", "Warning", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                /*data.RemoveById(id);
                data.SaveToCsv(Data.filePath);*/

                // Data Manger
                Data.RemoveData(id);
                Data.SaveData();


                this.Close();
            }
            
        }
    }
}
