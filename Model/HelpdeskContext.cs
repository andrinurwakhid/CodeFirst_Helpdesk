using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Helpdesk_CodeFirst.Model
{
    class HelpdeskContext : DbContext
    {
        public HelpdeskContext() : base()
        {

        }

        public DbSet<UserCls> User_s { get; set; }
        public DbSet<TicketCls> Ticket_s { get; set; }
        public DbSet<SubCategoryCls> SubCategory_s { get; set; }
        public DbSet<CategoryCls> Category_s { get; set; }
        public DbSet<HolidayCls> Holiday_s { get; set; }
        public DbSet<RoleCls> Role_s { get; set; }
        public DbSet<DepartmentCls> Department_s { get; set; }
        public DbSet<TypeCls> Type_s { get; set; }
    }
}
