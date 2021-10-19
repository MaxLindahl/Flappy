using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class continuemovingpls : MonoBehaviour {
    public float speed = 5;
    Vector3 pos;
    public bool alive = true;
    GameObject reset;
    GameObject menu;
    GameObject high;
    
	// Use this for initialization
	void Start () {
        pos = gameObject.GetComponent<Transform>().position;
        reset = GameObject.FindGameObjectWithTag("button");
        menu = GameObject.FindGameObjectWithTag("menu");
        high = GameObject.FindGameObjectWithTag("hscore");
        high.SetActive(false);
        reset.SetActive(false);
        menu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (alive)
        {
            pos = new Vector3(gameObject.GetComponent<Transform>().position.x + (speed * Time.deltaTime), gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z);
            gameObject.GetComponent<Transform>().position = pos;
        }
        else
        {
            high.SetActive(true);
            reset.SetActive(true);
            menu.SetActive(true);
        }

	}
}
