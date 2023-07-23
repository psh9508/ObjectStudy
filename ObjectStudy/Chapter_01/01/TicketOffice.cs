using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStudy.Chapter_01._01
{
    public class TicketOffice
    {
        private long _amount;
        private List<Ticket> _tickets = new List<Ticket>()
        {
            // 책엔 없지만 테스트를 위해 추가
            new Ticket(id: 110110, fee: 7700), // 7,700원 짜리 티켓한장
        };

        public Ticket GetTicket()
        {
            var firstElement = _tickets[0];
            _tickets.RemoveAt(0);

            return firstElement;
        }

        public void MinusAmount(long amount)
        {
            _amount -= amount;
        }

        public void PlusAmount(long amount)
        {
            _amount += amount;
        }

        // 책엔 없지만 테스트를 위해 추가
        public long GetAmount()
        {
            return _amount;
        }
    }
}
