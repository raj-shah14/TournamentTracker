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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Raj", LastName = "Shah" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Hemi", LastName = "Shah" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Paresh", LastName = "Shah" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Nipa", LastName = "Shah" });
        }

        private void WireUpLists()
        {

            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeamMembers;
            selectTeamDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
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

                person = GlobalConfig.Connection.CreatePerson(person);
                selectedTeamMembers.Add(person);
                WireUpLists();

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

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            var listPersonSelected = teamMembersListBox.SelectedItems;
            if (listPersonSelected.Count > 0)
            {
                foreach (PersonModel p in listPersonSelected)
                {
                    selectedTeamMembers.Remove(p);
                    availableTeamMembers.Add(p);
                }
                WireUpLists();

            }
            else
            {
                MessageBox.Show("Please Select the Name to remove!");
            }
        }
    }
}
