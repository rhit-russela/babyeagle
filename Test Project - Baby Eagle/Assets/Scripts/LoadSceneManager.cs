using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LoadSceneManager : Singleton<LoadSceneManager>
{
    
    private int _currentScore;

    public int CurrentScore {get => _currentScore;
        set{
            _currentScore = value;
            EventBus.Publish(EventBus.EventType.KillsUpdate);
        }}
    // Start is called before the first frame update
    void Start()
    {
        //CurrentScore = 0;
        SetupListeners();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupListeners()
    {
        EventBus.Subscribe(EventBus.EventType.StartGame, LoadStartGame);
        EventBus.Subscribe(EventBus.EventType.StartTutorial, LoadTutorial);
        EventBus.Subscribe(EventBus.EventType.StartMainMenu, LoadMainMenu);
    }

    void LoadStartGame()
    {
        Debug.Log("Loading Game...");
        SceneManager.LoadScene("BabyEagleGame");
        CleanupListeners();
    }

    void LoadTutorial()
    {
        Debug.Log("Loading Tutorial...");
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("HowToPlay");
        CleanupListeners();
    }

    void LoadMainMenu()
    {
        Debug.Log("Loading Main Menu...");
        SceneManager.LoadScene("MainMenu");
        CleanupListeners();
    }

    void CleanupListeners()
    {
        EventBus.Unsubscribe(EventBus.EventType.StartGame, LoadStartGame);
        EventBus.Unsubscribe(EventBus.EventType.StartTutorial, LoadTutorial);
        EventBus.Unsubscribe(EventBus.EventType.StartMainMenu, LoadMainMenu);
    }

    public void UpdateZombieScore()
    {
        CurrentScore += 100;
    }
}
