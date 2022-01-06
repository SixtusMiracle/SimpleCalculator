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
    double currentValue;
    double answer = 0;
    bool operationIsCalled = false;

    enum Operation { Add, Subtract, Multiply, Divide, Equals, Start };
    Operation currentOp = Operation.Start;

    public MainWindow()
    {
      InitializeComponent();
      txtOut.Text = currentValue.ToString();
    }

    private void BtnEntry_Click(object sender, RoutedEventArgs e)
    {
      int value;

      // get value entered by user
      Button btn = (Button)sender;
      String valueEntered = btn.Content.ToString();

      if (operationIsCalled)
      {
        if (txtOut.Text.Equals("0."))
        {
          txtOut.Text = "0.";
        }
        else
        {
          txtOut.Text = "0";
        }
      }

      // converting it to int if it is an int
      if (Int32.TryParse(valueEntered, out value))
      {
        if (txtOut.Text.Contains("."))
        {
          txtOut.Text += valueEntered;
          currentValue = Double.Parse(txtOut.Text);
        }
        else
        {
          if (txtOut.Text == "0")
          {
            txtOut.Text = valueEntered;
          }
          else
          {
            txtOut.Text += valueEntered;
          }
          // txtOut.Text = txtOut.Text == "0" ? txtOut.Text = valueEntered : txtOut.Text += valueEntered;
          currentValue = Double.Parse(txtOut.Text);
        }
      }
      else if (valueEntered.Equals("."))
      {
        if (txtOut.Text.Contains("."))
        {
          return;
        }
        else
        {
          txtOut.Text += valueEntered;
        }
      }
    }

    // 4 event handlers for operations:
    private void BtnAdd_Click(object sender, RoutedEventArgs e)
    {
      answer += currentValue;
      txtOut.Text = answer.ToString();
      operationIsCalled = true;
      currentOp = Operation.Add;
    }

    private void BtnSubtract_Click(object sender, RoutedEventArgs e)
    {
      if (currentOp == Operation.Start)
      {
        answer += currentValue;
        operationIsCalled = true;
        currentOp = Operation.Subtract;
      }
      else
      {
        answer -= currentValue;
        txtOut.Text = answer.ToString();
        operationIsCalled = true;
        currentOp = Operation.Subtract;
      }
    }

    private void BtnMultiply_Click(object sender, RoutedEventArgs e)
    {
      if (currentOp == Operation.Start)
      {
        answer += currentValue;
        operationIsCalled = true;
        currentOp = Operation.Multiply;
      }
      else
      {
        answer *= currentValue;
        txtOut.Text = answer.ToString();
        operationIsCalled = true;
        currentOp = Operation.Multiply;
      }
    }

    private void BtnDivide_Click(object sender, RoutedEventArgs e)
    {
      if (currentOp == Operation.Start)
      {
        answer += currentValue;
        operationIsCalled = true;
        currentOp = Operation.Divide;
      }
      else
      {
        answer /= currentValue;
        txtOut.Text = answer.ToString();
        operationIsCalled = true;
        currentOp = Operation.Divide;
      }
    }

    //Clear the current results
    private void BtnClear_Click(object sender, RoutedEventArgs e)
    {
      currentValue = 0;
      answer = 0;
      operationIsCalled = false;
      currentOp = Operation.Start;
      txtOut.Text = currentValue.ToString();
    }

    //Handle the Equals button
    private void BtnEquals_Click(object sender, RoutedEventArgs e)
    {
      switch (currentOp)
      {
        case Operation.Add:
          answer += currentValue;
          txtOut.Text = answer.ToString();
          break;
        case Operation.Subtract:
          answer -= currentValue;
          txtOut.Text = answer.ToString();
          break;
        case Operation.Multiply:
          answer *= currentValue;
          txtOut.Text = answer.ToString();
          break;
        case Operation.Divide:
          answer /= currentValue;
          txtOut.Text = answer.ToString();
          break;
      }

      operationIsCalled = true;
      currentValue = 0;
      currentOp = Operation.Start;
    }
  }
}
