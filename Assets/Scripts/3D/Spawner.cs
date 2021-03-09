using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> spawnables;
    
    public float timeToSpawn = 1;
    private float timer = 0;
    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeToSpawn)
        {
            timer = 0;
            Spawn();
        }
    }

    void Spawn()
    {
        int selectRandom = Random.Range(0, spawnables.Count);
        Instantiate(spawnables[selectRandom], transform.position, Quaternion.Euler(RandomRotation()));
    }

    Vector3 RandomRotation()
    {
        return new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
    }
    
}
