using System;
using System.Collections.Generic;

namespace PingPong.Objects
{
  public class Ping
  {
    private string _inputNumber;
    private static List<Ping>_instances = new List<Ping> {};

    public Ping (string number)
    {
      _inputNumber = number;
    }
    public string GetNumber()
    {
      return _inputNumber;
    }
    public void SetNumber(string finalNumber)
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
    public bool Calculate()
    {
      return false;
    }
  }
}
