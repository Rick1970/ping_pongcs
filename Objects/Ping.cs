using System;
using System.Collections.Generic;

namespace PingPong.Objects
{
  public class Ping
  {
    private int _inputNumber;
    private static List<Ping>_instances = new List<Ping> {};


  public Ping (int newNumber)
  {
    _inputNumber = newNumber;
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
}
}
