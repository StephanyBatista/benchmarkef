using System;
using System.Collections.Generic;
using System.Linq;
using benchmarkef.Data;
using benchmarkef.Models;
using Microsoft.EntityFrameworkCore;

namespace benchmarkef.Select
{
    public class EfSelect
    {
        public List<Product> Run(){

            using(var db = new ApplicationDbContext()){
                
                var query = db.Products.Include(p => p.Category).ToList();

                Console.Write("Total EfSelect: " + query.Count);
                return query;
            }
        }
    }
}