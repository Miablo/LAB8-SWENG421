using System;

namespace Main
{
    public interface TV_IF
    {

        // “+getInfo()” method of the returned TV object to invoke all of its get??? methods.
        // The get??? methods include one “~getPrice(): int” to return the MSRP,
        // and a “~getType(): String” method to know the type (Regular, Smart, or UltraHD)
        public void getInfo();
        public int getPrice();
        public string getType();


    }
}
