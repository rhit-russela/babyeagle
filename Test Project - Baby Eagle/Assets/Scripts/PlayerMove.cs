using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private Rigidbody2D body;
    private CircleCollider2D capsule;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        capsule = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mouseCoord = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log(mouseCoord);
            Debug.DrawRay(transform.position, mouseCoord, Color.white, 2.5f);
            Vector3 direction = transform.position - mouseCoord;
            // transform.Rotate(0, 0, Vector3.Angle(direction, transform.forward));
            // transform.Rotate(0, 0, Vector3.Angle(transform.position, direction));
            // transform.Rotate(0, Input.GetAxis("Mouse X") * 9f, 0);
            
        }
        // float h = 9f* Input.GetAxis("Vertical");
        // float v = 9f * Input.GetAxis("Horizontal");

        // transform.Rotate(v, h, 0);
        
    }
}
