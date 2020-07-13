using System;
using System.Collections.Generic;

namespace Game.Models
{
  public class PingNumber
  {
    private int _userNumber;

    public PingNumber(int userInput)
    {
      _userNumber = userInput;
    }
    // string count = {};
    public List<string> GetNumberList ()
    {
      List<string> outputList = new List<string> {};
      for (int i = _userNumber; i > 0; i--)
      {
        outputList.Add(CheckNumber(i));
      }
      return outputList;
    }

    private string CheckNumber(int number)
    {
      if (number % 3 == 0 && number % 5 == 0)
      {
        return "ping-pong";
      }
      else if (number % 3 == 0)
      {
        return "ping";
      }
      else if (number % 5 == 0)
      {
        return "pong";
      }
      else
      {
        return number.ToString();
      }
    }
  }
}