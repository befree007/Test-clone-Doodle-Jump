using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveHorizontal : Platform
{
    private void Start()
    {
        firstPoint = 2.4f;
        secondPoint = -1.8f;
    }

    public override void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(firstPoint, transform.position.y), speed * Time.deltaTime);

        if (transform.position.x == firstPoint)
        {
            float addVar = firstPoint;
            firstPoint = secondPoint;
            secondPoint = addVar;
        }

    }
}
