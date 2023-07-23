using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStudy.Chapter_01._01
{
    public class TicketSeller
    {
        private TicketOffice _ticketOffice;

        public TicketSeller(TicketOffice ticketOffice)
        {
            _ticketOffice = ticketOffice;
        }

        public TicketOffice GetTicketOffice()
        {
            return _ticketOffice;
        }
    }
}
