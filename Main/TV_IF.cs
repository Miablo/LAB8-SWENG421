using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public interface TV_IF
    {

        // “+getInfo()” method of the returned TV object to invoke all of its get??? methods.
        // The get??? methods include one “~getPrice(): int” to return the MSRP,
        // and a “~getType(): String” method to know the type (Regular, Smart, or UltraHD)
        public void getInfo();


    }
}
