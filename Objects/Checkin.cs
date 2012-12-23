using System;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Checkin : FSBase
    {
        public Checkin(object dict)
            : base(dict)
        {
            this.Id = this.GetString("id");
            double ca = Convert.ToDouble(this.Dictionary["createdAt"]);
            this.CreatedAt = Extensions.FromUnixTime((long)ca);

            string checkintype = this.GetString("type").ToLower();
            this.CheckinType = (CheckinType)Enum.Parse(typeof(CheckinType), checkintype);

            this.Shout = this.GetString("shout");
            this.TimeZone = this.GetString("timeZone");

            object user = this.GetObject("user");
            if (user != null)
            {
                this.User = new User(user);
            }
        }

        public string Id { get; set; }
        public DateTime CreatedAt { get; protected set; }
        public CheckinType CheckinType { get; protected set; }
        public string Shout { get; set; }
        public string TimeZone { get; protected set; }
        public User User { get; protected set; }
    }
}