using System;
namespace Invent_Fashion_Library
{
    public class InventFashion
    {
       static public double calculateHST(double subTotal)
        {
            double tax = subTotal * 0.13;
            return tax;
        }

        static public double totalAmount(double subTotal)
        {
            double tax = subTotal * 0.13;
            return subTotal + tax;
        }

        static public String sizeCalculator(double size)
        {
            String alphabetSize = "Sorry Enter valid size between 36 to 50";
            if (size >= 36 && size < 38) {
                alphabetSize = "XXS";
                return alphabetSize;
            }

            if (size >= 38 && size < 40)
            {
                alphabetSize = "XS";
                return alphabetSize;
            }

            if (size >= 40 && size < 42)
            {
                alphabetSize = "S";
                return alphabetSize;
            }

            if (size >= 42 && size < 44)
            {
                alphabetSize = "M";
                return alphabetSize;
            }

            if (size >= 44 && size < 46)
            {
                alphabetSize = "L";
                return alphabetSize;
            }

            if (size >= 46 && size < 48)
            {
                alphabetSize = "XL";
                return alphabetSize;
            }

            if (size >= 48 && size <= 50)
            {
                alphabetSize = "XXL";
                return alphabetSize;
            }

            return alphabetSize;
        }
    }
}
