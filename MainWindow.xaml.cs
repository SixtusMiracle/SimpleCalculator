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

    public double CurrentValue { get => currentValue; set => currentValue = value; }

    enum Operation { Add, Subtract, Multiply, Divide, Equals, Start };

    public MainWindow()
    {
      InitializeComponent();
      txtOut.Text = CurrentValue.ToString();
    }

    private void BtnEntry_Click(object sender, RoutedEventArgs e)
    {
      int value;

      // get value entered by user
      Button btn = (Button)sender;
      String valueEntered = btn.Content.ToString();

      // converting it to int if it is an int
      if (Int32.TryParse(valueEntered, out value))
      {
        if (txtOut.Text.Equals("0"))
        {
          txtOut.Text = valueEntered;
        }
        else
        {
          txtOut.Text += valueEntered;
        }
      }
      else if (valueEntered.Equals("."))
      {
        if (txtOut.Text.Contains("."))
        {
          return;
        }
        else { txtOut.Text += valueEntered; }
      }
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
      CurrentValue = 0;
      txtOut.Text = CurrentValue.ToString();
    }

    //Handle the Equals button
    private void BtnEquals_Click(object sender, RoutedEventArgs e)
    {
      
    }
  }
}
