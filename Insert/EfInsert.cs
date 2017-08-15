using benchmarkef.Data;
using benchmarkef.Models;
using benchmarkef.Util;

namespace benchmarkef.Insert
{
    public class EfInsert
    {
        public void Run(){

            using(var db = new ApplicationDbContext()){
                
                var category = new Category{ Name = GenerateName.NextProductName()};
                var product = new Product { Name = GenerateName.NextProductName() + " EF", Category = category};
                db.Products.Add(product);

                db.SaveChanges();
            }
        }
    }
}