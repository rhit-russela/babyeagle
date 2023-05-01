using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchFunction : MonoBehaviour
{

    
    private float time_until_destroy = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         time_until_destroy -= Time.deltaTime;
        if (time_until_destroy < 0)
        {
            Destroy(gameObject);
            time_until_destroy = 5f;
        }
    }

    private void OnMouseDown()
    {
        EventBus.Publish(EventBus.EventType.TimerUpdate);
        Destroy(gameObject);
    }
}
