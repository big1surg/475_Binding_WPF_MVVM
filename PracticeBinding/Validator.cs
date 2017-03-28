using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PracticeBinding {
    class Validator {
        private static string title = "Entry Error";

        public static string Title {
            get {
                return title;
            }
            set {
                title = value;
            }
        }

        public static bool IsPresent(TextBox textBox) {
            if (textBox.Text == "") {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //overload for 3 args, checks that there is text
        public static bool IsPresent(TextBox one, TextBox two, TextBox three) {
            if (one.Text == "" || two.Text == "" || three.Text == "") {
                if (one.Text == "") {
                    MessageBox.Show(one.Tag + " is a required field.", Title);
                    one.Focus();
                } else if (two.Text == "") {
                    MessageBox.Show(two.Tag + " is a required field.", Title);
                    two.Focus();
                } else {
                    MessageBox.Show(three.Tag + " is a required field.", Title);
                    three.Focus();
                }
                return false;
            }
            return true;
        }

        //check for string
        public static bool IsPresent(string one, string two, string three) {
            if (one == "" || two == "" || three == "") {
                if (one == "") {
                    MessageBox.Show(one + " is a required field.", Title);
                    //one.Focus();
                } else if (two == "") {
                    MessageBox.Show(two + " is a required field.", Title);
                    //two.Focus();
                } else {
                    MessageBox.Show(three + " is a required field.", Title);
                    //three.Focus();
                }
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox) {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number)) {
                return true;
            } else {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox) {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number)) {
                return true;
            } else {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max) {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max) {
                MessageBox.Show(textBox.Tag + " must be between " + min
                + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        //check that each textbox is less than 25 characters
        public static bool IsLessThan(TextBox one, TextBox two, TextBox three, int max) {
            if (one.Text.Length > max || two.Text.Length > max || three.Text.Length > max) {
                if (one.Text.Length> max) {
                    MessageBox.Show(one.Tag + " must be less than " + max, Title);
                    one.Focus();
                } else if (two.Text.Length > max) {
                    MessageBox.Show(two.Tag + " must be less than " + max, Title);
                    two.Focus();
                } else {
                    MessageBox.Show(three.Tag + " must be less than " + max, Title);
                    three.Focus();
                }
                return false;

            }
            return true;
        }

        //check value of string
        public static bool IsLessThan(string one, string two,string three, int max) {
            if (one.Length > max || two.Length > max || three.Length > max) {
                if (one.Length > max) {
                    MessageBox.Show(one + " must be less than " + max, Title);
                    //one.Focus();
                } else if (two.Length > max) {
                    MessageBox.Show(two + " must be less than " + max, Title);
                    //two.Focus();
                } else {
                    MessageBox.Show(three + " must be less than " + max, Title);
                    //three.Focus();
                }
                return false;

            }
            return true;
        }


        public static bool IsValidEmail(TextBox textBox) {
            if (textBox.Text.IndexOf("@") == -1 ||
            textBox.Text.IndexOf(".") == -1) {
                MessageBox.Show(textBox.Tag + " must be a valid email address.",
                Title);
                textBox.Focus();
                return false;
            } else {
                return true;
            }
        }

        //string
        public static bool IsValidEmail(string textBox) {
            if (textBox.IndexOf("@") == -1 || textBox.IndexOf(".") == -1) {
                MessageBox.Show(textBox + " must be a valid email address.", Title);
                //textBox.Focus();
                return false;
            } else {
                return true;
            }
        }
    }
}
