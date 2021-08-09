using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Library_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\MyDatabase.mdf\";Integrated Security=True");    
        SqlCommand cmd;
        SqlDataReader dr;

        private String getUsername()
        {
            //Fetch data from database
            conn.Open();
            String syntax = "select Value From SystemTable where Property='UserName'";
            cmd = new SqlCommand(syntax,conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            conn.Close();
            return temp;
        }
        private String getPassword()
        {
            //Fetch data from database
            conn.Open();
            String syntax = "select Value From SystemTable where Property='Password'";
            cmd = new SqlCommand(syntax, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            String temp = dr[0].ToString();
            conn.Close();
            return temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = getUsername();
            String Password = getPassword();
            String name, pass;
            name = UserTextBox.Text;
            pass = PasswordTextBox.Text;
            if(name.Equals(Username)&&pass.Equals(Password))
            {
                ErrorLabel.Hide();
                MessageBox.Show("Login Success");
                Appbody obj = new Appbody();
                this.Hide();
                obj.Show();
            }
            else
            {
                ErrorLabel.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
