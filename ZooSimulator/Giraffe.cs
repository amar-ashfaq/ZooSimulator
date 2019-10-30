
namespace ZooSimulator
{
    internal class Giraffe : Animal
    {
        //overriding for the purpose of assigning specific property value
        protected override float MinHealth { get; }

        public Giraffe(int id) : base(id)
        {
            MinHealth = 50; //assigning custom value for giraffe object
        }
    }
}