using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class highscore : MonoBehaviour {
    List<int> highsco = new List<int>();
    GameObject text;
	// Use this for initialization
	void Start () {
        text = GameObject.FindGameObjectWithTag("text");
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void highscores()
    {
        for(int n = 0;n<=PlayerPrefs.GetInt("highscores"); n++)
        {
             highsco.Add(PlayerPrefs.GetInt(n.ToString()));
             
            
        }
        highsco.Sort();
        highsco.Reverse();
        for (int u = 0; u <= highsco.Count; u++)
        {
            text.GetComponent<Text>().text = text.GetComponent<Text>().text + "\n " + highsco[u];
            Debug.Log(PlayerPrefs.GetInt(u.ToString()));
        }
        
    }
}
