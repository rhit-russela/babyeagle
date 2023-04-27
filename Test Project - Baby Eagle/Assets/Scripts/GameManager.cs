using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    GameObject _player;

    [SerializeField] GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
     _player = Instantiate(playerPrefab);  
    }

    // Update is called once per frame
    void Update()
    {
        if (_player == null)
        {
            _player = Instantiate(playerPrefab);
        }
    }
}
