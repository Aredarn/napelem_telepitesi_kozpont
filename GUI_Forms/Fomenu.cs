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
            UserController x = new UserController();

            string result = x.TestSqlConnection(usernameBox.Text);
            testLabel.Text = result;
        }
    }
}