using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialog
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(string message)
        {
            InitializeComponent();
            textBox1.AppendText(message + Environment.NewLine);
        }

        public DetailForm(PersonModel personData)
        {
            InitializeComponent();
            textBox1.AppendText($"{ personData.LastName }, { personData.FirstName } is { personData.Age } years old.");
        }
    }
}
