using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTeleport : MonoBehaviour
{
    [SerializeField] private Transform oppositeSide;
    [SerializeField] private GameObject player;
    [SerializeField] private bool checkSide;

    void Update()
    {
        Teleport();
    }

    public void Teleport()
    {
        if (checkSide)
        {
            if (transform.position.x < player.transform.position.x)
            {
                TouchOpposideSide();
            }            
        }
        else
        {
            if (transform.position.x > player.transform.position.x)
            {
                TouchOpposideSide();
            }
        }
    }

    public void TouchOpposideSide()
    {
        player.transform.position = new Vector2(oppositeSide.position.x, player.transform.position.y);
    }
}
