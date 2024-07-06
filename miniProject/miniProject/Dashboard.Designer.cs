namespace miniProject
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlDashBoardTopLeft = new System.Windows.Forms.Panel();
            this.lblDashboardTopLeft = new System.Windows.Forms.Label();
            this.imgDashboardTopLeft = new System.Windows.Forms.PictureBox();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlLeftSide.SuspendLayout();
            this.pnlDashBoardTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboardTopLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlLeftSide.Controls.Add(this.linkExit);
            this.pnlLeftSide.Controls.Add(this.btnLogout);
            this.pnlLeftSide.Controls.Add(this.pnlDashBoardTopLeft);
            this.pnlLeftSide.Controls.Add(this.btnProfile);
            this.pnlLeftSide.Controls.Add(this.btnAdd);
            this.pnlLeftSide.Controls.Add(this.btnJobs);
            this.pnlLeftSide.Controls.Add(this.btnHome);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(150, 423);
            this.pnlLeftSide.TabIndex = 0;
            // 
            // linkExit
            // 
            this.linkExit.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkExit.AutoSize = true;
            this.linkExit.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.linkExit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkExit.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.linkExit.Location = new System.Drawing.Point(54, 397);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(31, 15);
            this.linkExit.TabIndex = 11;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(6, 342);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(138, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlDashBoardTopLeft
            // 
            this.pnlDashBoardTopLeft.Controls.Add(this.lblDashboardTopLeft);
            this.pnlDashBoardTopLeft.Controls.Add(this.imgDashboardTopLeft);
            this.pnlDashBoardTopLeft.Location = new System.Drawing.Point(2, 4);
            this.pnlDashBoardTopLeft.Name = "pnlDashBoardTopLeft";
            this.pnlDashBoardTopLeft.Size = new System.Drawing.Size(147, 109);
            this.pnlDashBoardTopLeft.TabIndex = 5;
            // 
            // lblDashboardTopLeft
            // 
            this.lblDashboardTopLeft.AutoSize = true;
            this.lblDashboardTopLeft.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDashboardTopLeft.Location = new System.Drawing.Point(32, 79);
            this.lblDashboardTopLeft.Name = "lblDashboardTopLeft";
            this.lblDashboardTopLeft.Size = new System.Drawing.Size(81, 17);
            this.lblDashboardTopLeft.TabIndex = 1;
            this.lblDashboardTopLeft.Text = "Hello, admin";
            // 
            // imgDashboardTopLeft
            // 
            this.imgDashboardTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("imgDashboardTopLeft.Image")));
            this.imgDashboardTopLeft.Location = new System.Drawing.Point(32, 8);
            this.imgDashboardTopLeft.Name = "imgDashboardTopLeft";
            this.imgDashboardTopLeft.Size = new System.Drawing.Size(82, 65);
            this.imgDashboardTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDashboardTopLeft.TabIndex = 0;
            this.imgDashboardTopLeft.TabStop = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(158)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 268);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(150, 50);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(158)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD NEW";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(75)))), ((int)(((byte)(158)))));
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnJobs.Image = ((System.Drawing.Image)(resources.GetObject("btnJobs.Image")));
            this.btnJobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobs.Location = new System.Drawing.Point(0, 168);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnJobs.Size = new System.Drawing.Size(150, 50);
            this.btnJobs.TabIndex = 2;
            this.btnJobs.Text = "JOBS";
            this.btnJobs.UseVisualStyleBackColor = false;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 118);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(150, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(156, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(570, 400);
            this.pnlContainer.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(734, 423);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlLeftSide);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlLeftSide.ResumeLayout(false);
            this.pnlLeftSide.PerformLayout();
            this.pnlDashBoardTopLeft.ResumeLayout(false);
            this.pnlDashBoardTopLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboardTopLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlDashBoardTopLeft;
        private System.Windows.Forms.Label lblDashboardTopLeft;
        private System.Windows.Forms.PictureBox imgDashboardTopLeft;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.LinkLabel linkExit;
    }
}