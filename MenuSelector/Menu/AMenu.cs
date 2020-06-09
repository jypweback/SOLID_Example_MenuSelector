namespace MenuSelector.Menu
{
    public abstract class AMenu
    {
        public string MenuName { get; set; }

        public int Price { get; set; }

        public string Format {
            get
            {
                return "메뉴명: {0}, 가격: {1}";
            }
        }

        public abstract string Explain();
    }
}
