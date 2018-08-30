using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class CategoryController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertCategory()
        {
            Console.Clear();
            System.Console.Write("Category Name      : ");
            string catname = System.Console.ReadLine();

            CategoryCls call = new CategoryCls();
            {
                call.Category_Name = catname;

            };
            try
            {
                hld_context.Category_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<CategoryCls> GetAllCategory()
        {
            var getalls = hld_context.Category_s.ToList();
            foreach (CategoryCls category in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                    : " + category.ID);
                System.Console.WriteLine("Category Name         : " + category.Category_Name);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public CategoryCls GetByid(int input)
        {
            var cat = hld_context.Category_s.Find(input);
            if (cat == null)
            {
                System.Console.WriteLine("ID tersebut tidak ada");
            }
            return cat;
        }
        public int UpdateCategory(int input)
        {
            System.Console.Write("Category Name           : ");
            string catnames = System.Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID       : ");
            int id_cat = Convert.ToInt32(System.Console.ReadLine());

            var getmhs = hld_context.Category_s.Find(id_cat);
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID CATEGORY  : " + id_cat);
            }
            else
            {
                CategoryCls ct = GetByid(input);
                ct.ID = id_cat;
                ct.Category_Name = catnames;

                hld_context.Entry(ct).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteCategory(int input)
        {
            var x = (from y in hld_context.Category_s where y.ID == input select y).FirstOrDefault();
            hld_context.Category_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
