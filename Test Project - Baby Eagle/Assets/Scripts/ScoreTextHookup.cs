using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTextHookup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        text.text = "Score: " + LoadSceneManager.Instance.CurrentScore.ToString();
    }

}
