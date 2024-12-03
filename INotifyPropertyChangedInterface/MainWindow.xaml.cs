using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace INotifyPropertyChangedInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Summe SummeObjekt { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            // damit sagt man das der DatenKontext unsere 'MainWindow' das 'SummeObjekt' ist. 
            SummeObjekt = new Summe { Nummer1= "1", Nummer2="3" };
            this.DataContext = SummeObjekt;
        }

    }
}