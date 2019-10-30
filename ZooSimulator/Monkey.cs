
namespace ZooSimulator
{
    internal class Monkey : Animal
    {
        //overriding for the purpose of assigning specific property value
        protected override float MinHealth { get; }

        public Monkey(int id) : base(id)
        {
            MinHealth = 30; //assigning custom value for monkey object
        }
    }
}
