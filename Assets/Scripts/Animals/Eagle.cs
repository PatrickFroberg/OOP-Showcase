using UnityEngine;

public class Eagle : Animal
{
    [SerializeField] private float altitude = 5f;

    public override void Move()
    {
        // Circle in the sky at a fixed altitude
        float radius = 4f;
        float angle = Time.time * Speed;
        Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
        transform.position = new Vector3(pos.x, altitude, pos.z);
        transform.LookAt(Vector3.zero + Vector3.up * altitude);
    }

    public override void MakeSound()
    {
        SoundHelper.Play("Screech");
    }
}
