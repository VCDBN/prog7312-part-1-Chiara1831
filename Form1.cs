namespace ST10083452_PROG7312_POE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void replacingBooksBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of ReplacingBooks
            ReplacingBooks rb = new ReplacingBooks();

            rb.Show();
            this.Hide();

            rb.GenerateAndDisplayCallNumbers();
        }

        
    }
}
