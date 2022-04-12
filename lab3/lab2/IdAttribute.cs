using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class IdAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value is int)
            {
                return true;
            }
            else {
                ErrorMessage = "Неверное значение";
                return false;
            }
        }
    }
}
