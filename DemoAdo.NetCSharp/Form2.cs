using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;



namespace DemoAdo.NetCSharp
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        //SqlCommand cmd;
        //SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
            string CS = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            conn = new SqlConnection(CS);
            
        }
        public DataSet GetAllEmps()
        {
            da = new SqlDataAdapter("select * from employee", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder sb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            

            return ds;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                ds=GetAllEmps();
                DataRow dr = ds.Tables["emp"].NewRow();
                dr["e_id"]=txt_EmpId.Text;
                dr["e_ename"]=txt_EmpName.Text;
                dr["e_salary"] = txt_EmpSalary.Text;
                ds.Tables["emp"].Rows.Add(dr);
                int result = da.Update(ds.Tables["emp"]);
                dgv_ShowDataGrid.DataSource = ds;
                if (result == 1) MessageBox.Show("Inserted Successfull");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message);}
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_EmpId.Clear();
            txt_EmpName.Clear();
            txt_EmpSalary.Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                dgv_ShowDataGrid.DataSource = ds;
                DataRow dr = ds.Tables["emp"].Rows.Find(txt_EmpId.Text);
                if(dr != null)
                {
                    dr["e_id"] = txt_EmpId.Text;
                    dr["e_ename"] = txt_EmpName.Text;
                    dr["e_salary"] = txt_EmpSalary.Text;
                    int result = da.Update(ds.Tables["emp"]);
                    dgv_ShowDataGrid.DataSource = ds.Tables["emp"];
                    if (result == 1) MessageBox.Show("Updated Successfull");
                }
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow dr = ds.Tables["emp"].Rows.Find(txt_EmpId.Text);
                if (dr != null)
                {
                    dr.Delete();
                    int result = da.Update(ds.Tables["emp"]);
                    dgv_ShowDataGrid.DataSource = ds.Tables["emp"];
                    if (result == 1) MessageBox.Show("Deleted Successfull");
                    txt_EmpId.Clear();
                    txt_EmpName.Clear();
                    txt_EmpSalary.Clear();
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_ShowAllEmp_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                dgv_ShowDataGrid.DataSource = ds.Tables["emp"];
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_SearchById_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();

                DataRow dr = ds.Tables["emp"].Rows.Find(txt_EmpId.Text);
                if (dr != null)
                {

                    DataSet ds2 = new DataSet();

                   // dgv_ShowDataGrid.DataSource;

                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
