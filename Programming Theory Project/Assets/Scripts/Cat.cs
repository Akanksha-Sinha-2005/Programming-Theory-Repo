using UnityEngine;
public class Cat : Animal
{
    void Start() { animalName = "Cat"; }
    public override void MakeSound()
    {
        Debug.Log("Meow!");
        PlaySound();
    }
}