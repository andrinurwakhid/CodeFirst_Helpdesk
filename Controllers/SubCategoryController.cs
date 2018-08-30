using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class SubCategoryController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertSubCategory()
        {
            Console.Clear();
            System.Console.Write("SubCategory Name      : ");
            string catname = System.Console.ReadLine();
            System.Console.Write("Category ID           : ");
            int catid = Convert.ToInt32(System.Console.ReadLine());

            SubCategoryCls call = new SubCategoryCls();
            {
                call.SubCategory_Name = catname;
                //call.CategoryID = catid;

            };
            try
            {
                hld_context.SubCategory_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<SubCategoryCls> GetAllSubCategory()
        {
            var getalls = hld_context.SubCategory_s.ToList();
            foreach (SubCategoryCls subcategory in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                        : " + subcategory.ID);
                //System.Console.WriteLine("Category ID               : " + subcategory.CategoryID);
                System.Console.WriteLine("Sub Category Name         : " + subcategory.SubCategory_Name);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public SubCategoryCls GetByid(int input)
        {
            var cat = hld_context.SubCategory_s.Find(input);
            if (cat == null)
            {
                System.Console.WriteLine("ID tersebut tidak ada");
            }
            return cat;
        }
        public int UpdateSubCategory(int input)
        {
            System.Console.Write("Sub Category Name           : ");
            string subcatname = System.Console.ReadLine();
            System.Console.Write("Category ID                 : ");
            int catid = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID           : ");
            int id_subcat = Convert.ToInt32(System.Console.ReadLine());

            var getmhs = hld_context.SubCategory_s.Find(id_subcat);
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID SUBCATEGORY  : " + id_subcat);
            }
            else
            {
                SubCategoryCls ct = GetByid(input);
                ct.ID = id_subcat;
                // ct.CategoryID = catid;
                ct.SubCategory_Name = subcatname;

                hld_context.Entry(ct).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteSubCategory(int input)
        {
            var x = (from y in hld_context.SubCategory_s where y.ID == input select y).FirstOrDefault();
            hld_context.SubCategory_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
