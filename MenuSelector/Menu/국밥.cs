namespace MenuSelector.Menu
{
    public class 국밥 : AMenu
    {
        public 국밥()
        {
            MenuName = "국밥";
            Price = 5000;
        }

        public override string Explain()
        {
            return string.Format(Format, MenuName, Price);
        }
    }
}
