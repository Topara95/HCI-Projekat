using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidacijaAjde
{
    public class StringToDoubleValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                double r;
                if (double.TryParse(s, out r))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Please enter a valid double value.");
            }
            catch
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }

    public class MinMaxValidationRule : ValidationRule
    {
        public double Min
        {
            get;
            set;
        }

        public double Max
        {
            get;
            set;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is double)
            {
                var d = (double) value;
                if (d < Min) return new ValidationResult(false, "Cena mora biti veca ili jednaka nuli");
                
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }

    public class MinMaxString : ValidationRule
    {

        public double Mins
        {
            get;
            set;
        }

        public double Maxs
        {
            get;
            set;
        }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value is string)
            {
                var d = (string)value;
                if (d.Length < Mins) {
                    return new ValidationResult(false, "Duzina oznake je prekratka");
                }

                if (d.Length > Maxs) {
                    return new ValidationResult(false, "Duzina oznake je predugacka");
                }

                    return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "Unknown error occured.");
            }
        }
    }
}
