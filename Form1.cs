namespace register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string nic = textBox2.Text;
            string tnum = textBox3.Text;
            string uname = textBox4.Text;
            string pw = textBox5.Text;
            string rpw = textBox6.Text;
            if(name =="")
            {
                MessageBox.Show("Please enter name !");
            }
            if (nic == "")
            {
                MessageBox.Show("Please enter NIC !");
            }
            if (tnum == "")
            {
                MessageBox.Show("Please enter Telephone number !");
            }
            if(pw != "") { 
            if (pw == rpw)
            {
                MessageBox.Show("Successfully Register");
            }
                else {
                    MessageBox.Show("Password doesn't match !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ; 
                }
            this.Close();
            }
            this.Close();
        }
    }
}