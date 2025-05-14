using UnityEngine;

/// <summary>
/// Abstract base class that hides low?level movement / audio logic
/// from callers (ABSTRACTION) and protects data via properties
/// (ENCAPSULATION will be fleshed out later).
/// </summary>
public abstract class Animal : MonoBehaviour
{
    // ——— Encapsulated field (we’ll expose it with a property later) ———
    [SerializeField] private float speed = 3f;

    /// <summary>
    /// Gets the current movement speed in units/second.
    /// Setter is protected so only child classes can change it.
    /// </summary>
    public float Speed
    {
        get => speed;
        protected set => speed = Mathf.Max(0, value);
    }

    // ——— High?level behaviours (ABSTRACTION) ———
    public abstract void Move();      // to be overridden by each species
    public abstract void MakeSound(); // same here
}
