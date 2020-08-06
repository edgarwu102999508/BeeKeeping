using System;

namespace Bee_Keeping
{
  class Program
  {
    static void Main(string[] args)
    {
      Bee bee1 = new Bee("John", 3.2f);
      Bee bee2 = new Bee("Paul", 2.7f);
      Bee bee3 = new Bee("George", 1.1f);
      Bee bee4 = new Bee("Ringo", 2.0f);
      Bee bee5 = new Bee("Kurt", 2.3f);
      Bee bee6 = new Bee("Dave", 7.4f);
      Bee bee7 = new Bee("Krist", 1.5f);

      Bee[] bees1 = new Bee[4];
      Bee[] bees2 = new Bee[3];

      bees1[0] = bee1;
      bees1[1] = bee2;
      bees1[2] = bee3;
      bees1[3] = bee4;

      bees2[0] = bee5;
      bees2[1] = bee6;
      bees2[2] = bee7;

      Beehive beehive1 = new Beehive(bees1, 4);
      Beehive beehive2 = new Beehive(bees2, 3);

      System.Console.Write("The number of bees in beehive1: ");
      System.Console.WriteLine(bees1.Length);
      System.Console.Write("The number of bees in beehive2: ");
      System.Console.WriteLine(bees2.Length);
      Console.Read();

      System.Console.WriteLine(beehive1.collectHoney(10));

    }
  }
}
