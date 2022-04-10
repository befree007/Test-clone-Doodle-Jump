using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    protected float firstPoint;
    protected float secondPoint;
    public float speed;

    public float minSpawnPositionY;

    private void Update()
    {
        Move();
    }

    public virtual void Move()
    {

    }

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Touch");
            collision.gameObject.GetComponent<Player>().Jump();
        }
    }
}
