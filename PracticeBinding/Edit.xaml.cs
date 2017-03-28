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
    /// Updating a users information
    /// </summary>
    public partial class Edit : Window {
        public delegate void RemoveMember();
        public event RemoveMember RemoveMemberFromUpdateWindow;
        public Edit() {
            InitializeComponent();
        }

        /// <summary>
        /// this is called from the main window and a user is passed
        /// </summary>
        /// <param name="data">a user object</param>
        public Edit(object data): this() {
            //bind to name
            this.DataContext = data;
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e) {
            //this binds to the textboxes and get the information to send back to the main window.
            //this only works with updatetrigger being set to explicit
            BindingExpression be = user.GetBindingExpression(TextBox.TextProperty);
            BindingExpression be2 = userlast.GetBindingExpression(TextBox.TextProperty);
            BindingExpression be3 = useremail.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
            be2.UpdateSource();
            be3.UpdateSource();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e) { this.Close();}

        private void Button_Click_Delete(object sender, RoutedEventArgs e) {
            RemoveMemberFromUpdateWindow();
            this.Close();
        }
    }
}
