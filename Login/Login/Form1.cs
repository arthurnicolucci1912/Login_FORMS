using System.Net.Mail;

//Teste


namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = "admin";
            String password = "adm123";

            if (textBox1.Text == user & textBox2.Text == password)
            {
                MessageBox.Show("Acesso Liberado!");
                Form2 FrmMain = new Form2();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Errou a Senha/Login seu animal");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}