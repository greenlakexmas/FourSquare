namespace GreenlakeChristmas.FourSquare.Objects
{
    public class Tips : FSBase
    {
        public Tips(object dict)
            : base(dict)
        {
        }

        public int Count { get; protected set; }
    }
}