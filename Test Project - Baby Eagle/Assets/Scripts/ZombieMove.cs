using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{

    public float speed = 2.5f;
    private CircleCollider2D _collider;
    private bool endGame = false;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<CircleCollider2D>();

        Vector3 direction = Vector3.zero - transform.position;
        movement = direction.normalized;

        Quaternion rotate = Quaternion.LookRotation(direction);
        rotate.x = transform.rotation.x;
        rotate.y = transform.rotation.y;
        // transform.rotation = rotate;
        // transform.Rotate(0, 0, 90);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.Rotate(0, 0, angle);
        direction = Vector3.zero - transform.position;
        movement = direction.normalized;

    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 direction = Vector3.zero - transform.position;
        // Vector3 movement = direction.normalized;

        transform.Translate(movement * speed * Time.deltaTime);

        // if (Input.GetMouseButtonDown (0)) {
        //     Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        //     RaycastHit hit;
        //     Debug.Log (Input.mousePosition);
        //     if (Physics.Raycast (ray, out hit)) {
        //         if (hit.collider.gameObject == gameObject) Destroy (gameObject);

        //     }
        // }

        
        // Vector3 direction = transform.position - Vector3.zero;
        // transform.Rotate(0, 0, Vector3.Angle(direction, transform.forward));
        // transform.RotateAround(Vector3.zero, Vector3.forward, 20 * Time.deltaTime);

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
