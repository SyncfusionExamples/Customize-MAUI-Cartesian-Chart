using System.Collections.ObjectModel;

namespace ChartsCustomization
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class Model
    {
        public string Product { get; set; }
        public double Sales { get; set; }
        public ImageSource Image { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model { Product = "Electronics", Sales = 44, Image = "image.jpg"  },
                new Model { Product = "Hardware", Sales = 38, Image = "image.jpg" },
                new Model { Product = "Furniture", Sales = 35, Image = "image.jpg" },
                new Model { Product = "Accessories", Sales = 29, Image = "image.jpg" },
                new Model { Product = "Food", Sales = 6, Image = "image.jpg" }
            };
        }
    }
}