
namespace ZooSimulator
{
    internal class Elephant : Animal
    {
        public bool canWalk = true;

        protected override float MinHealth { get; }

        //override method to implement logic
        public override void Feed(int food)
        {
            //using existing implemention from base class
            base.Feed(food);

            //added logic
            if (!canWalk && isAlive)
            {
                canWalk = true;
            }
        }

        //override method to implement same logic, but with some changes
        public override void Energy(int energy)
        {
            health -= (energy / health * 100);

            if (canWalk)
            {
                if(health < MinHealth)
                {
                    canWalk = false;
                }
            }
            else
            {
                isAlive = false;
                health = 0;
            }
        }

        public Elephant(int id) : base(id)
        {
            MinHealth = 70; //assigning custom value for elephant object
        }
    }
}
