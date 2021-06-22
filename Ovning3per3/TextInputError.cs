using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3per3
{
    public class TextInputError : UserError
    {
        public TextInputError() { }

        public override string UEMessage() => "You tried to use a text input in a numericonly field. This fired an error!";

    }
}
