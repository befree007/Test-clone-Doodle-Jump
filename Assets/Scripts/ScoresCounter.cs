using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresCounter : MonoBehaviour
{    
    private float scoresCount = 0;
    [SerializeField]private Player player;
    private float startScore;
    public float scoresCountView;

    private void Start()
    {
        startScore = player.transform.position.y;
    }

    private void Update()
    {
        Count();
    }

    public void Count()
    {
        if (scoresCount < player.transform.position.y)
        {
            scoresCount = player.transform.position.y;
            scoresCountView = scoresCount - startScore;
        }
    }
}
