using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ZooSimulator
{
    public partial class ZooSimulation : Form
    {
        private System.Windows.Forms.Timer t;
        private int hours;
        private List<Elephant> elephants;
        private List<Giraffe> giraffes;
        private List<Monkey> monkeys;

        public ZooSimulation()
        {
            InitializeComponent();

            hours = 0;
            CreateAnimals(); //creates animals upon initialisation

            //create a timer with time interval of 20 seconds
            t = new System.Windows.Forms.Timer();
            t.Interval = 20000;
            t.Enabled = true;
      
            t.Tick += new EventHandler(OnTick); //create event handler to facilitate event action
        }

        //creates the Animals
        private void CreateAnimals()
        {
            elephants = new List<Elephant>(); //creates the elephant list

            for(int i = 1; i < 6; i++)
            {
                elephants.Add(new Elephant(i)); //add each object instance
            }

            giraffes = new List<Giraffe>(); //creates the giraffe list

            for (int i = 1; i < 6; i++)
            {
                giraffes.Add(new Giraffe(i));
            }

            monkeys = new List<Monkey>(); //creates the monkey list

            for (int i = 1; i < 6; i++)
            {
                monkeys.Add(new Monkey(i));
            }

            LoadText(); //updates the text, adds the corresponding text to each text box field
        }

        //loads text onto the windows form application
        private void LoadText()
        {
            //update time label accordingly
            timeElapsedLabel.Text = $"Time spent: {hours} hour{(hours > 1 ? "s" : "")}";

            //the text boxes begin with empty strings
            elephantTextBox.Text = "";
            giraffeTextBox.Text = "";
            monkeyTextBox.Text = "";

            //for each element in the collection, show the related contents
            foreach (Elephant el in elephants)
            {
                elephantTextBox.Text += $"Elephant id: {el.animalId}  | Health: { String.Format("{0:0.0}", el.health) } | Alive: {el.isAlive} | Can Walk: {el.canWalk}{Environment.NewLine}";
            }

            foreach (Giraffe gi in giraffes)
            {
                giraffeTextBox.Text += $"Giraffe id: {gi.animalId}  | Health: { String.Format("{0:0.0}", gi.health) } | Alive: {gi.isAlive}{Environment.NewLine}";
            }

            foreach (Monkey mo in monkeys)
            {
                monkeyTextBox.Text += $"Monkey id: {mo.animalId}  | Health: { String.Format("{0:0.0}", mo.health) } | Alive: {mo.isAlive}{Environment.NewLine}";
            }
        }

        //recreating the simulation from initial state
        private void resetButton_Click(object sender, EventArgs e)
        {
            hours = 0;
            CreateAnimals();
        }

        //feeds the animals
        private void feedButton_Click(object sender, EventArgs e)
        {
            //using the lambda operator, we create a delegate making it quick and easy to access the property
            if (elephants.Count(el => el.isAlive) > 0)
            {
                Random elRand = new Random(); //creating a way to generate random numbers
                int food = elRand.Next(10, 25); //generate the next pseudorandom number within the range 10-25

                foreach (Elephant elephant in elephants.Where(el => el.isAlive))
                {
                    elephant.Feed(food);
                }
            }

            if (giraffes.Count(gi => gi.isAlive) > 0)
            {
                Random giRand = new Random();
                int food = giRand.Next(10, 25);

                foreach (Giraffe giraffe in giraffes.Where(gi => gi.isAlive))
                {
                    giraffe.Feed(food);
                }
            }

            if (monkeys.Count(mo => mo.isAlive) > 0)
            {
                Random moRand = new Random();
                int food = moRand.Next(10, 25);

                foreach (Monkey monkey in monkeys.Where(mo => mo.isAlive))
                {
                    monkey.Feed(food);
                }
            }
            LoadText();
        }

        //energy levels by the hour
        private void OnTick(object sender, EventArgs e)
        {
            hours++;
            Random rand = new Random(); //creating a way to generate random numbers

            //using the lambda operator, we create a delegate making it quick and easy to access the property
            foreach (Elephant el in elephants.Where(el => el.isAlive))
            {
                el.Energy(rand.Next(0, 20)); //generate the next pseudorandom number within the range 0-20
            }

            foreach (Giraffe gi in giraffes.Where(gi => gi.isAlive))
            {
                gi.Energy(rand.Next(0, 20));
            }

            foreach (Monkey mo in monkeys.Where(mo => mo.isAlive))
            {
                mo.Energy(rand.Next(0, 20));
            }

            LoadText();         
        }
    }
}