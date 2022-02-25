using System;
using System.Collections.Generic;

namespace Numbers.Models
{

  public class Translate
  {
    private static Dictionary<char, string> singleDigits = new Dictionary<char, string>() {
      {'0', ""},
      {'1', "one"},
      {'2', "two"},
      {'3', "three"},
      {'4', "four"},
      {'5', "five"},
      {'6', "six"},
      {'7', "seven"},
      {'8', "eight"},
      {'9', "nine"}
    };

    private static Dictionary<char, string> teenDigits = new Dictionary<char, string>() {
      {'0', "ten"},
      {'1', "eleven"},
      {'2', "twelve"},
      {'3', "thirteen"},
      {'4', "fourteen"},
      {'5', "fifteen"},
      {'6', "sixteen"},
      {'7', "seventeen"},
      {'8', "eighteen"},
      {'9', "nineteen"}
    };

    private static Dictionary<char, string> doubleDigits = new Dictionary<char, string>() {
      {'2', "twenty"},
      {'3', "thirty"},
      {'4', "forty"},
      {'5', "fifty"},
      {'6', "sixty"},
      {'7', "seventy"},
      {'8', "eighty"},
      {'9', "ninety"}
    };

    private static Dictionary<int, string> endWords = new Dictionary<int, string>() {
      {0, ""},
      {1, "thousand"},
      {2, "million"},
      {3, "billion"},
      {4, "trillion"}
    };




    public static string NumberTranslator(long inputNumber)
    {
      string inputString = inputNumber.ToString();
      // return singleDigits[inputString[0]];
      // List<string> setsOfNumbers = new List<string>();
      string output = "";
      string stringOfNumbers = "";

      // for (int outsideVal = 0; outsideVal < ourList.Length; outsideVal++)
      // {
      // for (int x = 2; x >= 0; x--)
      // {
      // 3,475,445
      // 003, 475, 445
      // 588

      for (int i = 0; i < inputString.Length; i++)
      { //i = 0
        if ((inputString.Length - i - 1) % 3 != 0)
        {
          stringOfNumbers += inputString[i];      //3
        }
        else if (i != inputString.Length - 1)
        {
          stringOfNumbers += inputString[i] + ",";
        }
        else
        {
          stringOfNumbers += inputString[i];
        }
      }

      string[] groupedNumbers = stringOfNumbers.Split(",");  //007,123,578,765>.

      if (groupedNumbers[0].Length == 2)
      {
        groupedNumbers[0] = "0" + groupedNumbers[0];
      }
      else if (groupedNumbers[0].Length == 1)
      {
        groupedNumbers[0] = "00" + groupedNumbers[0];
      }

      int count = 0;
      for (int i = groupedNumbers.Length - 1; i >= 0; i--) //007,123,578,765>.
      {
        string iteration = "";
        if (int.Parse(groupedNumbers[count]) < 10)
        {
          iteration += singleDigits[groupedNumbers[count][2]];
        }
        else if (int.Parse(groupedNumbers[count]) < 20)
        {
          iteration += teenDigits[groupedNumbers[count][2]];
        }
        else if (int.Parse(groupedNumbers[count]) < 100)
        { //88  --->  088  
          iteration += doubleDigits[groupedNumbers[count][1]] + " " + singleDigits[groupedNumbers[count][2]];
        }
        else if (int.Parse(groupedNumbers[count]) < 1000)
        {
          iteration += singleDigits[groupedNumbers[count][0]];

          if (groupedNumbers[count][0] != '0')
          {
            iteration += " hundred ";
          }

          iteration += doubleDigits[groupedNumbers[count][1]] + " " + singleDigits[groupedNumbers[count][2]];
        }


        count++;
        if (count != groupedNumbers.Length)
        {
          iteration += " " + endWords[i];
          output += iteration + ", ";
        }
        else
        {
          iteration += endWords[i];
          output += iteration;
        }
      }
      // }   7,123,456,890
      ////[007,123,456,890] - grouped numbers
      //sevenbillion, one hundred twenty threemillion, four hundred fifty sixthousand, eight hundred ninety 
      // }

      return output;

      // 3 % inputString.length;  -- 2 = 1

      // if (inputString[1] != '1') // 3 4---> 4 3
      // {
      //   output = doubleDigits[inputString[1]] + singleDigits[inputString[0]];
      // }
      // else if (inputString[1] == '1')
      // {
      //   output =
      // }
    }

  }
}