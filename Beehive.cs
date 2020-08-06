using System.Collections.Generic;

namespace Bee_Keeping
{
  public class Beehive
  {
    Bee bee;
    public int maxAmountOfBees;
    public Bee[] bees;
    public Beehive(Bee[] bees, int maxAmountOfBees)
    {
      this.bees = bees;
      this.maxAmountOfBees = maxAmountOfBees;
    }

    public float collectHoney(int days)
    {

      float amount = days * bee.size * 0.2f;
      return amount;
    }
  }
}