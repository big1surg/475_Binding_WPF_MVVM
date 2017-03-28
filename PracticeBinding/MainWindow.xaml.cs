using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PracticeBinding {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
  

        private ObservableCollection<User> users = new ObservableCollection<User>();
        private List<User> textFileUserList = new List<User>(); //textfile with the names
        MembershipData usersInFile = new MembershipData(); //connect to the db

        public MainWindow() {
            InitializeComponent();
            //place the memebers from the textfile in the listbox
            foreach(User user in MembershipData.GetMemberships()) {
                users.Add(user);
            }
            lbUsers.ItemsSource = users;
        }

        public void save() {
            foreach (User m in users) { textFileUserList.Add(m); }
            usersInFile.SaveMemberships(textFileUserList);
        }


        private void btnAddUser_Click(object sender, RoutedEventArgs e) {
            AddMember x = new AddMember();
            x.Show();
            x.AddNewMemberToList += new AddMember.SendMemberEventHandler(this.addMem);
        }

        public void addMem(string f, string l, string e) {
            User m = new User(f, l, e);
            users.Add(m);
        }

        //this method is called when a user is doubleclicked
        private void btnChangeUser_Click(object sender, RoutedEventArgs e) {
            Edit x = new Edit(this.lbUsers.SelectedItem);
            //if a user is deleted this method is called and removes the user from the list
            x.RemoveMemberFromUpdateWindow += new Edit.RemoveMember(this.OnRemoveFromUpdateWindow);
            x.Show();
        }

        public void OnRemoveFromUpdateWindow() { users.Remove(lbUsers.SelectedItem as User); }

        private void btnExit_Click(object sender, RoutedEventArgs e) {
            save();
            this.Close();
        }
    }
}
