using System;

namespace GreenlakeChristmas.FourSquare.Objects
{
    /// <summary>
    ///user	optional If the context allows tips from multiple users, the compact user that created this tip.
    ///venue	optional If the context allows tips from multiple venues, the compact venue for this tip.
    /// </summary>
    public class Tip : FSBase
    {
        public Tip(object dict)
            : base(dict)
        {
            this.Id = this.GetString("id");
            this.Text = this.GetString("text");
            double ca = Convert.ToDouble(this.Dictionary["createdAt"]);
            this.CreatedAt = Extensions.FromUnixTime((long)ca);
            this.Status = this.GetString("status");
            this.Photo = this.GetString("photo");
            object user = this.GetObject("user");
            if (user != null)
            {
                this.User = new User(user);
            }
        }

        public string Id { get; protected set; }
        public string Text { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public string Status { get; protected set; }
        public string Url { get; protected set; }
        public string Photo { get; protected set; }
        public User User { get; protected set; }
    }
}