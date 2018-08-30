using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Helpdesk_CodeFirst
{
    class HelpdeskEntity
    {
    }
    class RoleCls
    {
        public int ID { get; set; }
        public string Role { get; set; }

        public static implicit operator RoleCls(int v)
        {
            throw new NotImplementedException();
        }
    }
    class SubCategoryCls
    {
        public int ID { get; set; }
        public string SubCategory_Name { get; set; }

        public virtual CategoryCls Category { get; set; }

    }
    class TicketCls
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Dtm_Crt { get; set; }
        public string L1 { get; set; }
        public DateTime DueDateType { get; set; }
        public DateTime Last_update { get; set; }
        public DateTime OnProgressDate { get; set; }
        public DateTime OnWaitingDate { get; set; }
        public DateTime OnHoldDate { get; set; }
        public DateTime ResolvedTime { get; set; }
        public DateTime ClosedTime { get; set; }
        public string Technician { get; set; }
        public string Status { get; set; }

        public string TypeID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }


        public virtual TypeCls Type { get; set; }
        public virtual UserCls User { get; set; }
        public virtual CategoryCls Category { get; set; }
        public virtual SubCategoryCls SubCategory { get; set; }
    }
    class UserCls
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public int DepartmentID { get; set; }

        public virtual RoleCls Role { get; set; }
        public virtual DepartmentCls Department { get; set; }

    }
    class HolidayCls
    {
        public int ID { get; set; }
        public DateTime Dates { get; set; }
        public string Description { get; set; }
    }
    class TypeCls
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Interval { get; set; }

    }
    class DepartmentCls
    {
        public int ID { get; set; }
        public string Department_Name { get; set; }
    }
    class CategoryCls
    {
        public int ID { get; set; }
        public string Category_Name { get; set; }


    }
}

