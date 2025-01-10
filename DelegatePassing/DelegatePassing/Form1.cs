using System;
using System.Windows.Forms;

namespace DelegatePassing
{
    delegate void DoSomething(ref double data);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetToZero(ref double data)
        {
            data = 0;
        }

        private void MakeTwice(ref double data)
        {
            data *= 2;
        }

        private void CutInHalf(ref double data)
        {
            data /= 2;
        }

        private void ShowResult(ref double myvalue, DoSomething MyMethod)
        {
            // Perform the action on the data.
            MyMethod(ref myvalue);

            // Display the data
            MessageBox.Show(myvalue.ToString());
        }
        private void newResult(ref double myvalue, DoSomething MyMethod)
        {
            // Perform the action on the data.
            MyMethod(ref myvalue);

            // Display the data
            MessageBox.Show("Updated function result is: " + myvalue.ToString());
        }
        private void demoButton_Click(object sender, EventArgs e)
        {
            // A value to work with
            double value = 100.0;

            // Create a delegate to reference MakeTwice.
            DoSomething operation = MakeTwice;

            // Pass value and the delegate to ShowResult.
            ShowResult(ref value, operation);
            
            // Make the delegate reference the CutInHalf method.
            operation = CutInHalf;

            // Pass value and the delegate to ShowResult.
            ShowResult(ref value, operation);

            value = 500.0;
            ShowResult(ref value, operation);
            // Make the delegate reference the SetToZero method.
            operation = SetToZero;
            
            // Pass value and the delegate to ShowResult.
            ShowResult(ref value, operation);

           
        }
    }
}
