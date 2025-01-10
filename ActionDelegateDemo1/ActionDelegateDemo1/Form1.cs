using System;
using System.Windows.Forms;

namespace ActionDelegateDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            // Create an Action delegate.
            Action DisplayTest = () => MessageBox.Show("Testing, 1, 2, 3…");

            // Invoke the delegate.
            DisplayTest();
        }
    }
}
