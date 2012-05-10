using System;
using System.Collections.Generic;
using System.Linq;
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


namespace BuildCalculator_Offline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BuildCalculatorService.BuildCalculatorService service;

        public MainWindow()
        {
            service = new BuildCalculatorService.BuildCalculatorService();

            InitializeComponent();
            PopulateLists();

        }

        private void PopulateLists()
        {
            champsCB.DataContext = service.GetChampions();
            itemsCB.DataContext = service.GetItems();
        }
    }
}
