namespace RomanNumeral
{
    public class NumberConverter
    {
        public string ConvertNumberToSymbol(int number)
        {
            if (number == 1)
            { 
                number = "I";
            }

            else if (number == 2)
            {
                number = "II";
            }
            
            else if (number == 3)
            {
                number = "III";
            }
            
            else if (number == 4)
            {
                number = "IV";
            }
            
            else if (number == 5)
            {
                number = "V";
            }
            
            else if (number == 6)
            {
                number = "VI";
            }
            
            else if (number == 7)
            {
                number = "VII";
            }
            
            else if (number == 8)
            {
                number = "VIII";
            }
            
            else if (number == 9)
            {
                number = "IX";
            }
            
            else if (number == 10)
            {
                number = "X";
            }

            return number;
        }
        
    }
}