using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : Platform
{
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
