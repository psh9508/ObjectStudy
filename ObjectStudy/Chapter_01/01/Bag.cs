using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStudy.Chapter_01._01
{
    public class Bag
    {
        private long _amount;
        private Invitation? _invitation;
        private Ticket? _ticket;

        public Bag(long amount) : this(null, amount)
        {

        }

        public Bag(Invitation? invitation, long amount)
        {
            _invitation = invitation;
            _amount = amount;
        }

        public bool HasInvitation()
        {
            return _invitation is not null;
        }

        public void SetTicket(Ticket ticket)
        {
            _ticket = ticket;
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
        public Ticket? GetTicket()
        {
            return _ticket;
        }

        // 책엔 없지만 테스트를 위해 추가
        public long GetAmount()
        {
            return _amount;
        }
    }
}
