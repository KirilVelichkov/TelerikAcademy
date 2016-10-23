# 1. Singleton
* The Singleton class is a class that is supposed to have only one (single) instance
    * Access window manager / file system / console
    * Access global application logger / DC / Mapper
* Sometimes Singleton is wrongly thought of as a global variable – it is not!
* Possible problems:
    * Lazy loading (created when first needed)
    * Thread-safe
      
> Code Example
```CSharp
public sealed class SingletonThreadSafe {
    private static volatile SingletonThreadSafe instance;
    private static object syncLock = new object();
    private SingletonThreadSafe() { }
    public static SingletonThreadSafe Instance {
        get {
            if (instance == null) {
                lock (syncLock) {
                    if (instance == null) {
                       instance = new SingletonThreadSafe();
                    }
                }
            }
            return instance;
        }
    }
}
```
> Diagram
![alt text](http://www.codeproject.com/KB/cpp/singletonrvs/Singleton_RVS_src.jpg)

# 2. Simple Factory
* Encapsulates object creation logic
    * If we are making specific class selection logic changes, we make them in one place
    * We can hide complex object creation
* This is not a real Pattern
    * This is the preparation for the real Pattern
* It is used quite often
* Each time we add new type we need to modify the simple factory code

> Code Example
```CSharp
public Coffee GetCoffee(CoffeeType coffeeType)
{
    // Can also be implemented using dictionary
    switch (coffeeType)
    {
        case CoffeeType.Regular:
            // Can be subtype of Coffee
            return new Coffee(0, 150);
        case CoffeeType.Double:
            return new Coffee(0, 200);
        case CoffeeType.Cappuccino:
            return new Coffee(100, 100);
        case CoffeeType.Macchiato:
            return new Coffee(200, 100);
        default:
            throw new ArgumentException();
    }
}
```
> Diagram
![alt text](https://upload.wikimedia.org/wikipedia/commons/thumb/5/54/Abstract_Factory_in_LePUS3_vector.svg/2000px-Abstract_Factory_in_LePUS3_vector.svg.png)

# 3. Abstract Factory
* Abstraction in object creation
    * Create a family of related objects
* The Abstract Factory Pattern defines interface for creating sets of linked objects
    * Without knowing their concrete classes
* Used in systems that are frequently changed
* Provides flexiblemechanism forreplacement ofdifferent sets

> Code Example
```CSharp
abstract class ContinentFactory { // AbstractFactory
   public abstract Herbivore CreateHerbivore();
   public abstract Carnivore CreateCarnivore();
}
class AfricaFactory : ContinentFactory {
   public override Herbivore CreateHerbivore() {
      return new Wildebeest();
   }
   public override Carnivore CreateCarnivore() {
      return new Lion(); // Constructor can be internal
   }
}
class AmericaFactory : ContinentFactory {
    public override Herbivore CreateHerbivore() {
        return new Bison();
    }
    public override Carnivore CreateCarnivore() {
        return new Wolf();
    }
}
```
> Diagram
![alt text](http://www.bogotobogo.com/DesignPatterns/images/abstfactorymethod/Abstract_Factory_design_pattern.png)
