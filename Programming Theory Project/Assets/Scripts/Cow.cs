using UnityEngine;

public class Cow : Animal
{
    void Start() { animalName = "Cow"; }

    public override void MakeSound()
    {
        Debug.Log("Moo!");
    }
}