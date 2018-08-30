using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class TypeController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertDueDate()
        {
            Console.Clear();
            System.Console.Write("Tipe               : ");
            string Tipe = System.Console.ReadLine();
            System.Console.Write("Interval Type      : ");
            int interval = Convert.ToInt32(System.Console.ReadLine());

            TypeCls call = new TypeCls();
            {
                call.Type = Tipe;
                call.Interval = interval;

            };
            try
            {
                hld_context.Type_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<TypeCls> GetAllTipe()
        {
            var getalls = hld_context.Type_s.ToList();
            foreach (TypeCls duedate in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("Type                  : " + duedate.Type);
                System.Console.WriteLine("Interval              : " + duedate.Interval);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public TypeCls GetBytype(string input)
        {
            var duedate = hld_context.Type_s.Find(input);
            if (duedate == null)
            {
                System.Console.WriteLine("type tersebut tidak ada");
            }
            return duedate;
        }
        public string UpdateDuedate(string input)
        {
            System.Console.Write("MASUKKAN Interval           : ");
            int interval = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG Type         : ");
            string id_type = System.Console.ReadLine();

            var getmhs = hld_context.Type_s.Find(id_type);
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA Type DueDate  : " + id_type);
            }
            else
            {
                TypeCls dd = GetBytype(input);
                dd.Type = id_type;
                dd.Interval = interval;

                hld_context.Entry(dd).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteDueDate(string input)
        {
            var x = (from y in hld_context.Type_s where y.Type == input select y).FirstOrDefault();
            hld_context.Type_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
