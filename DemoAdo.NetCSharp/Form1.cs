using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DemoAdo.NetCSharp
{
    public partial class Form1 : Form
    {     SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
                       

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            try
            {
                conn = new SqlConnection(CS);
                cmd = new SqlCommand("select *  from employee", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = rdr;
                dgv_ShowDataGrid.DataSource = bindingSource;
                              
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { 
                conn.Close();
            }

        }
    }
}
