# Programming Theory Project - OOP Animal Interaction

**Unity Learn - Junior Programmer Pathway**

This project demonstrates the 4 principles of Object-Oriented Programming (OOP) in Unity using an animal interaction system.

### GitHub Repo
https://github.com/Akanksha-Sinha-2005/Programming-Theory-Repo

---

### 1. OOP Pillars Implemented

**1. Inheritance:**
`Animal.cs` is the base abstract class. `Dog.cs`, `Cat.cs`, and `Horse.cs` inherit from Animal.

**2. Polymorphism:**
Each animal overrides `MakeSound()` and `Feed()` methods. Same method call, different behavior:
- Dog: "Woof Woof!"
- Cat: "Meow Meow!"
- Horse: "Neigh Neigh!"

**3. Encapsulation:**
- `hungerLevel` is private with public property `HungerLevel`
- `animalName` is protected, accessed via public property `AnimalName`
- UI buttons only call public methods, internal logic stays hidden

**4. Abstraction:**
Base class `Animal` defines abstract methods `MakeSound()` and `Feed()`. Child classes must implement them, hiding complex details.

---

### 2. How To Play

1.  Open scene: `Main Scene`
2.  Press Play
3.  Click on any button(Bark, Meow or Neigh):
    - Left Click: Animal makes sound
    - Feed Button (UI): Feeds reduces hunger

---

### 3. Scripts Overview

| Script | Role | OOP Concept |
| :--- | :--- | :--- |
| Animal.cs | Base abstract class | Abstraction, Encapsulation |
| Dog.cs | Child class | Inheritance, Polymorphism |
| Cat.cs | Child class | Inheritance, Polymorphism |
| Horse.cs | Child class | Inheritance, Polymorphism |
| GameManager.cs | Handles selection & UI | Singleton pattern |

---

**Created By:** Akanksha Sinha
**Course:** Unity Junior Programmer - Programming Theory
**Date:** September 2026
