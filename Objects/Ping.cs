using System;
using System.Collections.Generic;

namespace PingPong.Objects
{
  public class Ping
  {
    private int _inputNumber;
    private static List<Ping>_instances = new List<Ping> {};

    public Ping (int number)
    {
      _inputNumber = number;
    }
    public int GetNumber()
    {
      return _inputNumber;
    }
    public void SetNumber(int finalNumber)
    {
      _inputNumber = finalNumber;
    }
    public static List<Ping> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void DeleteAll()
    {
      _instances.Clear();
    }
    public string Calculate()
    {
      if(_inputNumber % 15 == 0)
      {
        return "ping-pong";
      }
      else if (_inputNumber % 5 == 0)
      {
        return "pong";
      }
      else if (_inputNumber % 3 == 0)
      {
        return "ping";
      }
      else {
        return _inputNumber.ToString();
      }
    }
  }
}
