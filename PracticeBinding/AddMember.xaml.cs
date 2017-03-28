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
using System.Windows.Shapes;

namespace PracticeBinding {
    /// <summary>
    /// Simple implementatin of the add member window
    /// </summary>
    public partial class AddMember : Window {
        /// <summary>
        /// deledagte for sending a user back to the main window
        /// </summary>
        /// <param name="s"> first name </param>
        /// <param name="f"> last name</param>
        /// <param name="e"> email</param>
        public delegate void SendMemberEventHandler(string s, string f, string e);
        public event SendMemberEventHandler AddNewMemberToList;
        public string firstName, lastName, email;

        public AddMember() {
            InitializeComponent();
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e) {
            //validate that the information is correct
            if (Validator.IsPresent(FirstNameTextBox, LastNameTextBox, EmailTextBox) && Validator.IsValidEmail(EmailTextBox)
                && Validator.IsLessThan(FirstNameTextBox, LastNameTextBox, EmailTextBox, 25)) {
                this.firstName = FirstNameTextBox.Text;
                this.lastName = LastNameTextBox.Text;
                this.email = EmailTextBox.Text;
                AddNewMemberToList(firstName, lastName, email);
                this.Close();
            }
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
