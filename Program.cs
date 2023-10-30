using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int number = 0;
        foreach (int n in ar)
            number += n;
        return number;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> ar = new List<int> { 1, 2, 3, 4, 10, 11 };

        int result = Result.simpleArraySum(ar);

        Console.WriteLine(result);
    }
}
