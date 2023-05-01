using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchSpawner : MonoBehaviour
{
    [SerializeField] GameObject itemPrefab;
    float spawn_cooldown = 15f;
    
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
            SpawnItem();
            time_until_spawn = spawn_cooldown;
        }
    }

    public void SpawnItem(){
        GameObject newItem = Instantiate(itemPrefab);
        if (Random.Range(0f, 1f) < 0.5)
        {
            // Spawn on top
            newItem.transform.position = new Vector3(Random.Range(-5.5f,6.5f), Random.Range(4.5f,4.5f), newItem.transform.position.z);
        } else {
            // Spawn on bottom
            newItem.transform.position = new Vector3(Random.Range(-3.5f,4.5f), Random.Range(-4.5f,-4.5f), newItem.transform.position.z);
        }

        newItem.transform.SetParent(gameObject.transform);
    }
}
