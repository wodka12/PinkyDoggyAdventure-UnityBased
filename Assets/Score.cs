using System.Collections;
using System.Collections.Generic;
// using Packages.Rider.Editor.UnitTesting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 0;
    public static int bestScore = 0;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = score.ToString(); // str(score)
    }
}
