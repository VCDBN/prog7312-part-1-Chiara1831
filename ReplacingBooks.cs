using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ST10083452_PROG7312_POE
{
    public partial class ReplacingBooks : Form
    {
        public ReplacingBooks()
        {
            InitializeComponent();
        }

        // List to store call numbers
        private List<CallNumber> callNumbers = new List<CallNumber>();

        // Initialize the progress variable to track the user's progress
        private int progress = 0;

        // Variables to count items in listBox2 and listBox1
        private int itemsInListBox2 = 0;
        private int itemsInListBox1 = 0;

        // Method to generate and display call numbers
        public void GenerateAndDisplayCallNumbers()
        {
            // Clear the list of call numbers and listBox1
            callNumbers.Clear();
            listBox1.Items.Clear();

            // Create a random number generator
            Random random = new Random();


            /*_____Code attribution_____
             * The following method was taken from Microsoft:
             * Author: Unknown
             * Link: https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo?view=net-7.0
             */

            // Create a CultureInfo object for en-US culture (period as decimal separator)
            CultureInfo enUSCulture = new CultureInfo("en-US");
            //_____end_____


            // Generate 10 random call numbers and author initials
            for (int i = 0; i < 10; i++)
            {
                double num = Math.Round(random.NextDouble() * 1000, 2);
                string formattedNumber = num.ToString("000.00", enUSCulture);
                string authorInitials = GenerateRandomInitials();
                callNumbers.Add(new CallNumber { Number = formattedNumber, AuthorInitials = authorInitials });
            }


            // Add call numbers to listBox1
            listBox1.Items.AddRange(callNumbers.Select(callNumber => callNumber.FullCallNumber).ToArray());

            // Enable the checkOrderBtn
            checkOrderBtn.Enabled = true;
        }

        // Event handler for the checkOrderBtn Click event
        private void checkOrderBtn_Click(object sender, EventArgs e)
        {
            // Check if there are 10 items in listBox2
            if (itemsInListBox2 == 10)
            {
                bool isCorrectOrder = IsListBoxSorted(listBox2);

                if (isCorrectOrder)
                {
                    // Display a message if the order is correct
                    MessageBox.Show("You did it! The call numbers are in ascending order.\nYou have earned " +
                        "15 points!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Play again or press the back button to go back to the homepage", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update user's progress and the progress bar
                    progress += 15;
                    progressBar.Value = progress;

                    // Copy items from listBox1 to listBox3
                    listBox3.Items.Clear();
                    listBox3.Items.AddRange(callNumbers.Select(callNumber => callNumber.FullCallNumber).ToArray());


                    // Sort listBox3 using bubble sort
                    BubbleSortListBox(listBox3);
                }
                else
                {
                    // Display an error message for incorrect order
                    MessageBox.Show("Call numbers are not in ascending order! \nYou have earned no points", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear ListBox3 and add items from ListBox1
                    listBox3.Items.Clear();
                    listBox3.Items.AddRange(callNumbers.Select(callNumber => callNumber.FullCallNumber).ToArray());

                    // Sort listBox3 using bubble sort
                    BubbleSortListBox(listBox3);
                }             

            }
            
            else
            {
                // Display a warning message if not all 10 entries are in listBox2
                MessageBox.Show("Please put all 10 entries in the second listbox before checking the order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Enable the checkOrderBtn again
            checkOrderBtn.Enabled = true;
        }


        /*_____Code attribution_____
        * The following method was taken from net-informations:
        * Author: Unknown
        * Link: https://net-informations.com/csharp/string/random.htm
        */

        // Method to generate random author initials
        private string GenerateRandomInitials()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //_____end______

        /*_____Code attribution_____
        * The following method was taken from StackExchange:
        * Author: Unknown
        * Link: https://codereview.stackexchange.com/questions/187135/linq-method-that-selects-an-item-based-on-previous-one
        */

        // Method to check if a ListBox is sorted
        private bool IsListBoxSorted(ListBox listBox)
        {
            if (listBox.Items.Count <= 1)
            {
                return true;
            }

            for (int i = 1; i < listBox.Items.Count; i++)
            {
                string currentItem = listBox.Items[i].ToString();
                string previousItem = listBox.Items[i - 1].ToString();

                // Compare the current item with the previous item
                if (string.Compare(currentItem, previousItem) < 0)
                {
                    return false;
                }
            }

            return true;
        }
        //_____end_____

        /*_____Code attribution_____
         * The following method was taken from GeeksforGeeks:
         * Author: Unknown
         * Link: https://www.geeksforgeeks.org/bubble-sort/
         */

        // Method to perform the Bubble Sort algorithm to sort a ListBox
        private void BubbleSortListBox(ListBox listBox3)
        {
            // Create a list to temporarily store the ListBox items as strings
            List<string> items = new List<string>();

            // Populate the list with items from listBox3
            foreach (var item in listBox3.Items)
            {
                items.Add(item.ToString());
            }

            // Initialize a flag to track if any swaps were made during a pass
            bool swapped;

            // Start the Bubble Sort algorithm
            do
            {
                swapped = false;

                // Iterate through the list of items
                for (int i = 1; i < items.Count; i++)
                {
                    // Compare adjacent items and swap them if they are out of order
                    if (string.Compare(items[i - 1], items[i]) > 0)
                    {
                        // Swap items if they are out of order
                        string temp = items[i - 1];
                        items[i - 1] = items[i];
                        items[i] = temp;

                        // Set the swapped flag to true to indicate a swap occurred
                        swapped = true;
                    }
                }
                // Continue until no swaps are made in a pass
            } while (swapped);  

            // Clear the original ListBox and update it with the sorted items
            listBox3.Items.Clear();
            listBox3.Items.AddRange(items.ToArray());
        }
        //_____end_____


        /*_____Code attribution_____
        * The following method was taken from dotnetcurry:
        * Author: Suprotim Agarwal
        * Link: https://www.dotnetcurry.com/ShowArticle.aspx?ID=183
        */

        // Event handler for mouse down on listBox1
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is clicked and the number of items in listBox2 is less than 10
            if (e.Button == MouseButtons.Left && itemsInListBox2 < 10)
            {
                int selectedIndex = listBox1.IndexFromPoint(e.Location);
                if (selectedIndex >= 0)
                {
                    string selectedItem = listBox1.Items[selectedIndex].ToString();

                    // Remove from listBox1
                    listBox1.Items.RemoveAt(selectedIndex);

                    // Add to listBox2
                    listBox2.Items.Add(selectedItem);
                    itemsInListBox1--;
                    itemsInListBox2++;

                    if (itemsInListBox1 == 10)
                    {
                        // Enable the checkOrderBtn
                        checkOrderBtn.Enabled = true;
                    }
                }
            }
        }

        // Event handler for mouse down on listBox2
        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is clicked and the number of items in listBox1 is less than 10
            if (e.Button == MouseButtons.Left && itemsInListBox1 < 10)
            {
                int selectedIndex = listBox2.IndexFromPoint(e.Location);
                if (selectedIndex >= 0)
                {
                    string selectedItem = listBox2.Items[selectedIndex].ToString();

                    // Remove from listBox2
                    listBox2.Items.RemoveAt(selectedIndex);

                    // Add to listBox1
                    listBox1.Items.Add(selectedItem);

                    itemsInListBox2--;
                    itemsInListBox1++;

                    if (itemsInListBox2 == 10)
                    {
                        // Enable the checkOrderBtn
                        checkOrderBtn.Enabled = true;
                    }
                }
            }
        }
        //_____end_____

        // Method to generate call numbers
        private void generateCallNumBtn_Click(object sender, EventArgs e)
        {
           
            GenerateAndDisplayCallNumbers();

            // Clear listBox2, listbox3, and reset the counter
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            itemsInListBox2 = 0;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Show Form1 and hide Form2
            form1.Show();
            this.Hide();
        }
    }

}
