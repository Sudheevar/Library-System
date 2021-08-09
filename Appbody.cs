using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Appbody : Form
    {
        public Appbody()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            SubPanel.Visible = false;
        }
        private void hidesubmenu()
        {
            if(SubPanel.Visible==true)
            {
                SubPanel.Visible = false;
            }

        }
        private void showsubmenu(Panel Submenu)
        {
            if(Submenu.Visible==false)
            {
                hidesubmenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showsubmenu(SubPanel);
        }

        private void HELPBUTTON_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void SETTINGSBUTTOON_Click(object sender, EventArgs e)
        {
            
            hidesubmenu();
            if (!ContentPanel.Controls.Contains(Settings_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Settings_UserControl1.Instance);
                Settings_UserControl1.Instance.Dock = DockStyle.Fill;
                Settings_UserControl1.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl1.Instance.BringToFront();
            }

        }

        private void EXITBUTTON_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Appbody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity<=1.0)
            {
                this.Opacity =this.Opacity+0.01;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            if(! ContentPanel.Controls.Contains(BooksUserControl1.Instance))
            {
                ContentPanel.Controls.Add(BooksUserControl1.Instance);
                BooksUserControl1.Instance.Dock = DockStyle.Fill;
                BooksUserControl1.Instance.BringToFront();
            }
            else
            {
                BooksUserControl1.Instance.BringToFront();
            }
        }

        private void BorrowersButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Borrowers_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Borrowers_UserControl1.Instance);
                Borrowers_UserControl1.Instance.Dock = DockStyle.Fill;
                Borrowers_UserControl1.Instance.BringToFront();
            }
            else
            {
                Borrowers_UserControl1.Instance.BringToFront();
            }
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Transactions_UserControl1.Instance))
            {
                ContentPanel.Controls.Add(Transactions_UserControl1.Instance);
                Transactions_UserControl1.Instance.Dock = DockStyle.Fill;
                Transactions_UserControl1.Instance.BringToFront();
                Transactions_UserControl1.Instance.refresh_DataGridView();
            }
            else
            {
                Transactions_UserControl1.Instance.BringToFront();
            }
        }
    }
}
