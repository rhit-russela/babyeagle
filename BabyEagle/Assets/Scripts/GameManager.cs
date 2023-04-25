using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _player_prefab;
    GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = Instantiate(_player_prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
