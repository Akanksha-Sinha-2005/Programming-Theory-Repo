using UnityEngine;

// INHERITANCE - Dog inherits from Animal
public class Dog : Animal
{
    void Start() { animalName = "Dog"; }

    // POLYMORPHISM - overrides MakeSound
    public override void MakeSound()
    {
        Debug.Log("Woof! Woof!");
    }

    public override void Feed()
    {
        base.Feed();
        Debug.Log("Dog wags tail!");
    }
}