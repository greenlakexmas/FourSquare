using System.Collections.Generic;
using System.Linq;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Photos : FSBase
    {
        public Photos(object dict)
            : base(dict)
        {
            if (this.GetDouble("count").HasValue)
            {
                this.Count = this.GetDouble("count").Value;
            }
            this.Summary = this.GetString("summary");
            object[] photogroups = this.GetArray("groups");
            this.PhotoGroups = photogroups.Select(photogroup => new PhotoGroup(photogroup)).ToArray();
        }

        public double Count { get; protected set; }
        public string Summary { get; protected set; }
        public PhotoGroup[] PhotoGroups { get; protected set; }
    }
}