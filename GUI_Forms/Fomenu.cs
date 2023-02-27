namespace napelem_telepito_kozpont
{
    public partial class Fomenu : Form
    {
        public Fomenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //helo
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            testLabel.Text = "Test";
            UserController x = new UserController();
            testLabel.Text = x.TestSqlConnection(usernameBox.Text).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}