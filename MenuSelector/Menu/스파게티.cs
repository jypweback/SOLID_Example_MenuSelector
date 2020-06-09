namespace MenuSelector.Menu
{
    public class 스파게티 : AMenu
    {
        public 스파게티()
        {
            MenuName = "스파게티";
            Price = 2000;
        }

        public override string Explain()
        {
            return string.Format(Format, MenuName, Price);
        }
    }
}
