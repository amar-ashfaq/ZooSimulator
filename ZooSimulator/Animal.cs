
namespace ZooSimulator
{
    //abstract class implemented to anticipate objects of different behaviours
    abstract class Animal
    {
        public int animalId { get; } //getter method to protect against data mutation

        protected readonly float maxHealth = 100; //essentially a variable that will not change
        protected internal float health;
        protected internal bool isAlive = true;

        //Animal class constructor
        public Animal(int id)
        {
            animalId = id; //sets an int id
            health = maxHealth; //all created animals begin with max health
        }

        //a virtual method so we can redefine in derived classes
        protected virtual float MinHealth { get; }

        //a bit of bad practice making this public in exchange for good code resuse
        //feeds the animals accordingly
        public virtual void Feed(int food)
        {
            health += (food / health * 100); //increased health as a percentage

            if(health > maxHealth)
            {
                health = maxHealth;
            }
        }

        //a bit of bad practice making this public in exchange for good code resuse
        //energy level of an animal
        public virtual void Energy(int energy)
        {
            health -= (energy / health * 100); //decreased health as a percentage

            if (health < MinHealth)
            {
                isAlive = false;
                health = 0; //animal health set to 0 once no longer alive
            }
        }
    }
}