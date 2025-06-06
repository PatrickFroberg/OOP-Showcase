# OOP‑Showcase
Demonstrate **all four pillars of object‑oriented programming** in a single, easy‑to‑read Unity project while practicing a branch‑per‑feature Git workflow.

## Folder & Class Layout

```text
Assets/
└── Scripts/
    ├── Core/
    │   ├── Animal.cs        ← *abstract* base class (abstraction + encapsulation)
    │   └── SoundHelper.cs   ← static util with overloaded `Play()` (polymorphism)
    │
    ├── Animals/             ← derived classes (inheritance + polymorphism)
    │   ├── Lion.cs
    │   ├── Penguin.cs
    │   └── Eagle.cs
    │
    └── Managers/
        └── ZooManager.cs    ← spawns animals & drives the scene

```

## How Each Pillar Is Covered

| Pillar            | Where it appears                                                                                                                                               | Quick explanation                                                                 |
| ----------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| **Abstraction**   | `Animal.Move()` / `Animal.MakeSound()`                                                                                                                         | Hide low‑level Rigidbody & AudioSource details behind simple, high‑level calls.   |
| **Encapsulation** | Private fields (`speed`, `audioClip`, …) + `public` properties                                                                                                 | Data is kept private; validation or side effects can be added in getters/setters. |
| **Inheritance**   | `Lion : Animal`, `Penguin : Animal`, `Eagle : Animal`                                                                                                          | Children automatically get the base movement/sound framework.                     |
| **Polymorphism**  | 1. **Runtime** – each child **overrides** `Move()`/`MakeSound()`  <br>2. **Compile‑time** – `SoundHelper.Play()` **overloaded** for `string` *and* `AudioClip` | Same interface, many behaviors; same method name, multiple signatures.            |

## Branch Plan

| Branch name             | Purpose                                 | 
| ----------------------- | --------------------------------------- | 
| `feature/abstraction`   | Add `Animal` & `ZooManager` scaffolding | 
| `feature/encapsulation` | Wrap fields in properties               | 
| `feature/inheritance`   | Create `Lion`, `Penguin`, `Eagle`       | 
| `feature/polymorphism`  | Override methods & overload `Play()`    | 
| `develop`               | Integration branch                      | 
| `main`                  | Release‑ready                           | 