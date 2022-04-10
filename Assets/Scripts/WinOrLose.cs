using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLose : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private ScoresCounter scoresCounter;
    [SerializeField] private GameObject winScene;
    [SerializeField] private GameObject deathScene;

    private void Start()
    {
        player.playerDestroyed.AddListener(Lose);
    }

    private void Update()
    {
        if (scoresCounter.scoresCountView > 100)
        {
            Win();
        }
    }

    public void Win()
    {
        Time.timeScale = 0f;
        winScene.SetActive(true);
    }

    public void Lose()
    {
        Time.timeScale = 0f;
        deathScene.SetActive(true);
    }

}
