using System;
using System.Collections;
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

namespace ArraylistApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arraylist;
        public MainWindow()
        {
            InitializeComponent();
            arraylist = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Show Data
            foreach (string data in arraylist)
            {
                MessageBox.Show(data);
            }
        }
        private void Add_click(object sender, RoutedEventArgs e)
        {
            //Add Data
            arraylist.Add(txtData.Text);
            MessageBox.Show("Add completed");
            
        }

        private void Remove_click(object sender, RoutedEventArgs e)
        {
            //Remove Data
            arraylist.Remove(txtData.Text);
            MessageBox.Show("Remove completed");
            
        }
    }
        
}

