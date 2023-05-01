using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScoreTextHookup : MonoBehaviour
{
    GameManager _gm;
    private int scoreToDisplay;
    // Start is called before the first frame update
    void Start()
    {
        _gm = FindObjectOfType<GameManager>();
        if( _gm != null )
        scoreToDisplay = _gm.currentScore;
        Debug.Log(scoreToDisplay.ToString());
        _gm.currentScore = 0;
    }
    void Update()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        text.text = "Final Score: " + scoreToDisplay.ToString();
    }
}
