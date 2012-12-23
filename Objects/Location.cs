namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Location: FSBase
    {
        public Location(object dict)
            : base(dict)
        {
            this.Address = this.GetString("address");
            this.CrossStreet = this.GetString("crossStreet");
            this.City = this.GetString("city");
            if (this.GetDouble("lat").HasValue)
            {
                this.Latitude = this.GetDouble("lat").Value;
            }
            if (this.GetDouble("lng").HasValue)
            {
                this.Longitude = this.GetDouble("lng").Value;
            }
            this.PostalCode = this.GetString("postalCode");
            this.State = this.GetString("state");
        }

        public string Address { get; protected set; }
        public string CrossStreet { get; protected set; }
        public double Latitude { get; protected set; }
        public double Longitude { get; protected set; }
        public string City { get; protected set; }
        public string PostalCode { get; protected set; }
        public string State { get; protected set; }
    }
}