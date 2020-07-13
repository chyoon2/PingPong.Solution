using System;
using System.Collections.Generic;
using Game.Models;

namespace Game
{
public class Program
{
  public static void Main()
  {
    
    Console.WriteLine("Enter a number:");
    string stringUserNumber = Console.ReadLine();
    int userNumber = int.Parse(stringUserNumber);
    PingNumber userPingNumber = new PingNumber(userNumber);
    List<string> userList = new List<string> {};
    userList = userPingNumber.GetNumberList();
    for (int i = 0; i < userList.Count; i++)
    {
      Console.WriteLine(userList[i]);
    }
  }
}
}