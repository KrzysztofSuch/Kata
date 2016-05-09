using System;
using System.Collections.Generic;

public class TripleTrouble
{
    public static int TripleDouble(long num1, long num2)
    {

        var num1String = num1.ToString();

        for(int i = 1; i < num1String.Length-1; i++)
        {
            if (num1String[i - 1] == num1String[i] && num1String[i] == num1String[i+1])
            {
                if (isDoubleCharInString(num1String[i],num2.ToString()))
                    return 1;
            }
        }


        return 0;
        //code me ^^
    }

    private static Boolean isDoubleCharInString(Char searcherChar, String targetedString)
    {
        for(int i = 1; i < targetedString.Length; i++)
        {
            if (targetedString[i] == searcherChar && targetedString[i] == targetedString[i - 1])
            {
                return true;
            }
        }

        return false;
    }
}