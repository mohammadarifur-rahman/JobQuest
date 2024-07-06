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
    public partial class Jobs : Form
    {
        public string[] details;
        private LList data; // Declare LList instance

        // detail form
        private Detail detailForm;

        public Jobs()
        {
            InitializeComponent();

            // Subscribe CellDoubleClick event for each DataGridView
            //gridJobs1.CellDoubleClick += DataGridView_CellDoubleClick;
            gridJobs2.CellDoubleClick += DataGridView_CellDoubleClick;
            gridJobs3.CellDoubleClick += DataGridView_CellDoubleClick;
            gridJobs4.CellDoubleClick += DataGridView_CellDoubleClick;
        }


        private void Jobs_Load(object sender, EventArgs e)
        {
            RefreshJobs();
        }

        public void RefreshJobs()
        {
            // assign data
            data = Data.GetData();

            // Inprogress
            FourGridPopulate(gridJobs1, data.DataGridView("In Progress"));

            // Completed
            FourGridPopulate(gridJobs2, data.DataGridView("Completed"));

            // Advanced
            FourGridPopulate(gridJobs3, data.DataGridView("Advanced"));

            // Rejections
            FourGridPopulate(gridJobs4, data.DataGridView("Rejected"));
        }

        public void FourGridPopulate(DataGridView datagridView, List<object[]> dataGrid)
        {
            datagridView.Rows.Clear();
            datagridView.Columns.Clear();

            datagridView.Columns.Add("CompanyName", "Company Name");
            datagridView.Columns.Add("LastDate", "Last Date");
            datagridView.Columns.Add("ID", "ID"); // Add ID column

            foreach (var row in dataGrid)
            {
                datagridView.Rows.Add(row[1], row[4], row[0]);
            }
        }

        private void gridJobs1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string companyName="";
            int id = 0;
            if (e.RowIndex >= 0 && e.RowIndex < gridJobs1.Rows.Count - 1)
            {
                companyName = gridJobs1.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                id = int.Parse(gridJobs1.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
            Node search = data.Search(id);
            if(search != null)
            {

                details = new string[7];
                details[0] = (id.ToString());
                details[1] = (search.CompanyName);
                details[2] = (search.Role); ;
                details[3] = (search.JobDescription);
                details[4] = (search.LastDate.ToString());
                details[5] = (search.Status);
                details[6] = (search.Started.ToString());

                Detail detailForm = new Detail(details);
                detailForm.ShowDialog();
            }
        }


        // DataGridView_CellDoubleClick method handles cell double-click events for all DataGridViews
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView == null || e.RowIndex < 0)
            {
                return;
            }

            // Determine which DataGridView triggered the event
            switch (dataGridView.Name)
            {
                case "gridJobs1":
                    ProcessDataGridViewRow(dataGridView, e.RowIndex);
                    break;
                case "gridJobs2":
                    ProcessDataGridViewRow(dataGridView, e.RowIndex);
                    break;
                case "gridJobs3":
                    ProcessDataGridViewRow(dataGridView, e.RowIndex);
                    break;
                case "gridJobs4":
                    ProcessDataGridViewRow(dataGridView, e.RowIndex);
                    break;
                default:
                    // Handle unexpected DataGridView name if needed
                    break;
            }
        }

        // Method to process a specific row in a DataGridView
        private void ProcessDataGridViewRow(DataGridView dataGridView, int rowIndex)
        {
            // Assuming "CompanyName" and "ID" are column names in your DataGridView
            string companyName = dataGridView.Rows[rowIndex].Cells["CompanyName"].Value?.ToString();
            int id;

            // Attempt to parse ID
            if (!int.TryParse(dataGridView.Rows[rowIndex].Cells["ID"].Value?.ToString(), out id))
            {
                // Handle parsing failure if necessary
                return;
            }

            // Assuming data is obtained from a method/data structure named "data"
            Node search = data.Search(id);

            if (search != null)
            {
                // Populate details array
                string[] details = new string[7];
                details[0] = id.ToString();
                details[1] = search.CompanyName;
                details[2] = search.Role;
                details[3] = search.JobDescription;
                details[4] = search.LastDate.ToString();
                details[5] = search.Status;
                details[6] = search.Started.ToString();

                // Open detail form and pass details array
                Detail detailForm = new Detail(details);

                detailForm.ShowDialog();
            }
            else
            {
                // Handle case where search result is null (not found)
                MessageBox.Show("Data not found.");
            }
        }

        // Event handler for DataUpdated event
        /*private void DetailForm_DataUpdated()
        {
            // Refresh Jobs form after data is updated in Detail form
            RefreshJobs();
            
        }*/

    }
}
