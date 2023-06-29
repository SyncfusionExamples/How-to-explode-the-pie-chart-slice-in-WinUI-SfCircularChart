using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using static ExplodeSegmentWinUi1.MainWindow;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ExplodeSegmentWinUi1
{

    public class ViewModel
    {
        public List<Brush> CustomBrushes { get; set; }
        public ObservableCollection<Country> Data { get; set; }
        public ViewModel()
        {
            Data = new ObservableCollection<Country>();
            Data.Add(new Country { Name = "America", GDP = 8 });
            Data.Add(new Country { Name = "Australia", GDP = 6 });
            Data.Add(new Country { Name = "China", GDP = 7 });
            Data.Add(new Country { Name = "England", GDP = 5.2 });
            Data.Add(new Country { Name = "Russia", GDP = 4.8 });
            Data.Add(new Country { Name = "India", GDP = 4 });
            Data.Add(new Country { Name = "Germany", GDP = 3.1 });

        }
    }

    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {

            InitializeComponent();
            
           

        }
        public class Country
        {
            public string Name { get; set; }
            public double GDP { get; set; }
        }


        
    }
}
