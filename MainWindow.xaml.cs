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

namespace SimpleCalculator
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    double currentValue = 0;
    enum Operation { Add, Subtract, Multiply, Divide, Equals, Start };

    public MainWindow()
    {
      InitializeComponent();
      txtOut.Text = currentValue.ToString();
    }

    private void BtnEntry_Click(object sender, RoutedEventArgs e)
    {
    }

    private void Calculate(Operation op)
    {
    }

    // 4 event handlers for operations:
    private void BtnAdd_Click(object sender, RoutedEventArgs e)
    {
    }

    private void BtnSubtract_Click(object sender, RoutedEventArgs e)
    {
    }

    private void BtnMultiply_Click(object sender, RoutedEventArgs e)
    {
    }

    private void BtnDivide_Click(object sender, RoutedEventArgs e)
    {
    }

    //Clear the current results
    private void BtnClear_Click(object sender, RoutedEventArgs e)
    {
    }

    //Handle the Equals button
    private void BtnEquals_Click(object sender, RoutedEventArgs e)
    {
    }
  }
}
