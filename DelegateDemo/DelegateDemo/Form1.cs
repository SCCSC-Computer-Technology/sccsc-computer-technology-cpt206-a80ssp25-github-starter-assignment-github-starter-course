using System;
using System.Windows.Forms;

namespace DelegateDemo
{
    delegate void MyDelegate(string str);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            // Assign the DisplayMessage method to a delegate.
            MyDelegate Display = DisplayMessage;

            // Use the delegate to call the method.
            Display("Hello World");
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
