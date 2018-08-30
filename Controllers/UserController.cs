using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class UserController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertUser()
        {
            Console.Clear();
            System.Console.Write("Username      : ");
            string Username = System.Console.ReadLine();
            System.Console.Write("Password      : ");
            string Password = System.Console.ReadLine();
            System.Console.Write("First Name    : ");
            string First_Name = System.Console.ReadLine();
            System.Console.Write("Last Name     : ");
            string Last_Name = System.Console.ReadLine();
            System.Console.Write("Address       : ");
            string Address = System.Console.ReadLine();
            System.Console.Write("City          : ");
            string City = System.Console.ReadLine();
            System.Console.Write("Phone         : ");
            string phone = System.Console.ReadLine();
            System.Console.Write("Email         : ");
            string email = System.Console.ReadLine();
            System.Console.Write("Department ID : ");
            int DepartmentID = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Role ID       : ");
            int RoleID = Convert.ToInt32(System.Console.ReadLine());

            UserCls call = new UserCls();
            {
                call.Username = Username;
                call.Password = Password;
                call.First_Name = First_Name;
                call.Last_Name = Last_Name;
                call.Address = Address;
                call.City = City;
                call.Phone = phone;
                call.Email = email;
                call.DepartmentID = DepartmentID;
                call.RoleID = RoleID;

            };
            try
            {
                hld_context.User_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<UserCls> GetAllUser()
        {
            var getalls = hld_context.User_s.ToList();
            foreach (UserCls user in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + user.ID);
                System.Console.WriteLine("Username          : " + user.Username);
                System.Console.WriteLine("Name              : " + user.First_Name + " " + user.Last_Name);
                System.Console.WriteLine("Address           : " + user.Address);
                System.Console.WriteLine("City              : " + user.City);
                System.Console.WriteLine("Phone             : " + user.Phone);
                System.Console.WriteLine("Email             : " + user.Email);
                System.Console.WriteLine("Role              : " + user.RoleID);
                System.Console.WriteLine("Department        : " + user.DepartmentID);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public UserCls GetById(int input)
        {
            var user = hld_context.User_s.Find(input);
            if (user == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return user;
        }
        public int UpdateUser(int input)
        {
            System.Console.Write("MASUKKAN Username          : ");
            string username = System.Console.ReadLine();
            System.Console.Write("MASUKKAN Password          : ");
            string password = System.Console.ReadLine();
            System.Console.Write("MASUKKAN First Name        : ");
            string firstname = System.Console.ReadLine();
            System.Console.Write("MASUKKAN Last Name         : ");
            string lastname = System.Console.ReadLine();
            System.Console.Write("MASUKKAN Address           : ");
            string address = System.Console.ReadLine();
            System.Console.Write("MASUKKAN City              : ");
            string city = System.Console.ReadLine();
            System.Console.Write("MASUKKAN Phone             : ");
            string phone = System.Console.ReadLine();
            System.Console.Write("MASUKKAN Email             : ");
            string email = System.Console.ReadLine();
            System.Console.Write("MASUKKAN Role ID           : ");
            int roleid = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("MASUKKAN Department ID     : ");
            int departmentid = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID          : ");
            string id_dpt = System.Console.ReadLine();

            var getmhs = hld_context.Role_s.Find(Convert.ToInt16(id_dpt));
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID User      : " + id_dpt);
            }
            else
            {
                UserCls user = GetById(input);
                user.Username = username;
                user.Password = password;
                user.First_Name = firstname;
                user.Last_Name = lastname;
                user.Address = address;
                user.City = city;
                user.Phone = phone;
                user.Email = email;
                user.RoleID = roleid;
                user.DepartmentID = departmentid;

                hld_context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteUser(int input)
        {
            var x = (from y in hld_context.User_s where y.ID == input select y).FirstOrDefault();
            hld_context.User_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
