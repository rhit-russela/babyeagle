using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScoreTextHookup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        text.text = "Final Score: " + LoadSceneManager.Instance.CurrentScore.ToString();
        Debug.Log("Reached Eventbus for FINAL TEXT SCORE");

    }
    void Update()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        text.text = "Final Score: " + LoadSceneManager.Instance.CurrentScore.ToString();
    }

}
