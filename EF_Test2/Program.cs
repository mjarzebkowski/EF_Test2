using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EF_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities();
            var post = new Table_1()
            {
                Body = "Body",
                DatePublished = DateTime.Now,
                Title = "Title",
                PostID = 1
            };
            context.Table_1.Add(post);
            context.SaveChanges();

        }
    }
}