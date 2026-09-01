using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void FeedAllAnimals()
    {
        Animal[] animals = FindObjectsOfType<Animal>();
        foreach (Animal animal in animals)
        {
            animal.Feed();
        }
        Debug.Log("All animals fed!");
    }
}