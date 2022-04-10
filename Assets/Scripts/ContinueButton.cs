using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    [SerializeField] private GameObject pauseScene;

    public void Continue()
    {
        Time.timeScale = 1f;
        pauseScene.SetActive(false);
    }
}
