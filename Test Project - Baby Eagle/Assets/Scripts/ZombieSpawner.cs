using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField] GameObject zombiePrefab;
    [SerializeField] float spawn_cooldown = 2f;
    private float timeRemaining = 60f;
    private float time_until_spawn;

    // Start is called before the first frame update
    void Start()
    {
        time_until_spawn = spawn_cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        time_until_spawn -= Time.deltaTime;
        if (time_until_spawn < 0)
        {
            SpawnZombie();
            time_until_spawn = spawn_cooldown;
        }
        float timeLeft = Mathf.Round(timeRemaining - Time.timeSinceLevelLoad);
        if (timeLeft < 40 && spawn_cooldown == 2f)
        {
            spawn_cooldown = 1f;
        }
        if(timeLeft < 20 && spawn_cooldown == 1f)
        {
            spawn_cooldown = 0.5f;
        }
    }

    public void SpawnZombie()
    {
        GameObject new_zombie = Instantiate(zombiePrefab);

        if (Random.Range(0f, 1f) < 0.5)
        {
            // Spawn on top
            new_zombie.transform.position = new Vector3(Random.Range(-9.5f,9.5f), Random.Range(5.5f,7.5f), new_zombie.transform.position.z);
        } else {
            // Spawn on bottom
            new_zombie.transform.position = new Vector3(Random.Range(-9.5f,9.5f), Random.Range(-7.5f,-5.5f), new_zombie.transform.position.z);
        }
        
        new_zombie.transform.SetParent(gameObject.transform);
    }
}
