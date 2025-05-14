using UnityEngine;

/// <summary>
/// Very small orchestrator that updates all animals every frame.
/// </summary>
public class ZooManager : MonoBehaviour
{
    [Tooltip("Drop all animal instances here in the Inspector")]
    public Animal[] animals;

    private void Update()
    {
        if (animals == null || animals.Length == 0) return;

        foreach (Animal a in animals)
        {
            a.Move();

            // 0.2?% chance each frame that the animal makes a sound
            if (Random.value < 0.002f)
                a.MakeSound();
        }
    }
}
