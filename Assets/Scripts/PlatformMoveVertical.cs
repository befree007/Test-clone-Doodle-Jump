using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveVertical : Platform
{
    private void Start()
    {
        firstPoint = transform.position.y + 1f;
        secondPoint = transform.position.y - 1f;
    }

    public override void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, firstPoint), speed * Time.deltaTime);

        if (transform.position.y == firstPoint)
        {
            float addVar = firstPoint;
            firstPoint = secondPoint;
            secondPoint = addVar;
        }
    }
}
