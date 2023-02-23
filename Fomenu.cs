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
            MyDbContext x = new MyDbContext();

            string result = x.TestSqlConnection();
            testLabel.Text = result;
        }
    }
}