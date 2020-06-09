namespace MenuSelector.Menu
{
    public class 돈까스 : AMenu
    {
        public 돈까스()
        {
            MenuName = "돈까스";
            Price = 4000;
        }

        public override string Explain()
        {
            return string.Format(Format, MenuName, Price);
        }
    }
}
