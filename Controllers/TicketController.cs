using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Model;

namespace Helpdesk_CodeFirst.Controllers
{
    class TicketController
    {
        HelpdeskContext hld_context = new HelpdeskContext();

        // =========================================== INSERT =============================================
        public void InsertTicket()
        {
            Console.Clear();
            System.Console.Write("Description       : ");
            string description = System.Console.ReadLine();
            System.Console.Write("Date Create       : ");
            DateTime dtmcrt = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Due Date          : ");
            DateTime duedt = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("L1                : ");
            string l1 = System.Console.ReadLine();
            System.Console.Write("Technician        : ");
            string technc = System.Console.ReadLine();
            System.Console.Write("Type ID           : ");
            int tid = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("User ID           : ");
            int uid = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Category ID       : ");
            int cid = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("SubCategory ID    : ");
            int scid = Convert.ToInt32(System.Console.ReadLine());


            TicketCls call = new TicketCls();
            {
                call.Description = description;
                call.Dtm_Crt = dtmcrt;
                call.L1 = l1;
                call.DueDate = duedt;
                call.Technician = technc;
                call.TypeID = tid;
                call.UserID = uid;
                call.CategoryID = cid;
                call.SubCategoryID = scid;

            };
            try
            {
                hld_context.Ticket_s.Add(call);
                var result = hld_context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<TicketCls> GetAllTicket()
        {
            var getalls = hld_context.Ticket_s.ToList();
            foreach (TicketCls ticket in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                       : " + ticket.ID);
                System.Console.WriteLine("Description              : " + ticket.Description);
                System.Console.WriteLine("Date Create              : " + ticket.Dtm_Crt);
                System.Console.WriteLine("L1                       : " + ticket.L1);
                System.Console.WriteLine("Due Date                 : " + ticket.DueDate);
                System.Console.WriteLine("Last Update              : " + ticket.Last_update);
                System.Console.WriteLine("OnProgress Date          : " + ticket.OnProgressDate);
                System.Console.WriteLine("OnWaiting Date           : " + ticket.OnWaitingDate);
                System.Console.WriteLine("OnHold Date              : " + ticket.OnHoldDate);
                System.Console.WriteLine("Resolved Time            : " + ticket.ResolvedTime);
                System.Console.WriteLine("Closed Time              : " + ticket.ClosedTime);
                System.Console.WriteLine("Technician               : " + ticket.Technician);
                System.Console.WriteLine("Status                   : " + ticket.Status);
                System.Console.WriteLine("User ID                  : " + ticket.UserID);
                System.Console.WriteLine("Category ID              : " + ticket.CategoryID);
                System.Console.WriteLine("SubCategory ID           : " + ticket.SubCategoryID);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public TicketCls GetById(int input)
        {
            var ticket = hld_context.Ticket_s.Find(input);
            if (ticket == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return ticket;
        }
        public int UpdateTicket(int input)
        {

            Console.Clear();
            System.Console.Write("Description       : ");
            string description = System.Console.ReadLine();
            System.Console.Write("Date Create       : ");
            DateTime dtmcrt = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Due Date          : ");
            DateTime duedt = Convert.ToDateTime(System.Console.ReadLine());
            Console.WriteLine("=============================================");
            System.Console.Write("Last Update       : ");
            DateTime lstupdt = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("OnProgress Date   : ");
            DateTime onpgrs = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("OnWaiting Date    : ");
            DateTime onwtng = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("OnHold Date       : ");
            DateTime onhld = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Resolved Time       : ");
            DateTime rsvd = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Closed Time       : ");
            DateTime cldtm = Convert.ToDateTime(System.Console.ReadLine());
            System.Console.Write("Status            : ");
            string stat = System.Console.ReadLine();
            Console.WriteLine("=============================================");
            System.Console.Write("L1                : ");
            string l1 = System.Console.ReadLine();
            System.Console.Write("Technician        : ");
            string technc = System.Console.ReadLine();
            System.Console.Write("Type ID           : ");
            int tid = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("User ID           : ");
            int uid = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Category ID       : ");
            int cid = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("SubCategory ID    : ");
            int scid = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID    : ");
            int id_ticket = Convert.ToInt32(System.Console.ReadLine());

            var getmhs = hld_context.Ticket_s.Find(id_ticket);
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID ROLE : " + id_ticket);
            }
            else
            {
                TicketCls ticket = GetById(input);
                ticket.Description = description;
                ticket.Dtm_Crt = dtmcrt;
                ticket.L1 = l1;
                ticket.DueDate = duedt;
                ticket.Last_update = lstupdt;
                ticket.OnProgressDate = onpgrs;
                ticket.OnWaitingDate = onwtng;
                ticket.OnHoldDate = onhld;
                ticket.ResolvedTime = rsvd;
                ticket.ClosedTime = cldtm;
                ticket.Technician = technc;
                ticket.Status = stat;
                ticket.UserID = uid;
                ticket.CategoryID = cid;
                ticket.SubCategoryID = scid;

                hld_context.Entry(ticket).State = System.Data.Entity.EntityState.Modified;
                hld_context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteTicket(int input)
        {
            var x = (from y in hld_context.Ticket_s where y.ID == input select y).FirstOrDefault();
            hld_context.Ticket_s.Remove(x);
            hld_context.SaveChanges();
        }
    }
}
