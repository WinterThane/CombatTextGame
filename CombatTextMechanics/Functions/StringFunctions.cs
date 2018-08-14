using System;

namespace CombatTextMechanics.Functions
{
    public static class StringFunctions
    {
        public static int StringToInteger(string input)
        {
            bool convert = Int32.TryParse(input, out int result);
            
            if(convert)
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        public static int IncreaseStat(string input)
        {
            var value = StringToInteger(input);
            value++;
            return value;
        }

        public static int DecreaseStat(string input)
        {
            var value = StringToInteger(input);
            value--;
            return value;
        }
    }
}
