using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoremana : MonoBehaviour {

    float cd = 1.5f;
    float timespan = 0;
    public int yolo = 0;
    public static int score;
    public int scores;
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GameObject.FindGameObjectWithTag("scoretext").GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scores = score;
        text.text = "Score: " + score;

        if (yolo == 1)
        {
            timespan += Time.deltaTime;
            if (timespan > cd)
            {
                timespan = 0;
                yolo = 0;
            }

        }
    }

    public void incscore()
    {
        score += 1;
    }
}
