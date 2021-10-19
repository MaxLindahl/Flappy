using UnityEngine;
using System.Collections;

public class savehscore : MonoBehaviour {
    string numberofscores;
    int score;
    int alrdysaved = 0;
    GameObject scoremanager;
	// Use this for initialization
	void Start () {
        scoremanager = GameObject.FindGameObjectWithTag("scorem");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void savehighscoree()
    {
        if (alrdysaved == 0)
        {
            numberofscores = PlayerPrefs.GetInt("highscores").ToString();
            score = scoremanager.GetComponent<scoremana>().scores;
            PlayerPrefs.SetInt("highscores", PlayerPrefs.GetInt("highscores") + 1);
            PlayerPrefs.SetInt(numberofscores, score);

            Debug.Log("saved as highscores = " + PlayerPrefs.GetInt("highscores"));
            Debug.Log("saved as " + numberofscores + " = " + score);
            alrdysaved = 1;
        }
    }

}
