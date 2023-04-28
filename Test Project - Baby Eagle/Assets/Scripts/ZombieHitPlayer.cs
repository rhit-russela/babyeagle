using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHitPlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == GameManager.Instance.GetPlayer())
        {
            EventBus.Publish(EventBus.EventType.EndGame);
        }
    }
}
