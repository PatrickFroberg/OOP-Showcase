using UnityEngine;

public class Lion : Animal
{
    [SerializeField] private float turnRate = 45f;   // degrees/second

    public override void Move()
    {
        // Walk forward while slowly turning
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        transform.Rotate(Vector3.up, turnRate * Time.deltaTime);
    }

    public override void MakeSound()
    {
        // Lion’s roar
        SoundHelper.Play("Roar");   // overload that takes a clip?name string
    }
}
