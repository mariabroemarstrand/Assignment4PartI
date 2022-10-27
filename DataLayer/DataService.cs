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

namespace DataLayer
{
    public class DataService
    {
        public IList<Category> GetCategories()
        {
            using var db = new NorthwindContext();

            return db.Categories.ToList();
        }

        //public Category GetCategory(int id)
        //{
        //    using var db = new NorthwindContext();

        //    return db.Categories.ToList();
        //}
    }


}
