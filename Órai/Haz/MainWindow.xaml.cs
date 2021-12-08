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

namespace Haz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Haz(100, 100);
        }

        /// <summary>
        /// Megrajzoljuk a házat
        /// </summary>
        /// <param name="x">A házat befoglaló téglalap bal felső sarkának az x paramétere</param>        
        /// <param name="y">A házat befoglaló téglalap bal felső sarkának az y paramétere</param>
        /// 
        public void Haz(double x, double y)
        {
            double tetoMagassag = 30;

            // A ház épületének definiálása
            Rectangle rcHaz = new Rectangle()
            {
                Width = 110,
                Height = 80,
                Stroke = Brushes.DarkRed,
                StrokeThickness = 2,
                Fill = Brushes.LightCoral,
            };

            // A ház helyzetének beállítása
            rcHaz.SetValue(Canvas.LeftProperty, (double)100);
            rcHaz.SetValue(Canvas.TopProperty, (double)100 + tetoMagassag);

            // Tető 
            Polygon pgTeto = new Polygon() {
                Stroke = Brushes.Red,
                StrokeThickness = 2,
            };

            pgTeto.Points = new PointCollection();
            pgTeto.Points.Add(new Point(x, y + tetoMagassag));
            pgTeto.Points.Add(new Point(x + rcHaz.Width / 2, y));
            pgTeto.Points.Add(new Point(x + rcHaz.Width, y + tetoMagassag));


            // Elhelyezés a rajzlapon
            cvLap.Children.Add(rcHaz);
            cvLap.Children.Add(pgTeto);
        }
    }
}
