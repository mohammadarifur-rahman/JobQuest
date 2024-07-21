using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniProject
{
    internal static class Data
    {
        // csv file path 

        public static string filePath = @"C:\Personal\JobQuest\data\jobs.csv";
        public static LList data;

        // Ensure initialization of data
        /*public static LList GetData()
        {
            data = new LList();
            data.LoadFromCsv(filePath); // Load data from file path
            return data;
        }

        public static void RefreshData()
        {
            data.LoadFromCsv(filePath); // Reload data from file path
        }*/
        // Ensure initialization of data
        public static LList GetData()
        {
            if (data == null)
            {
                data = new LList();
                data.LoadFromCsv(filePath);
            }
            return data;
        }

        // Refresh data from CSV file
        public static void RefreshData()
        {
            if (data == null)
            {
                data = new LList();
            }
            data.LoadFromCsv(filePath);
        }

        // Save data to CSV file
        public static void SaveData()
        {
            if (data != null)
            {
                data.SaveToCsv(filePath);
            }
        }

        // Other methods to manipulate data as needed
        public static void UpdateData(int id, string name, string role, string description, DateTime lastdate, string status)
        {
            if (data != null)
            {
                data.Update(id, name, role, description, lastdate, status);
            }
        }

        public static void AddNewData(string name, string role, string description, DateTime lastdate, string status)
        {
            if (data != null)
            {
                data.AddLast(0, name, role, description, lastdate, status); // Placeholder ID
            }
        }

        public static void RemoveData(int id)
        {
            if (data != null)
            {
                data.RemoveById(id);
            }
        }

    }
}
