namespace GreenlakeChristmas.FourSquare.Objects
{
    public class User : FSBase
    {
        public User(object dict)
            : base(dict)
        {
            this.Id = this.GetString("id");
            this.FirstName = this.GetString("firstName");
            this.LastName = this.GetString("lastName");
            this.Photo = this.GetString("photo");
            this.Gender = this.GetString("gender");
            this.HomeCity = this.GetString("homeCity");
            this.Relationship = this.GetString("relationship");
        }

        public string Id { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Photo { get; protected set; }
        public string Gender { get; protected set; }
        public string HomeCity { get; protected set; }
        public string Relationship { get; protected set; }

        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
    }
}