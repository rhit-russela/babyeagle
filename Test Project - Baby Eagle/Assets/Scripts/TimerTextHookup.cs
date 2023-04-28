using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerTextHookup : MonoBehaviour
{

    public float timeRemaining = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining - Time.timeSinceLevelLoad > 0){
            TMP_Text text = GetComponent<TMP_Text>();
            text.text = "Time Left: " + (Mathf.Round(timeRemaining - Time.timeSinceLevelLoad)).ToString();
        } else {
            EventBus.Publish(EventBus.EventType.EndGame);
        }
    }
}
