using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per3
{
    public class NumericInputError: UserError
    {
        public NumericInputError() { }

        public override string UEMessage() => "You tried to use a numeric input in a text only field.This fired an error!";
      
    }
}
