using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{

    public float speed = 2.5f;
    private CircleCollider2D _collider;
    private bool endGame = false;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<CircleCollider2D>();

        direction = Vector2.zero - (Vector2) transform.position;

        if (transform.position.y < 0)
            transform.Rotate(0, 0, Vector2.Angle(Vector2.right, direction));
        else
            transform.Rotate(0, 0, -Vector2.Angle(Vector2.right, direction));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        
        if (Mathf.Abs(transform.position.x) > 15 || Mathf.Abs(transform.position.y) > 10){
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
