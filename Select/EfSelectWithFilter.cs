using System;
using System.Collections.Generic;
using System.Linq;
using benchmarkef.Data;
using benchmarkef.Models;
using Microsoft.EntityFrameworkCore;

namespace benchmarkef.Select
{
    public class EfSelectWithFilter
    {
        public List<Product> Run(){

            using(var db = new ApplicationDbContext()){
                
                var query = db.Products.Include(p => p.Category).Where(p => p.Category.Name == "Games").ToList();

                Console.Write("Total EfSelectWithFilter: " + query.Count);
                return query;
            }
        }
    }
}