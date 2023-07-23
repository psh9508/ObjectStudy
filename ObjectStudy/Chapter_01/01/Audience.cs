using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStudy.Chapter_01._01
{
    public class Audience
    {
        private Bag _bag;

        public Audience(Bag bag)
        {
            _bag = bag;
        }

        public Bag GetBag()
        {
            return _bag;
        }
    }
}
