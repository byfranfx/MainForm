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
    public partial class mainForm1 : Form
    {
        public mainForm1()
        {
            InitializeComponent();
        }

        private void createNewDialogButton_Click(object sender, EventArgs e)
        {

            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Age = int.Parse(AgeTextBox.Text)
            };

            DetailForm detailForm = new DetailForm(person);
            DialogResult result = detailForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                Console.WriteLine("Dialog returned with Ok.");
            }
            else if (result == DialogResult.Cancel)
            {
                Console.WriteLine("Dialog returned with Cancel.");
            }
            else
            {
                Console.WriteLine("Dialog returned " + result);
            }
        }
    }
}
