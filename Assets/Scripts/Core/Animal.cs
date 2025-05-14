using UnityEngine;

/// <summary>
/// Base class shows both ABSTRACTION and ENCAPSULATION.
/// All state is private; access happens only through validated
/// properties or dedicated methods.
/// </summary>
public abstract class Animal : MonoBehaviour
{
    //Movement
    [SerializeField] private float speed = 3f;

    public float Speed
    {
        get => speed;
        protected set => speed = Mathf.Clamp(value, 0f, 10f);
    }

    //Audio
    [SerializeField] private AudioClip callClip;
    public AudioClip CallClip
    {
        get => callClip;
        protected set => callClip = value;
    }
   
    //High level API (Abstraction)
    public abstract void Move();
    public abstract void MakeSound();
}
