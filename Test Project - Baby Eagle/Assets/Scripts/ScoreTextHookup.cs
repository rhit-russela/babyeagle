using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTextHookup : MonoBehaviour
{
    GameManager _gm;
    // Start is called before the first frame update
    void Start()
    {
        _gm = FindObjectOfType<GameManager>();
        EventBus.Subscribe(EventBus.EventType.KillsUpdate, updateZombieScore);
        EventBus.Subscribe(EventBus.EventType.WonGame, cleanListeners);
        EventBus.Subscribe(EventBus.EventType.LostGame, cleanListeners);
    }

    // Update is called once per frame
    void Update()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        text.text = "Score: " + _gm.currentScore.ToString();
    }

    void updateZombieScore()
    {
        _gm.currentScore = _gm.currentScore + 100;
    }

    void cleanListeners()
    {
        EventBus.Unsubscribe(EventBus.EventType.KillsUpdate, updateZombieScore);
        EventBus.Unsubscribe(EventBus.EventType.WonGame, cleanListeners);
        EventBus.Unsubscribe(EventBus.EventType.LostGame, cleanListeners);
    }
}
