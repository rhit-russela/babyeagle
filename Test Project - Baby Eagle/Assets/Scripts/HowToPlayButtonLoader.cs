using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayButtonLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickLoad()
    {
        EventBus.Publish(EventBus.EventType.StartTutorial);
    }
}
