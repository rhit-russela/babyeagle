using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// public class GameManager : MonoBehaviour
public class GameManager : Singleton<GameManager>
{

    GameObject _player;

    [SerializeField] GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _player = Instantiate(playerPrefab);  
        EventBus.Subscribe(EventBus.EventType.EndGame, EndGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (_player == null)
        {
            _player = Instantiate(playerPrefab);
        }
    }

    void EndGame()
    {
        Debug.Log("Ending Game...");
        SceneManager.LoadScene("EndGameScene");
        Destroy(_player);
        CleanupListeners();
    }

    void CleanupListeners()
    {
        EventBus.Unsubscribe(EventBus.EventType.EndGame, EndGame);
    }

    public GameObject GetPlayer()
    {
        return _player;
    }
}
