using System;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Group : FSBase
    {
        public Group(object dict)
            : base(dict)
        {
            string grouptype = this.GetString("type").ToLower();
            this.GroupType = (GroupType) Enum.Parse(typeof (GroupType), grouptype);
            this.Name = this.GetString("name");
            if (this.GetInt("count").HasValue)
            {
                this.Count = this.GetInt("count").Value;
            }
        }

        public GroupType GroupType { get; protected set; }
        public string Name { get; protected set; }
        public double Count { get; protected set; }
    }
}