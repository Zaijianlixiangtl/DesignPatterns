namespace DesignPatterns.Model.bridge
{
    public class RedColor : Color
    {
        public override string Colour { get { return "Red"; } }
    }

    public class BlackColor : Color
    {
        public override string Colour { get { return "Black"; } }
    }
}
