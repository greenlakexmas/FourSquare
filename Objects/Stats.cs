namespace GreenlakeChristmas.FourSquare.Objects
{
    /// <summary>
    /// Contains checkinsCount (total checkins ever here),  
    /// usersCount (total users who have ever checked in here), 
    /// and tipCount (number of tips here).
    /// </summary>
    public class Stats : FSBase
    {
        public Stats(object dict)
            : base(dict)
        {
            if (this.GetDouble("checkinsCount").HasValue)
            {
                this.TotalCheckins = this.GetDouble("checkinsCount").Value;
            }
            if (this.GetDouble("usersCount").HasValue)
            {
                this.TotalUsers = this.GetDouble("usersCount").Value;
            }
            if (this.GetDouble("tipCount").HasValue)
            {
                this.TotalTips = this.GetDouble("tipCount").Value;
            }
        }

        public double TotalCheckins { get; protected set; }
        public double TotalUsers { get; protected set; }
        public double TotalTips { get; protected set; }
    }
}