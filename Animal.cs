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

    public virtual void eat (string food) {
      Console.WriteLine("Currently eating {0}", food);
    }

    public virtual void eat (string food, int time) {
      Console.WriteLine("Currently eating {0}, and will be for {1} minutes", food, time);
    }

    // public string _food {
    //   get { return _food; }
    //   set {
    //     if (value != "") {
    //       _food = value;
    //     }
    //   }
    // }
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

    public override void eat (string food) {
      if (food == "meat" || food == "beans") {
        base.eat(food);
      } else {
        Console.WriteLine("A Tiger can't eat that though.");
      }
    } 

    public override void eat (string food, int time) {
      if (food == "meat" || food == "beans") {
        base.eat(food, time);
      } else {
        Console.WriteLine("A Tiger can't eat that though.");
      }
    } 

    public Tiger (int clawsNum) {
      claws = clawsNum;
    }
}

Tiger jeff = new Tiger(18);
// jeff.claws = 18;
jeff.stripePattern = "Orange and Black";

Console.WriteLine("Jeff is a tiger with {0} claws and {1} stripes", jeff.claws, jeff.stripePattern);
// example of or overwritten method
jeff.eat("meat", 15);

Animal jerry = new Animal();
jerry.eat("cereal", 5);
