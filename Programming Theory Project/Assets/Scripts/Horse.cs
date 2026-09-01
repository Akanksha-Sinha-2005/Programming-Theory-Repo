using UnityEngine;

// INHERITANCE
public class Horse : Animal
{
    void Start() { animalName = "Horse"; }
    public override void MakeSound()
    {
        Debug.Log("Neigh! I'm a Horse");
        PlaySound();
    }
    protected override void DisplayInfo()
    {
        Debug.Log($"This is {animalName}, a {animalColor} horse with {hungerLevel} hunger");
    }
}