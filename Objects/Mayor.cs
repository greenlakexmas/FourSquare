namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Mayor : FSBase
    {
        public Mayor(object dict)
            : base(dict)
        {
            object user = this.GetObject("user");
            if (user != null)
            {
                this.User = new User(user);
            }
            if (this.GetInt("count").HasValue)
            {
                this.Count = this.GetInt("count").Value;
            }
        }

        public User User { get; protected set; }
        public int Count { get; protected set; }
    }
}