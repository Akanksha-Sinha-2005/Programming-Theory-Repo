using UnityEngine;
public class Dog : Animal
{
    void Start() { animalName = "Dog"; }
    public override void MakeSound()
    {
        Debug.Log("Woof! Woof!");
        PlaySound();
    }
    public override void Feed()
    {
        base.Feed();
        Debug.Log("Dog wags tail!");
    }
}