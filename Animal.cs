// Base class
class Animal {
    // Simple properties
    public double speed { get; set; }
    public string species { get; set; }
    public string AnimalName { get; set; }
    public int legs { get; set; }


    // Public method that can be redefined by derived classes
    public virtual void walk () {
        Console.WriteLine("Animal class walk method");
        speed = speed + (0.1 * legs);
    }
}

// Derived class
class Lizard : Animal {
    // Adding additional properties to what is inherited from Animal
    public string scaleColor { get; set; }
    public bool camouflage { get; set; }
    public bool Wild { get; set; }

    // Redefining the base class implementation
    public override void walk () {
        Console.WriteLine("Lizard class walk method");
        speed = speed + (0.2 * legs);
    }
}

class Species : Animal {
    public string speciesName { get; set; }
    public string noise { get; set; }
}

// Specific Animal Classes
class Giraffe : Species {
    public string spotPattern { get; set; }
    public int horns { get; set; }
}

class Tiger : Species {
    public string stripePattern { get; set; }
    public int claws { get; set; }
}

Tiger jeff = new Tiger();
jeff.claws = 18;
jeff.stripePattern = "Orange and Black";

Console.WriteLine("Jeff is a tiger with {0} claws and {1} stripes", jeff.claws, jeff.stripePattern);


// Create a Lizard
Lizard larry = new Lizard();
// larry.legs = 4;
// larry.scaleColor = "Brown";
// larry.camouflage = false;
// larry.walk();

Console.WriteLine("A {0} lizard moving at {1} m/s", larry.scaleColor, larry.speed);

// Create an Animal
Animal andy = new Animal();
andy.legs = 4;
andy.walk();

Console.WriteLine("An animal moving at {0} m/s", andy.speed);