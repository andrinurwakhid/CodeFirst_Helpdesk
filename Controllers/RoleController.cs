using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class RoleController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertRole()
        {
            Console.Clear();
            System.Console.Write("Nama Role : ");
            string Nama_Role = System.Console.ReadLine();

            RoleCls call = new RoleCls();
            {
                call.Role = Nama_Role;

            };
            try
            {
                hld_context.Role_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<RoleCls> GetAllRole()
        {
            var getalls = hld_context.Role_s.ToList();
            foreach (RoleCls role in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + role.ID);
                System.Console.WriteLine("NAMA              : " + role.Role);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public RoleCls GetById(int input)
        {
            var role = hld_context.Role_s.Find(input);
            if (role == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return role;
        }
        public int UpdateRole(int input)
        {
            System.Console.Write("MASUKKAN NAMA        : ");
            string Nama = System.Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID    : ");
            string id_role = System.Console.ReadLine();

            var getmhs = hld_context.Role_s.Find(Convert.ToInt16(id_role));
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID ROLE : " + id_role);
            }
            else
            {
                RoleCls role = GetById(input);
                role.Role = Nama;

                hld_context.Entry(role).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteRole(int input)
        {
            var x = (from y in hld_context.Role_s where y.ID == input select y).FirstOrDefault();
            hld_context.Role_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
