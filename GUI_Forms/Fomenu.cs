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
            string sqlFilePath = @"C:\Users\DirrDurrKand�r\source\repos\napelem_telepitesi_kozpont\DataBase\napelem.sql";
            string databaseName = "napelem_rendszer";
            testLabel.Text = "Database loaded successfully!";
        }
    }
}