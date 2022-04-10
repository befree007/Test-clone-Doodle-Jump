using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseScene;

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseScene.SetActive(true);
    }
}
