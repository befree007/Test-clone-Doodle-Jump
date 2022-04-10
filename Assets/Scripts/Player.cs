using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private Rigidbody2D rigidbody;

    public UnityEvent playerDestroyed = new UnityEvent();

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        rigidbody.velocity = new Vector2(Input.acceleration.x * speed, rigidbody.velocity.y);
    }

    public void Jump()
    {
        rigidbody.velocity = new Vector2(Input.acceleration.x, jumpForce);
    }

    public void OnDestroy()
    {
        playerDestroyed.Invoke();
    }
}
