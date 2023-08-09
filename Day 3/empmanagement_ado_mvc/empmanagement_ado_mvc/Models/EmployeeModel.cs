using System.Data;
using Microsoft.Data.SqlClient;

namespace empmanagement_ado_mvc.Models
{
    public class EmployeeModel
    {
        #region Properties
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public int empSalary { get; set; }
        public bool empIsPermenant { get; set; }
        #endregion

        #region Variables
        List<EmployeeModel> eList = new List<EmployeeModel>();

        SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=employeeDB;integrated security=true");
        SqlCommand cmd = new SqlCommand("select * from employeeInfo");
        #endregion

        #region Get All Employees
        public List<EmployeeModel> GetAllEmployees()
        {
            cmd.Connection = con;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                eList.Add(new EmployeeModel()
                {
                    empNo =Convert.ToInt32(reader[0]),
                    empName = reader[1].ToString(),
                    empDesignation = reader[2].ToString(),
                    empSalary =Convert.ToInt32(reader[3]),
                    empIsPermenant =Convert.ToBoolean(reader[4])
                });
            }
            con.Close();
            return eList;
        }
        #endregion

        public string AddNewEmployee(EmployeeModel newEmp)
        {
            SqlCommand cmdAdd = new SqlCommand("insert into employeeInfo values(@eno,@ename,@edesignation,@esalary,@eispermenant)", con);

            cmdAdd.Parameters.AddWithValue("@eno", newEmp.empNo);
            cmdAdd.Parameters.AddWithValue("@ename", newEmp.empName);
            cmdAdd.Parameters.AddWithValue("@edesignation", newEmp.empDesignation);
            cmdAdd.Parameters.AddWithValue("@esalary", newEmp.empSalary);
            cmdAdd.Parameters.AddWithValue("@eispermenant", newEmp.empIsPermenant);

            con.Open();
            cmdAdd.ExecuteNonQuery();
            con.Close();

            return "Employee Added To System";

        }



    }
}
