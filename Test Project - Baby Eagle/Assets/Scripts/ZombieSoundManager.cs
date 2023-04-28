using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSoundManager : MonoBehaviour
{

    [SerializeField] AudioClip walkSound;
    [SerializeField] AudioClip dieSound;
    AudioSource audioSource;
    private float randInt;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnStep()
    {
        audioSource.PlayOneShot(walkSound);
    }

    IEnumerator PlayStep()
    {
        while(true)
        {
            OnStep();
            yield return new WaitForSeconds(0.75f);
            randInt = Random.value;
            if(randInt > 0.75f) 
            {
                audioSource.PlayOneShot(dieSound);
            }
        }
    }

    public void StartWalking()
    {
        StartCoroutine(PlayStep());
    }

}
