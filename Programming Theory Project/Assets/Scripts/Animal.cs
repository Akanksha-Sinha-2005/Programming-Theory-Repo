using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // ENCAPSULATION - private field with public property
    private float hunger = 50f;
    public float Hunger
    {
        get { return hunger; }
        set { hunger = Mathf.Clamp(value, 0, 100); }
    }

    public string animalName;

    // ABSTRACTION - abstract method
    public abstract void MakeSound();

    public virtual void Feed()
    {
        Hunger -= 20f;
        Debug.Log(animalName + " was fed. Hunger: " + Hunger);
    }
}