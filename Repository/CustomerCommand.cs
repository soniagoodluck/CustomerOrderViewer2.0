using CustomerOrderViewer2._0.Models;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace CustomerOrderViewer2._0.Repository
{
    class CustomerCommand
    {
        private string _connectionString;

        public CustomerCommand(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<CustomerModel> GetList()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            var sqlStatement = "Customer_GetList";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                customers = connection.Query<CustomerModel>(sqlStatement).ToList();
            }

            return customers;
        }
    }
}
