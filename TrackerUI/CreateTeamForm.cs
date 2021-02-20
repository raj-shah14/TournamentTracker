using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary.Configs;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel(
                    firstNameText.Text,
                    lastNameText.Text,
                    emailText.Text,
                    cellText.Text);

                GlobalConfig.Connection.CreatePerson(person);

                firstNameText.Text = "";
                lastNameText.Text = "";
                emailText.Text = "";
                cellText.Text = "";
                MessageBox.Show("The values have been added!");
            }
            else
            {
                MessageBox.Show("This is an Invalid Form");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            if (firstNameText.Text == null || lastNameText.Text == null || emailText.Text == null )
            {
                output = false;
            }
            if (!emailText.Text.Contains("@"))
            {
                output = false;
            }

            return output;
        }
    }
}
