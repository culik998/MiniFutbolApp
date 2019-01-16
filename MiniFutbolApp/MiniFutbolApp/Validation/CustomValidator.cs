using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFutbolApp.Validation
{
   public static class CustomValidator
    {
        public static Tuple<bool,List<ValidationResult>> isValid<T>(this Form form,T item)
        {
            List<ValidationResult> list = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(item);
            bool isValid = Validator.TryValidateObject(item, context, list, true);
            return Tuple.Create(isValid, list);
        }
    }
}
