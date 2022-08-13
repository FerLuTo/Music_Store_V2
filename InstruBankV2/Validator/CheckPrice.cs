using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace InstruBankV2.Validator
{
    public class CheckPrice:ValidationAttribute
    {
        public CheckPrice()
        {
            ErrorMessage = "El precio debe ser mayor a 0";
        }

        public override bool IsValid(object value)
        {
            decimal precio = Convert.ToDecimal(value);
            if(precio>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
