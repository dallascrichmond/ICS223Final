using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 movement;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Vector3.zero;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        if (movement != Vector3.zero)
        {
            MoveCharacter();
        }

    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + movement.normalized * speed * Time.fixedDeltaTime);
    }
}
