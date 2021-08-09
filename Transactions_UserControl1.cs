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
    public partial class Transactions_UserControl1 : UserControl
    {
        private static Transactions_UserControl1 _instance;
        public static Transactions_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transactions_UserControl1();
                }
                return _instance;
            }
        }
        public Transactions_UserControl1()
        {
            InitializeComponent();

            this.refresh_DataGridView();
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\MyDatabase.mdf\";Integrated Security=True");



        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("borrowersview_SP", conn);
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
                dataGridView3.DataSource = DS.Tables[0];
                dataGridView3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView3.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView3.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView3.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        private void Transactions_UserControl1_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }
    }
}
