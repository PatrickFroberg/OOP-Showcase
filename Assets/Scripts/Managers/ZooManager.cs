using UnityEngine;

/// <summary>
/// Spawns a set of animal prefabs at startup and then
/// ticks their high‑level behaviour every frame.
/// </summary>
public class ZooManager : MonoBehaviour
{
    [Header("Prefabs")]
    [Tooltip("List of animal prefabs to instantiate at runtime")]
    public GameObject[] animalPrefabs;

    [Header("Settings")]
    [Tooltip("Number of instances to spawn for EACH prefab")]
    [Range(1, 10)]
    public int instancesPerSpecies = 1;

    private Animal[] animals;   //runtime array built in Awake()

    private void Awake()
    {
        //Build a temporary list so we can figure out array length
        var list = new System.Collections.Generic.List<Animal>();

        foreach (GameObject prefab in animalPrefabs)
        {
            for (int i = 0; i < instancesPerSpecies; i++)
            {
                Vector3 pos = Random.insideUnitCircle * 5f;   //simple scatter
                var go = Instantiate(prefab, new Vector3(pos.x, prefab.transform.position.y, pos.y), Quaternion.identity);
                go.name = $"{prefab.name}_{i + 1}";
                
                list.Add(go.GetComponent<Animal>());
            }
        }

        animals = list.ToArray();
    }

    private void Update()
    {
        if (animals == null || animals.Length == 0) 
            return;

        foreach (Animal a in animals)
        {
            if (a == null) 
                continue;

            a.Move();

            // 0.2 % chance each frame that the animal makes a sound
            if (Random.value < 0.002f)
                a.MakeSound();
        }
    }
}
