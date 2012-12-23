using System.Collections.Generic;
using System.Linq;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class PhotoGroup : Group
    {
        public PhotoGroup(object dict)
            : base(dict)
        {
            object[] items = this.GetArray("items");
            this.Photos = items.Select(item => new Photo(item)).ToArray();
        }

        public Photo[] Photos { get; protected set; }
    }
}