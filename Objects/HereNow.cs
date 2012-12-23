using System.Linq;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class HereNow : FSBase
    {
        public HereNow(object dict)
            : base(dict)
        {
            if (this.GetInt("count").HasValue)
            {
                this.Count = this.GetInt("count").Value;
            }
            this.Summary = this.GetString("summary");
            object[] groups = this.GetArray("groups");
            this.HereNowGroups = groups.Select(g => new HereNowGroup(g)).ToArray();
        }

        public int Count { get; protected set; }
        public string Summary { get; protected set; }
        public HereNowGroup[] HereNowGroups { get; protected set; }
    }
}