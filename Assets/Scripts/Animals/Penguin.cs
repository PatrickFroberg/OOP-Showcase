using UnityEngine;

public class Penguin : Animal
{
    public override void Move()
    {
        // Simple waddle: step forward then sway left/right
        float sway = Mathf.Sin(Time.time * 3f) * 40f; // degrees

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        transform.localRotation = Quaternion.Euler(0, sway, 0);
    }

    public override void MakeSound()
    {
        SoundHelper.Play("Squawk");
    }
}
