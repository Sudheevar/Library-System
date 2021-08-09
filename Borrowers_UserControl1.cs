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
    public partial class Borrowers_UserControl1 : UserControl
    {
        private static Borrowers_UserControl1 _instance;
        public static Borrowers_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrowers_UserControl1();
                }
                return _instance;
            }
        }
        public Borrowers_UserControl1()
        {
            InitializeComponent();
        }


        public string book1, book2, borrower;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\MyDatabase.mdf\";Integrated Security=True");
        public SqlCommand cmd;


        public void refresh_DataGridView()
        {
            try
            {
                cmd = new SqlCommand("showtransactlog_SP", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("   <<<<Invalid SQL OPERATION>>>>  :  \n" + ex);
                }
                conn.Close();
                dataGridview2.DataSource = DS.Tables[0];
                this.dataGridview2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            String Syntax = "SELECT borrower FROM books where accNo='" + AccnoTextField.Text + "'";
            cmd = new SqlCommand(Syntax, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            Borrowlabel.Text = borrower = dr[0].ToString();
            Borrowlabel.Visible = true;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchBorrowersButton.PerformClick();
            if(borrower!="")
            {
                MessageBox.Show("Book is already been Issued to borrower with Borrower Id : \n" + borrower);
                return;
            }
            button3.PerformClick();
            if(book1!="" && book2!="")
            {
                MessageBox.Show("Maximum Limit reached for the Borrower");
            }

            try
            {
                if(book1 =="")
                {
                    cmd = new SqlCommand("Book1UPDATE_SP", conn);
                }
                else
                {
                    cmd = new SqlCommand("Book2Update_SP", conn);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", AccnoTextField.Text);
                cmd.Parameters.AddWithValue("@brId", BorrowerTextField.Text);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("    <<<<<INVALID SQL OPERATION>>>>>     :\n" + ex);
                }
                conn.Close();

            }

            catch(Exception ex)
            {
                MessageBox.Show("     <<<INVALID SQL OPERATION>>>   :\n" + ex);
            }
            cmd = new SqlCommand("UpdateBorrowe_SP", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", AccnoTextField.Text);
            cmd.Parameters.AddWithValue("@brId", BorrowerTextField.Text);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>   :\n" + ex);
            }
            conn.Close();

            cmd = new SqlCommand("", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@book_num", AccnoTextField.Text);
            cmd.Parameters.AddWithValue("@br_id", BorrowerTextField);
            conn.Open();
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show("      <<<<<Invalid sql operation>>>>> :\n  " + ex);        
            }
            conn.Close();

            cmd = new SqlCommand("transactionsinsert_SP", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bkid", AccnoTextField.Text);
            cmd.Parameters.AddWithValue("@brid", BorrowerTextField.Text);
            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("        <<<<Inavalid sql operation>>>>    :\n" + ex);
            }
            conn.Close();

            refresh_DataGridView();
            button3.PerformClick();
            SearchBorrowersButton.PerformClick();
            MessageBox.Show("Successfully Issued");


        }

        private void BorrowerTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccnoTextField_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
            SearchBorrowersButton.PerformClick();
            if ((AccnoTextField.Text != book1) && (AccnoTextField.Text!=book2) )
            {
                MessageBox.Show("Input borrower has not borrowed the book Inputted : \n" + borrower);
                return;
            }
            button3.PerformClick();
           
            try
            {
                if (book1 == AccnoTextField.Text)
                {
                    cmd = new SqlCommand("Book1UPDATE_SP", conn);
                }
                else
                {
                    cmd = new SqlCommand("Book2Update_SP", conn);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accNo", (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@brId", BorrowerTextField.Text);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<<<INVALID SQL OPERATION>>>>>     :\n" + ex);
                }
                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("     <<<INVALID SQL OPERATION>>>   :\n" + ex);
            }
            cmd = new SqlCommand("UpdateBorrowe_SP", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accNo", AccnoTextField.Text);
            cmd.Parameters.AddWithValue("@brId", (object)DBNull.Value);
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("    <<<INVALID SQL OPERATION>>>   :\n" + ex);
            }
            conn.Close();


            cmd = new SqlCommand("transactiondelete_SP", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bkid", AccnoTextField.Text);
            cmd.Parameters.AddWithValue("@brid", BorrowerTextField.Text);
            conn.Open();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("        <<<<Inavalid sql operation>>>>    :\n" + ex);
            }
            conn.Close();
            refresh_DataGridView();

            button3.PerformClick();
            SearchBorrowersButton.PerformClick();
            MessageBox.Show("Successfully Returned");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccnoTextField.Text = "";
            BorrowerTextField.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public SqlDataReader dr;



        private void button1_Click(object sender, EventArgs e)
        {
           
            
            conn.Open();
            String Syntax = "SELECT Book1 FROM Borrowers where BrId='" + BorrowerTextField.Text + "'";
            cmd = new SqlCommand(Syntax, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            book1label.Text = book1 = dr[0].ToString();
            book1label.Visible = true;
            book2label.Visible = true;
            conn.Close();

            conn.Open();
            Syntax = "SELECT Book2 FROM Borrowers where BrId='" + BorrowerTextField.Text + "'";
            cmd = new SqlCommand(Syntax, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            book2label.Text = book2 = dr[0].ToString();
           
            conn.Close();

        }
    }
}
