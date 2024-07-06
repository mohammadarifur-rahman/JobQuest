using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniProject
{

    // Represents a single node in the linked list.
    class Node
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string JobDescription { get; set; }

        private DateTime lastdate;
        public DateTime LastDate
        {
            get { return lastdate; }

            set
            {
                lastdate = value;
                /*if (value >= DateTime.Today) lastdate = value;
                else
                {
                    throw new ArgumentException("Deadline must be a future date.");
                }*/
            }
        }

        public string Status { get; set; }
        public DateTime Started { get; }
        public Node next;

        // Constructor to initialize a new node with specified values.
        public Node(int id, string CompanyName, string Role, string JobDescription, DateTime lastdate, string Status, Node next)
        {
            this.ID = id;
            this.CompanyName = CompanyName;
            this.Role = Role;
            this.JobDescription = JobDescription;
            this.LastDate = lastdate;
            this.Status = Status;
            this.Started = DateTime.Today;
            this.next = next;
        }

        // Converts node information to a CSV string format.
        public string ToCsvString()
        {
            return $"{ID},{CompanyName.Trim()},{Role},{JobDescription},{LastDate:yyyy-MM-dd},{Status},{Started:yyyy-MM-dd}";
        }

        // Parses CSV formatted string to create a new Node instance.
        public static Node FromCsvString(string csvLine)
        {
            var parts = csvLine.Split(',');
            if (parts.Length == 7)
            {
                return new Node(int.Parse(parts[0]), parts[1], parts[2],parts[3], DateTime.Parse(parts[4]), parts[5], null);
            }
            throw new ArgumentException("Invalid CSV line format.");
        }

    }

    // Represents a linked list of nodes containing job information.
    class LList
    {
        private Node head;
        private Node tail;
        private int size;

        // Gets the current length of the linked list.
        public int Length
        {
            get { return size; }
        }

        // Constructor to initialize an empty linked list.
        public LList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        // Checks if the linked list is empty.
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Adds a new node with specified values at the beginning of the linked list.
        //two different method to add first
        public void AddFirst(int id, string CompanyName, string Role, string JobDescription, DateTime lastdate, string Status)
        {
            Node newest = new Node(id,CompanyName, Role, JobDescription, lastdate, Status, null);
            if (IsEmpty())
            {
                newest.ID = 1;
                head = newest;
                tail = newest;
            }
            else
            {
                newest.ID = tail.ID + 1;
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void AddFirst(Node newest)
        {
            if (IsEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head = newest;
            }
            size++;
        }

        public void AddLast(Node newest)
        {
            if (IsEmpty())
            {
                head = newest;
            }
            else { tail.next = newest; }
            tail = newest; 
            size++;
        }

        public void AddLast(int id, string CompanyName, string Role, string JobDescription, DateTime lastdate, string Status)
        {
            Node newest = new Node(id, CompanyName, Role, JobDescription, lastdate, Status, null);
            if (IsEmpty())
            {
                newest.ID = 1;
                head = newest;
            }
            else 
            { 
                newest.ID = tail.ID + 1;  
                tail.next = newest; 
            }
            tail = newest; 
            size++;
        }

        // search by ID and return the Node
        public Node Search(int id)
        {
            Node p = head;
            int i = 1;
            while (p != null)
            {
                if (p.ID == id)
                {
                    return p;
                }
                p = p.next;
                i++;

            }
            return null;
        }


        // update by ID
        public void Update(int id, string CompanyName, string Role, string JobDescription, DateTime lastdate, string Status)
        {
            Node p = head;
            while (p != null)
            {
                if (p.ID == id)
                {
                    p.CompanyName = CompanyName;
                    p.Role = Role;
                    p.JobDescription = JobDescription;
                    p.LastDate = lastdate;
                    p.Status = Status;
                }
                p = p.next;
            }
        }


        // Method to remove a node by its ID
        public void RemoveById(int id)
        {
            if (head == null)
            {
                MessageBox.Show("List is empty");
                return;
            }

            Node current = head;
            Node previous = null;

            // Traverse the list to find the node with the specified ID
            while (current != null && current.ID != id)
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
            {
                MessageBox.Show($"Node with ID {id} not found");
                return;
            }

            // Remove the node
            if (previous == null)
            {
                // If the node to remove is the head
                head = head.next;
            }
            else
            {
                // If the node to remove is not the head
                previous.next = current.next;

                if (current == tail)
                {
                    // If the node to remove is the tail, update tail
                    tail = previous;
                }
            }

            size--;
        }

        // Saves the linked list data to a CSV file.
        public void SaveToCsv(string filePath)
        {

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("ID,CompanyName,Role,JobDescription,LastDate,Status,Started");
                Node current = head;
                while (current != null)
                {
                    sw.WriteLine(current.ToCsvString());
                    current = current.next;
                }
            }
        }

        // Loads the linked list data from a CSV file.
        public void LoadFromCsv(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    bool isFirstLine = true;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isFirstLine)
                        {
                            // Skip the header line
                            isFirstLine = false;
                            continue;
                        }
                        Node newNode = Node.FromCsvString(line);
                        AddLast(newNode);
                    }
                }
            }
        }

        // Prepares linked list data for display in a DataGridView based on status filter.
        public List<object[]> DataGridView(string statusFilter)
        {
            // initiated a List of arrays
            List<object[]> data = new List<object[]>();
            Node current = head;
            while (current != null)
            {
                if (current.Status == statusFilter)
                {

                    object[] row =
                    {
                    current.ID,
                    current.CompanyName,
                    current.Role,
                    current.JobDescription,
                    current.LastDate.ToShortDateString(),
                    current.Started.ToShortDateString(),
                    current.Status
                };
                    data.Add(row);
                }
                current = current.next;
            }
            return data;
        }

        // Method to count nodes for each status
        public void CountNodesByStatus(out int inProgressCount, out int completedCount, out int advancedCount, out int rejectedCount)
        {
            inProgressCount = 0;
            completedCount = 0;
            advancedCount = 0;
            rejectedCount = 0;

            Node current = head;
            while (current != null)
            {
                switch (current.Status)
                {
                    case "In Progress":
                        inProgressCount++;
                        break;
                    case "Completed":
                        completedCount++;
                        break;
                    case "Advanced":
                        advancedCount++;
                        break;
                    case "Rejected":
                        rejectedCount++;
                        break;
                    // Handle other statuses if needed
                    default:
                        break;
                }

                current = current.next;
            }
        }
    }
}
