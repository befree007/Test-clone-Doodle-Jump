using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresText : MonoBehaviour
{
    [SerializeField] private ScoresCounter scoresCounter;
    private float currentScore = 0f;
    private Text scoresText;

    private void Start()
    {
        scoresText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentScore < scoresCounter.scoresCountView)
        {
            currentScore = scoresCounter.scoresCountView;
            scoresText.text = currentScore.ToString();
        }
    }
}
