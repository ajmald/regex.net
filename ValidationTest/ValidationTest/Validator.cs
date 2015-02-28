using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ValidationTest
{
    class Validator
    {
        //Any suggestions, contact via Github or email me ajmaldookhan@gmail.com
        private StringBuilder errors;
        private Regex validator;
        
        public Boolean TextValidator(TextBox txtToValidate, string tType, int iMaxLength, String Label, out String messager)
        {
            errors = new StringBuilder();
            validator = new Regex(tType);
              if (!validator.Match(txtToValidate.Text).Success)
            {
                errors.AppendLine(Label + " is not in the proper format.");
                messager = errors.ToString();
                return false;
            }
                

            else if (txtToValidate.Text.Trim().Length > iMaxLength)
            {
                errors.AppendLine(Label + " will Be truncated");
                messager = errors.ToString();
                return false;

            }
            else
            {
                messager = "";
                return true;
            }          

            
        }

    }
}
