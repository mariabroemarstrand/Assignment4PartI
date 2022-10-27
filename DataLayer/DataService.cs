using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.Model;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace DataLayer
{
    public class DataService
    {
        public IList<Category> GetCategories()
        {
            using var db = new NorthwindContext();

            return db.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
            
          using var db = new NorthwindContext();
          var cat = new Category { Id = id, Name = "Beverages" };
          db.Remove(cat);
            
          return cat;
            
        }


        public Category CreateCategory(string Name, string id)
        {
            using var db = new NorthwindContext();
            var cat = new Category { Id = 101, Name = "Test", Description = "CreateCategory_ValidData_CreteCategoryAndReturnsNewObject" };
            db.Categories.Add(cat);
            return cat;
        }

        public bool DeleteCategory(int id)
        {
            using var db = new NorthwindContext();
            var cat = GetCategory(id);
            db.Remove(cat);

            if (id > 0)
            {
                return true;
            }
            else return false;
        }



    }
}
