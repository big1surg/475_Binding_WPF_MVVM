using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBinding {
    /// <summary>
    /// the user class with the new INotifyPropertyChanged. it is implemented from the observable 
    /// collection in the main window class list of users
    /// </summary>
    class User : INotifyPropertyChanged{

        private string name, lastname, email;

        public User() { name = lastname = email = "Default"; }

        public User(string f, string l, string e) {
            name = f;
            lastname = l;
            email = e;
        }
        
        /// <summary>
        /// when the name property is changed it calls the notifyproperty changed method that tells observable collection that something changed
        /// </summary>
        public string Name {
            get { return this.name; }
            set {
                if (this.name != value) {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName) {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public string LastName {
            get { return this.lastname; }
            set {
                if(this.lastname != value) {
                    this.lastname = value;
                    this.NotifyPropertyChanged("LastName");
                }
            }
        }

        public string Email {
            get { return this.email; }
            set {
                if (this.email != value) {
                    this.email = value;
                    this.NotifyPropertyChanged("Email");
                }
            }
        }

        public string AllInfo {
            get { return this.name + " " + this.lastname + " " + this.email; }
        }
    }
}
