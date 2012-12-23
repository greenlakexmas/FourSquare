using System;

namespace GreenlakeChristmas.FourSquare.Objects
{
    /// <summary>
    /// id	A unique string identifier for this photo.
    /// createdAt	Seconds since epoch when this photo was created.
    /// url	The url for the original uploaded file.
    /// 
    /// sizes	 The count of supported sizes, plus items, an array of supported sizes. 
    /// Each size will have a string url and integer width and  height parameters. The first 
    /// item will be the original photo size, and the remaining items will be derived photo sizes. 
    /// Just because a derived photo size (with url) is returned does not mean it is necessarily 
    /// available at that url.
    /// 
    /// source	optional If present, the name and url for the application that created this photo.
    /// user	optional If the user is not clear from context, then a compact user is present.
    /// venue	optional If the venue is not clear from context, then a compact venue is present.
    /// tip	optional If the tip is not clear from context, then a compact tip is present.
    /// checkin	optional If the checkin is not clear from context, then a compact checkin is present
    /// </summary>
    public class Photo : FSBase
    {
        public Photo(object dict)
            : base(dict)
        {
            this.Id = this.GetString("id");
            double ca = Convert.ToDouble(this.Dictionary["createdAt"]);
            this.CreatedAt = Extensions.FromUnixTime((long)ca);
            object user = this.GetObject("user");
            if (user != null)
            {
                this.User = new User(user);
            }

            this.Url = this.GetString("url");

            object checkin = this.GetObject("checkin");
            if (checkin != null)
            {
                this.Checkin = new Checkin(checkin);
            }

        }

        public string Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public string Url { get; protected set; }
        public User User { get; protected set; }
        public Checkin Checkin { get; protected set; }
    }
}