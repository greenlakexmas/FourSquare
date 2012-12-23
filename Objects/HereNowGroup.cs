using System.Collections.Generic;
using System.Linq;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class HereNowGroup : Group
    {
        public HereNowGroup(object dict)
            : base(dict)
        {
            object[] groupitems = this.GetArray("items");
            this.Checkins = groupitems.Select(item => new Checkin(item)).ToArray();
        }

        public Checkin[] Checkins { get; protected set; }
    }
}