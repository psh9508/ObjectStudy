using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStudy.Chapter_01._01
{
    public class Theater
    {
        private TicketSeller _ticketSeller;

        public Theater(TicketSeller ticketSeller)
        {
            _ticketSeller = ticketSeller;
        }

        public void Enter(Audience audience)
        {
            if(audience.GetBag().HasInvitation())
            {
                Ticket ticket = _ticketSeller.GetTicketOffice().GetTicket();
                audience.GetBag().SetTicket(ticket);
            }
            else
            {
                Ticket ticket = _ticketSeller.GetTicketOffice().GetTicket();
                audience.GetBag().MinusAmount(ticket.GetFee());
                _ticketSeller.GetTicketOffice().PlusAmount(ticket.GetFee());
                audience.GetBag().SetTicket(ticket);
            }
        }
    }
}
