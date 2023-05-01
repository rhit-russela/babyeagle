using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

// public class GameManager : MonoBehaviour
public class GameManager : Singleton<GameManager>
{

    GameObject _player;
    public int currentScore;

    [SerializeField] GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _player = Instantiate(playerPrefab);
        currentScore = 0;
        EventBus.Subscribe(EventBus.EventType.WonGame, WinGame);
        EventBus.Subscribe(EventBus.EventType.LostGame, LoseGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (_player == null)
        {
            _player = Instantiate(playerPrefab);
        }
        
    }

    void WinGame()
    {
        Debug.Log("Ending Game...");
        SceneManager.LoadScene("WonGameScreen");
        Destroy(_player);
        CleanupListeners();
    }

    void LoseGame()
    {
        Debug.Log("Losing Game...");
        SceneManager.LoadScene("LostGameScreen");
        Destroy(_player);
        CleanupListeners();
    }

    void CleanupListeners()
    {
        EventBus.Unsubscribe(EventBus.EventType.WonGame, WinGame);
        EventBus.Unsubscribe(EventBus.EventType.LostGame, LoseGame);
    }

    public GameObject GetPlayer()
    {
        return _player;
    }
}
