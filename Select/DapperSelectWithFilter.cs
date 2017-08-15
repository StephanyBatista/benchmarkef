using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using benchmarkef.Models;
using Dapper;

namespace benchmarkef.Select
{
    public class DapperSelectWithFilter
    {
        public List<Product> Run(){

            using (IDbConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=benchmarkef;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                
                var query = db.Query<Product>(@"
                SELECT p.*, c.*
                FROM Products p
                INNER JOIN Categories c ON p.categoryId = c.id
                where c.name = 'Games'").AsList();

                Console.Write("Total DapperSelectWithFilter: " + query.Count);
                return query;
            }
        }
    }
}