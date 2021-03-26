using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // to access unity canvas and UI

public class score_controller : MonoBehaviour
{
    public int score = 0;

    public void UpdateScore()
    {
        GetComponent<Text>().text = "Score: " + score;
    }
}
