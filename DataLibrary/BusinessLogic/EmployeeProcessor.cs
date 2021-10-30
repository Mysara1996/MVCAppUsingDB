using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, String firstName, String lastName, String EmailAddress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = EmailAddress
            };

            string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress)
                          values (@EmployeeId, @FirstName, @LastName, @EmailAddress);";
           
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployess() 
        {
            String sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress
                         from dbo.Employees;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
