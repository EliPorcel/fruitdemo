using fruitdemo.Models;

namespace fruitdemo
{
    public partial class MainPage : ContentPage
    {
        public List<FruitInformation> PapayaInfo { get; set; }

        public MainPage()
        {
            InitializeComponent();
            PapayaInfo = new List<FruitInformation>
            {
                new FruitInformation
                {
                    Micronutrient = "Vitamina C",
                    Percentage = 10
                },
                new FruitInformation
                {
                    Micronutrient = "Vitamina A",
                    Percentage = 19
                },
                new FruitInformation
                {
                    Micronutrient = "Calcio",
                    Percentage = 2
                },
                new FruitInformation
                {
                    Micronutrient = "Magnesio",
                    Percentage = 5
                },
                new FruitInformation
                {
                    Micronutrient = "Potasio",
                    Percentage = 5
                }
            };
            this.BindingContext = this;
        }
    }
}
