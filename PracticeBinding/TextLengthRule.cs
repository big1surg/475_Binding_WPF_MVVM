using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PracticeBinding {
    /// <summary>
    /// this is a rule for the textbox for the binding values
    /// </summary>
    public class TextLengthRule : ValidationRule {
        //cant be empty and cant be greater than 25
        private int _max;
        private int _emailCheck; //if its one then its an email

        public int Max {
            get { return _max; }
            set { _max = value;}
        }

        public int EmailCheck {
            get { return _emailCheck; }
            set { _emailCheck = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo) {
            string val = "";

            try {
                if (((string)value).Length > 0 && ((string)value).Length <=25)
                    val = (string)value;
            } catch (Exception e) {
                return new ValidationResult(false, "Length is not appropriate " + e.Message);
            }

            //if length is greater than max dont save
            if (val.Length==0 || val.Length >= Max) {
                return new ValidationResult(false, "Must be less than " + Max + " characters");
            } else {
                //if its an email address then pass one
                if (_emailCheck == 1) {
                    //check if email address has @ symbol
                    if (!val.Contains("@")) {
                        return new ValidationResult(false, "Wrong format for email");
                    } else {
                        return new ValidationResult(true, null);
                    }
                } else {
                    return new ValidationResult(true, null);
                }
            }


        }
    }
}
