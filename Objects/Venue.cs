using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Venue : FSBase
    {
        public Venue(object dict)
            :base(dict)
        {
            Dictionary<string, object> current;

            this.Id = this.GetString("id");
            this.Name = this.GetString("name");
            this.Description = this.GetString("description");

            this.Contact = new Contact(this.GetObject("contact"));
            this.Location = new Location(this.GetObject("location"));

            this.Categories = new List<Category>();
            object[] categories = this.GetArray("categories");
            foreach(object category in categories)
            {
                Category cat = new Category(category);
                this.Categories.Add(cat);
            }

            bool? verified = this.GetBool("verified");
            if (verified.HasValue)
            {
                this.Verified = verified.Value;
            }

            this.Stats = new Stats(this.GetObject("stats"));

            double ca = Convert.ToDouble(this.Dictionary["createdAt"]);
            this.CreatedAt = Extensions.FromUnixTime((long)ca);

            this.HereNow = new HereNow(this.GetObject("hereNow"));
            this.Mayor = new Mayor(this.GetObject("mayor"));
            this.Tips = new Tips("tips");

            object[] tags = this.GetArray("tags");
            this.Tags = tags.Select(tag => tag.ToString()).ToArray();

            this.Specials = this.GetString("specials");
            this.Url = this.GetString("url");
            this.ShortUrl = this.GetString("shortUrl");
            this.CanonicalUrl = this.GetString("canonicalUrl");
            this.TimeZone = this.GetString("timeZone");

            object bh = this.Dictionary["beenHere"];
            if (bh is Dictionary<string, object>)
            {
                current = bh as Dictionary<string, object>;
                this.BeenHere = Convert.ToInt32(current["count"]);
            }

            this.Photos = new Photos(this.GetObject("photos"));
            this.Listed = this.Dictionary["listed"];
            this.ToDos = this.Dictionary["todos"];
        }

        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Contact Contact { get; protected set; }
        public Location Location { get; protected set; }
        public List<Category> Categories { get; protected set; }
        public bool Verified { get; protected set; }
        public Stats Stats { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public HereNow HereNow { get; protected set; }
        public Mayor Mayor { get; protected set; }
        public Tips Tips { get; protected set; }
        public string[] Tags { get; protected set; }
        public object Specials { get; protected set; }
        public string Url { get; protected set; }
        public string ShortUrl { get; protected set; }
        public string CanonicalUrl { get; protected set; }
        public string TimeZone { get; protected set; }
        public int BeenHere { get; protected set; }
        public Photos Photos { get; protected set; }
        public object Listed { get; protected set; }
        public object ToDos { get; protected set; }
    }
}