using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            //Canvas myCanvas = new Canvas()
            //{
            //    Width = 800,
            //    Height = 400
            //};

            Button myButton = new Button(){ 
                Content = "Kilép",
                Margin = new Thickness(160, 0, 0, 0),
            };

            Label myLabel = new Label()
            {
                Content = "Ez egy címke",
                BorderBrush = Brushes.Red,
                BorderThickness = new Thickness(2),
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(50)
            };

        myCanvas.Children.Add(myLabel);
        myCanvas.Children.Add(myButton);
        }
    }
}
