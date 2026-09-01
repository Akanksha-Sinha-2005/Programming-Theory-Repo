using UnityEngine;

// ABSTRACTION
public abstract class Animal : MonoBehaviour
{
    [SerializeField] protected string animalName = "Animal";
    [SerializeField] protected string animalColor = "Brown";
    // ENCAPSULATION
    [SerializeField] protected int hungerLevel = 50;

    [Header("Sound")]
    public AudioClip animalSoundClip;
    protected AudioSource audioSource;

    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    // POLYMORPHISM
    public abstract void MakeSound();

    protected virtual void DisplayInfo()
    {
        Debug.Log($"This is {animalName}, a {animalColor} animal with {hungerLevel} hunger");
    }

    public virtual void Feed()
    {
        hungerLevel -= 10;
        if (hungerLevel < 0) hungerLevel = 0;
        DisplayInfo();
    }

    protected void PlaySound()
    {
        if (animalSoundClip != null && audioSource != null)
        {
            audioSource.PlayOneShot(animalSoundClip);
        }
    }
}