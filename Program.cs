using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Controllers;
namespace Helpdesk_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int menudefault;
        mdefault:
            Console.WriteLine("==================[ CRUD ]===================");
            Console.WriteLine("||    1. CREATE      ||    3. UPDATE       ||");
            Console.WriteLine("||    2. READ        ||    4. DELETE       ||");
            Console.WriteLine("||                5. EXIT                  ||");
            Console.WriteLine("=============================================");
            Console.Write("Tentukan Pilihanmu : "); menudefault = Convert.ToInt32(Console.ReadLine());
            switch (menudefault)
            {
                case 1:
                    Program mc1 = new Program();
                    mc1.m1();
                    break;
                case 2:
                    Program mc2 = new Program();
                    mc2.m2();
                    break;
                case 3:
                    Program mc3 = new Program();
                    mc3.m3();
                    break;
                case 4:
                    Program mc4 = new Program();
                    mc4.m4();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto mdefault;
            }
            Console.ReadKey(true);
        }
        public void isimenu()
        {
            Console.WriteLine("||    1. ROLE        ||    5. CATEGORY     ||");
            Console.WriteLine("||    2. DEPARTMENT  ||    6. SUBCATEGORY  ||");
            Console.WriteLine("||    3. USER        ||    7. TICKET       ||");
            Console.WriteLine("||    4. TYPE        ||    8. EXIT         ||");
            Console.WriteLine("=============================================");
        }
        public void m1()
        {
            int menu1;
        m1:
            Console.Clear();
            Console.WriteLine("================== CREATE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu1 = Convert.ToInt32(Console.ReadLine());
            switch (menu1)
            {
                case 1:
                    RoleController panggilrole = new RoleController();
                    panggilrole.InsertRole();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    goto m1;
                case 2:
                    DepartmentController panggildept = new DepartmentController();
                    panggildept.InsertDepartment();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    UserController panggiluser = new UserController();
                    panggiluser.InsertUser();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    TypeController panggildd = new TypeController();
                    panggildd.InsertDueDate();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    CategoryController panggilcat = new CategoryController();
                    panggilcat.InsertCategory();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    SubCategoryController panggilsubcat = new SubCategoryController();
                    panggilsubcat.InsertSubCategory();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    TicketController panggiltck = new TicketController();
                    panggiltck.InsertTicket();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m1;
            }
            Console.ReadKey(true);
        }
        public void m2()
        {
            int menu2;
        m2:
            Console.Clear();
            Console.WriteLine("=================== READ ====================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu2 = Convert.ToInt32(Console.ReadLine());
            switch (menu2)
            {
                case 1:
                    RoleController panggilrole = new RoleController();
                    panggilrole.GetAllRole();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    DepartmentController panggildept = new DepartmentController();
                    panggildept.GetAllDepartment();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    UserController panggiluser = new UserController();
                    panggiluser.GetAllUser();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    TypeController panggildd = new TypeController();
                    panggildd.GetAllTipe();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    CategoryController panggilcat = new CategoryController();
                    panggilcat.GetAllCategory();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    SubCategoryController panggilsubcat = new SubCategoryController();
                    panggilsubcat.GetAllSubCategory();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    TicketController panggiltck = new TicketController();
                    panggiltck.GetAllTicket();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m2;
            }
            Console.ReadKey(true);
        }
        public void m3()
        {
            int menu3, input1, input2, input3, input5, input6,input7;
            string input4;
        m3:
            Console.Clear();
            Console.WriteLine("================== UPDATE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu3 = Convert.ToInt32(Console.ReadLine());
            switch (menu3)
            {
                case 1:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input1 = Convert.ToInt32(System.Console.ReadLine());
                    RoleController panggilrole = new RoleController();
                    panggilrole.UpdateRole(input1);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input2 = Convert.ToInt32(System.Console.ReadLine());
                    DepartmentController panggildept = new DepartmentController();
                    panggildept.UpdateDepartment(input2);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input3 = Convert.ToInt32(System.Console.ReadLine());
                    UserController panggiluser = new UserController();
                    panggiluser.UpdateUser(input3);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input4 = System.Console.ReadLine();
                    TypeController panggildd = new TypeController();
                    panggildd.UpdateDuedate(input4);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input5 = Convert.ToInt32(System.Console.ReadLine());
                    CategoryController panggilcat = new CategoryController();
                    panggilcat.UpdateCategory(input5);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input6 = Convert.ToInt32(System.Console.ReadLine());
                    SubCategoryController panggilsubcat = new SubCategoryController();
                    panggilsubcat.UpdateSubCategory(input6);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input7 = Convert.ToInt32(System.Console.ReadLine());
                    TicketController panggiltck = new TicketController();
                    panggiltck.UpdateTicket(input7);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m3;
            }
            Console.ReadKey(true);
        }
        public void m4()
        {
            int menu4, input1, input2, input3, input5, input6,input7;
            string input4;
        m4:
            Console.Clear();
            Console.WriteLine("================== DELETE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu4 = Convert.ToInt32(Console.ReadLine());
            switch (menu4)
            {
                case 1:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input1 = Convert.ToInt32(System.Console.ReadLine());
                    RoleController panggilrole = new RoleController();
                    panggilrole.DeleteRole(input1);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input2 = Convert.ToInt32(System.Console.ReadLine());
                    DepartmentController panggildept = new DepartmentController();
                    panggildept.DeleteDepartment(input2);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input3 = Convert.ToInt32(System.Console.ReadLine());
                    UserController panggiluser = new UserController();
                    panggiluser.DeleteUser(input3);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input4 = System.Console.ReadLine();
                    TypeController panggildd = new TypeController();
                    panggildd.DeleteDueDate(input4);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input5 = Convert.ToInt32(System.Console.ReadLine());
                    CategoryController panggilcat = new CategoryController();
                    panggilcat.DeleteCategory(input5);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input6 = Convert.ToInt32(System.Console.ReadLine());
                    SubCategoryController panggilsubcat = new SubCategoryController();
                    panggilsubcat.DeleteSubCategory(input6);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input7 = Convert.ToInt32(System.Console.ReadLine());
                    TicketController panggiltck = new TicketController();
                    panggiltck.DeleteTicket(input7);
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m4;
            }
        }
    }
}
