using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metric_Conversion_Forms
{
  public partial class Form_Backend: Form
  {
    public Form_Backend()
    {
      initializeComponent();
    }

    private void label3_Click(object sender, EventArgs e)
    {}
    private void textBox1_TextChanged(object sender, EventArgs e)
    {}
    private void button1_Click(object sender, EventArgs e)
    {
      double kilometers;
      // Read Input
      miles = Convert.ToDouble(textBox1.Text);
      // Process
      kilometer = 1.609344 * miles;
      // Output
      textBox2.Text = Convert.ToString(kilometers);
    }
    private void button2_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
