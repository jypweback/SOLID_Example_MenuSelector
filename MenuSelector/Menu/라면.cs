namespace MenuSelector.Menu
{
    public class 라면 : AMenu
    {
        public 라면()
        {
            MenuName = "라면";
            Price = 3000;
        }

        public override string Explain()
        {
            return string.Format(Format, MenuName, Price);
        }
    }
}
