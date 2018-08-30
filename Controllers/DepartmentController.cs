using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class DepartmentController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertDepartment()
        {
            Console.Clear();
            System.Console.Write("Nama Department : ");
            string Nama_Department = System.Console.ReadLine();

            DepartmentCls call = new DepartmentCls();
            {
                call.Department_Name = Nama_Department;

            };
            try
            {
                hld_context.Department_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<DepartmentCls> GetAllDepartment()
        {
            var getalls = hld_context.Department_s.ToList();
            foreach (DepartmentCls department in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + department.ID);
                System.Console.WriteLine("NAMA              : " + department.Department_Name);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public DepartmentCls GetById(int input)
        {
            var department = hld_context.Department_s.Find(input);
            if (department == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return department;
        }
        public int UpdateDepartment(int input)
        {
            System.Console.Write("MASUKKAN NAMA        : ");
            string Nama = System.Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID    : ");
            string id_dpt = System.Console.ReadLine();

            var getmhs = hld_context.Role_s.Find(Convert.ToInt16(id_dpt));
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID DEPARTMENT : " + id_dpt);
            }
            else
            {
                DepartmentCls dept = GetById(input);
                dept.Department_Name = Nama;

                hld_context.Entry(dept).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteDepartment(int input)
        {
            var x = (from y in hld_context.Department_s where y.ID == input select y).FirstOrDefault();
            hld_context.Department_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
