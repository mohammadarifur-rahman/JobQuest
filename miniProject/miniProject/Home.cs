using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProject
{
    public partial class Home : Form
    {
        private LList data; // Declare LList instance
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            data = Data.GetData();// Initialize data
            int inProgressCount;
            int completedCount;
            int advancedCoutn;
            int rejectedCount;
            data.CountNodesByStatus(out inProgressCount, out completedCount, out advancedCoutn, out rejectedCount);

            // total submitted
            int totalSubmitted = completedCount+ advancedCoutn+ rejectedCount;
            lblInProgress.Text = inProgressCount.ToString();
            lblSubmitted.Text = totalSubmitted.ToString();
            
            // circular progress bar for advanced
            cpAdvanced.Text = CalculatePercent(advancedCoutn, totalSubmitted).ToString()+"%";
            cpAdvanced.Value = CalculatePercent(advancedCoutn, totalSubmitted);

            //circular progress bar for rejected
            cpRejected.Text = CalculatePercent(rejectedCount, totalSubmitted).ToString()+"%";
            cpRejected.Value = CalculatePercent(rejectedCount, totalSubmitted);
        }

        private int CalculatePercent(int numerator, int denominator)
        {
            // Calculate percentage with floating-point division
            double percentage = ((double) numerator / denominator)*100;
            int round = (int) Math.Round(percentage);
            return round;
        }
    }
}
