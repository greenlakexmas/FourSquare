using System.Collections.Generic;

namespace GreenlakeChristmas.FourSquare.Objects
{
    /// <summary>
    /// An object containing none, some, or all of twitter,  phone, and formattedPhone. All are strings.
    /// </summary>
    public class Contact : FSBase
    {
        public Contact(object dict)
            :base(dict)
        {
            this.Twitter = this.GetString("twitter");
            this.Phone = this.GetString("phone");
            this.FormattedPhone = this.GetString("formattedPhone");
        }

        public string Twitter { get; protected set; }
        public string Phone { get; protected set; }
        public string FormattedPhone { get; protected set; }
    }
}