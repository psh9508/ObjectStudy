using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStudy.Chapter_01._01
{
    public class Ticket
    {
        // 책엔 없지만 테스트를 위해 추가
        public long _id;
        private long _fee;

        // 책엔 없지만 테스트를 위해 추가
        public Ticket(long id, long fee)
        {
            _id = id;
            _fee = fee;
        }

        public long GetFee()
        {
            return _fee;
        }
    }
}
