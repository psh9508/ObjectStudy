using NuGet.Frameworks;
using System.ComponentModel;

namespace Tests.Chapter_01._01
{
    public class Chapter_01_Tests
    {
        private Audience _초대권_없는_손님;
        private Audience _초대권_있는_손님;
        private TicketOffice _판매처;
        private TicketSeller _판매원;
        private Theater _극장;

        public Chapter_01_Tests()
        {
            _초대권_없는_손님 = new Audience(new Bag(50000)); // 초대권 없이 5만원만 들고있는 손님
            _초대권_있는_손님 = new Audience(new Bag(new Invitation(), 50000)); // 초대권과 5만원을 들고있는 손님

            _판매처 = new TicketOffice();
            _판매원 = new TicketSeller(_판매처);
            _극장 = new Theater(_판매원);
        }

        [Fact]
        [Trait("초대장이 있는 손님", "")]
        public void 손님이_초대장을_갖고있으면_비용추가가_없다()
        {
            _극장.Enter(_초대권_있는_손님);

            // 초대권이 있는 손님이기 때문에 판매처의 금액은 올라가지 않음
            Assert.Equal(0, _판매처.GetAmount());
        }

        [Fact]
        [Trait("초대장이 있는 손님", "")]
        public void 손님이_초대장을_갖고있으면_티켓이_가방에_들어간다()
        {
            _극장.Enter(_초대권_있는_손님);

            // 극장에 있는 티켓이 손님에 가방에 들어있는지 확인
            long expectTicketId = 110110;
            long actualTicketid = _초대권_있는_손님.GetBag().GetTicket()!._id;
            Assert.Equal(expectTicketId, actualTicketid); // 티켓 아이디 확인
            Assert.Equal(7700, _초대권_있는_손님.GetBag().GetTicket()!.GetFee()); // 티켓 가격 확인
        }

        [Fact]
        [Trait("초대장이 없는 손님", "")]
        public void 손님이_초대장을_갖고있지_않으면_티켓이_값이_고객에게_청구된다()
        {
            _극장.Enter(_초대권_없는_손님);

            // 5만원에서 티켓 값 7,700이 빠진 42,300원이 고객의 가방에 있는지 확인
            Assert.Equal(42300, _초대권_없는_손님.GetBag().GetAmount());
        }

        [Fact]
        [Trait("초대장이 없는 손님", "")]
        public void 손님이_초대장을_갖고있지_않으면_티켓이_값이_판매처에_입금된다()
        {
            _극장.Enter(_초대권_없는_손님);

            // 티켓 값 7,700원이 판매처에 입금 되었는지 확인
            Assert.Equal(7700, _판매처.GetAmount());
        }

        [Fact]
        [Trait("초대장이 없는 손님", "")]
        public void 손님이_초대장을_갖고있지_않은채로_입장하면_티켓이_가방에_들어간다()
        {
            _극장.Enter(_초대권_없는_손님);

            // 극장에 있는 티켓이 손님에 가방에 들어있는지 확인
            long expectTicketId = 110110;
            long actualTicketid = _초대권_없는_손님.GetBag().GetTicket()!._id;
            Assert.Equal(expectTicketId, actualTicketid); // 티켓 아이디 확인
            Assert.Equal(7700, _초대권_없는_손님.GetBag().GetTicket()!.GetFee()); // 티켓 가격 확인
        }
    }
}
