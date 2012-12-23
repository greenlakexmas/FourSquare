namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Category : FSBase
    {
        public Category(object dict)
            : base(dict)
        {
            this.Id = this.GetString("id");
            this.Name = this.GetString("name");
            this.PluralName = this.GetString("pluralName");
            this.ShortName = this.GetString("shortName");
            this.Icon = this.GetString("icon");
            if (this.GetBool("primary").HasValue)
            {
                this.Primary = this.GetBool("primary").Value;
            }
        }

        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public string PluralName { get; protected set; }
        public string ShortName { get; protected set; }
        public string Icon { get; protected set; }
        public bool Primary { get; protected set; }
    }
}