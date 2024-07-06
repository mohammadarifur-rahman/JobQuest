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
    public partial class Dashboard : Form
    {
        public Jobs jobs;
        public Add add;
        public Home home;
        public Profile profile;
        // variables for button colors
        public Color activeBtn;
        public Color inactiveBtn;

        public Dashboard()
        {
            InitializeComponent();
            activeBtn = Color.White;
            inactiveBtn = Color.FromArgb(50, 75, 158);

            //initialize the Jobs page, Add New page
            jobs = new Jobs();
            add = new Add();

            // details form
            /*Detail detailForm = new Detail();
            detailForm.DashboardForm = this; // Pass reference to Dashboard form*/
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = activeBtn;
            btnJobs.BackColor = inactiveBtn;
            btnAdd.BackColor = inactiveBtn;
            btnProfile.BackColor = inactiveBtn;



            //hiding other pages
            jobs.Hide();
            add.Hide();

            if (profile != null)
            {
                profile.Close();
            }

            // Check if Jobs form is already open or not
            if (Application.OpenForms["Home"] == null)
            {
                //
                home = new Home();
                home.TopLevel = false;
                home.FormBorderStyle = FormBorderStyle.None;
                home.Dock = DockStyle.Fill;

                // Add Jobs to a container control in Dashboard form
                pnlContainer.Controls.Add(home);
                home.Show();
            }
            else
            {
                home.Show();
            }
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = inactiveBtn;
            btnJobs.BackColor = activeBtn;
            btnAdd.BackColor = inactiveBtn;
            btnProfile.BackColor = inactiveBtn;

            
            jobs.RefreshJobs();
            // hiding add new page
            if (add != null)
            {
                add.Hide();
            }

            // closing home
            if (home != null)
            {
                home.Close();
            }

            if (profile != null)
            {
                profile.Close();
            }

            // Check if Jobs form is already open or not
            if (Application.OpenForms["Jobs"] == null)
            {
                //
                jobs.TopLevel = false;
                jobs.FormBorderStyle = FormBorderStyle.None;
                jobs.Dock = DockStyle.Fill;

                // Add Jobs to a container control in Dashboard form
                pnlContainer.Controls.Add(jobs);
                jobs.Show();
            }
            else
            {
                jobs.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = inactiveBtn;
            btnJobs.BackColor = inactiveBtn;
            btnAdd.BackColor = activeBtn;
            btnProfile.BackColor = inactiveBtn;

            // hiding Jobs page
            if (jobs != null)
            {
                jobs.Hide();
            }

            if (home != null)
            {
                home.Close();
            }

            if (profile != null)
            {
                profile.Close();
            }

            // Check if Jobs form is already open or not
            if (Application.OpenForms["Add"] == null)
            {
                //
                add.TopLevel = false;
                add.FormBorderStyle = FormBorderStyle.None;
                add.Dock = DockStyle.Fill;

                // Add Jobs to a container control in Dashboard form
                pnlContainer.Controls.Add(add);
                add.Show();
            }
            else
            {
                add.Show();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            btnHome.BackColor = inactiveBtn;
            btnJobs.BackColor = inactiveBtn;
            btnAdd.BackColor = inactiveBtn;
            btnProfile.BackColor = activeBtn;

            //hiding other pages
            jobs.Hide();
            add.Hide();

            if(home != null)
            { home.Close(); }   

            // Check if Jobs form is already open or not
            if (Application.OpenForms["Profile"] == null)
            {
                //
                profile = new Profile();
                profile.TopLevel = false;
                profile.FormBorderStyle = FormBorderStyle.None;
                profile.Dock = DockStyle.Fill;

                // Add Jobs to a container control in Dashboard form
                pnlContainer.Controls.Add(profile);
                profile.Show();
            }
            else
            {
                profile.Show();
            }
        }


        // loading the home page by default when click login
        private void Dashboard_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
