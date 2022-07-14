using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DemoAdo.NetCSharp
{
    public partial class Form1 : Form
    {   SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;

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
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dr;
                dgv_ShowDataGrid.DataSource = bindingSource;
                              
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            { 
                conn.Close();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string qry = "insert into employee values(@id,@name,@salary)";
            try
            {
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@id",Convert.ToInt32(txt_EmpId.Text));
                cmd.Parameters.AddWithValue("@name", txt_EmpName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txt_EmpSalary.Text));
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select *  from employee", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dr;
                dgv_ShowDataGrid.DataSource = bindingSource;
                if (result == 1)
                { MessageBox.Show("Record Inserted Successfully.");
                    txt_EmpId.Clear();
                    txt_EmpName.Clear();
                    txt_EmpSalary.Clear();
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally 
            {
                conn.Close(); 
            }
        }

        private void btn_ShowAllEmp_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select *  from employee", conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgv_ShowDataGrid.DataSource = dt;
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally{ conn.Close(); }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_EmpId.Clear();
            txt_EmpName.Clear();
            txt_EmpSalary.Clear();
        }

        private void btn_SearchById_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select *  from employee where e_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_EmpId.Text));
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dr;
                dgv_ShowDataGrid.DataSource = bindingSource;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string qry = "delete from employee where e_id=@id";
            try
            {
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_EmpId.Text));
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select *  from employee", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dr;
                dgv_ShowDataGrid.DataSource = bindingSource;
                if (result == 1)
                { MessageBox.Show("Record Deleted Successfully.");
                    txt_EmpId.Clear();
                    txt_EmpName.Clear();
                    txt_EmpSalary.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string qry = "update employee set e_ename=@name,e_salary=@salary where e_id=@id";
            try
            {
                cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_EmpId.Text));
                cmd.Parameters.AddWithValue("@name", txt_EmpName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txt_EmpSalary.Text));
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select *  from employee", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dr;
                dgv_ShowDataGrid.DataSource = bindingSource;
                if (result == 1)
                { 
                    MessageBox.Show("Record Updated Successfully.");
                    txt_EmpId.Clear();
                    txt_EmpName.Clear();
                    txt_EmpSalary.Clear();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
