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
using System.Xml.Linq;

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
            return db.Categories.Find(id);
        }

        public Category CreateCategory(string name, string description)
        {
            using var db = new NorthwindContext();
            var cat = new Category();
            cat.Id = GetCategories().Max(x => x.Id+1);
            cat.Name = name;
            cat.Description = description; 
            db.Categories.Add(cat);
            db.SaveChanges();

            return cat;

        }

        public bool DeleteCategory(int id)
        {
            using var db = new NorthwindContext();
            var cat = db.Categories.Find(id);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
                return true;
            }
            else return false;

           
        }

        public bool UpdateCategory(int id, string name, string description)
        {
            using var db = new NorthwindContext();
            var cat = GetCategory(id);
            
            db.Update(cat.Id=id);
            db.Update(cat.Name=name);
            db.Update(cat.Description=description);
 
            return true;
        }


    }
}
