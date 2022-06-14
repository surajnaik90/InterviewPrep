/* Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer
(similar to C/C++'s atoi function).

The algorithm for myAtoi(string s) is as follows:

Read in and ignore any leading whitespace.
Check if the next character (if not already at the end of the string) is '-' or '+'. 
Read this character in if it is either. This determines if the final result is negative or positive respectively.
Assume the result is positive if neither is present.

Read in next the characters until the next non-digit character or the end of the input is reached.
The rest of the string is ignored.

Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). 
If no digits were read, then the integer is 0. Change the sign as necessary (from step 2).

If the integer is out of the 32-bit signed integer range [-231, 231 - 1], 
then clamp the integer so that it remains in the range.
Specifically, integers less than -231 should be clamped to -231, and integers greater than 231 - 1 
should be clamped to 231 - 1.

Return the integer as the final result.

Note:

Only the space character ' ' is considered a whitespace character.
Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.

Example:
 
Input: s = "42"
Output: 42

Explanation: The underlined characters are what is read in, the caret is the current reader position.
Step 1: "42" (no characters read because there is no leading whitespace)
         ^
Step 2: "42" (no characters read because there is neither a '-' nor '+')
         ^
Step 3: "42" ("42" is read in)
           ^
The parsed integer is 42.
Since 42 is in the range [-231, 231 - 1], the final result is 42.
*/
public static class StringToIntegerMyAtoi
{
    public static int Approach1(string str)
    {
        int output = 0; bool isPositive = true;
        string res = string.Empty;
        string[] substrs = { }; char[] subchars = { };
        char[] nonDigitChars = { ' ', '.' };

        res = str.TrimStart();

        substrs = res.Split(nonDigitChars);
        foreach (var item in substrs)
        {
            subchars = item.ToCharArray();

            string number = string.Empty, word = string.Empty;

            for (int i = 0; i < subchars.Length; i++) {
                if(subchars[i] <=57 && subchars[i] >=48) {
                    number = string.Concat(number, subchars[i]);

                    if( (i+1) < subchars.Length){
                        if (subchars[i + 1] > 57 || subchars[i] < 48) {
                            break;
                        }
                    }
                }
                else if (subchars[i] == '-') {
                    isPositive = false;
                }
                else { }
            }

            try {
                long temp  = Convert.ToInt64(number);

                if (temp > (Math.Pow(2, 31) -1)) {
                    output = Convert.ToInt32(Math.Pow(2, 31) -1);
                    output = output + 1;
                }
                else if(temp < (Math.Pow(-2, 31))) {
                    output = Convert.ToInt32(Math.Pow(-2, 31));
                }
                else  { output = Convert.ToInt32(temp);}
                
                if(isPositive == false) { 
                    output = -output;
                }
                return output;
            }
            catch (Exception) { return 0;}
        }
        return output;
    }

    public static int Approach2(string str)
    {
        if (string.IsNullOrEmpty(str)) { return 0; }

        int output = 0, pointer = 0; bool isPositive = true;
        string number = string.Empty; char[] chars = { };
        
        chars = str.TrimStart().ToCharArray();
        if(chars.Length ==0) { return 0; }

        if (chars[0] == '-') { 
            isPositive = false; 
            pointer++; 
        }

        else if (chars[0] == '+') { isPositive = true; pointer++; }

        for (int i = pointer; i < chars.Length; i++)
        {
            if (chars[i] >= 48 && chars[i] <= 57) {
                number = String.Concat(number, chars[i]);
            }

            else { break; }
        }

        if(string.IsNullOrEmpty(number)) { return 0; }

        else
        {
            long temp;

            try  {
                temp = Convert.ToInt64(number);

                if (isPositive == false) { temp = -temp; }

                if (temp > (Math.Pow(2, 31) - 1))
                {
                    output = Convert.ToInt32((Math.Pow(2, 31)) - 1);
                }
                else if (temp < (Math.Pow(-2, 31)))
                {
                    output = Convert.ToInt32(Math.Pow(-2, 31));
                }
                else { output = Convert.ToInt32(temp); }

                return output;

            }
            catch (Exception) {

                if (isPositive)
                {
                    output = Convert.ToInt32((Math.Pow(2, 31)) - 1);
                }
                else if (!isPositive)
                {
                    output = Convert.ToInt32(Math.Pow(-2, 31));
                }
                else { }

                return output;
            }
        }
    }
}