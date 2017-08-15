using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using benchmarkef.Models;
using benchmarkef.Util;
using Dapper;

namespace benchmarkef.Insert
{
    public class DapperInsert
    {
        public void Run(){

            using (IDbConnection db = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=benchmarkef;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                string insertCategory = @"INSERT INTO Categories(Name) VALUES (@Name); SELECT CAST(SCOPE_IDENTITY() as int)";
                var category = new Category{ Name = GenerateName.NextCategoryName()};
                var resultCategory = db.Query<int>(insertCategory, new {Name = category.Name});

                string insertProduct = @"INSERT INTO Products(Name, CategoryId) VALUES (@Name, @CategoryId)";
                var product = new Product{ Name = GenerateName.NextProductName(), Category = category};
                var resultProduct = db.Execute(insertProduct, new {Name = product.Name + " Dapper", CategoryId = resultCategory.Single()});
            }
        }
    }
}