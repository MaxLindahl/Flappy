using UnityEngine;
using System.Collections;

public class triggerbois : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnTriggerEnter(Collider o)
    {
        if (o.GetComponent<continuemovingpls>() != null)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<continuemovingpls>().alive = false;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<continuemovingpls>().alive = false;
            Debug.Log("dedLOL");
        }
    }
}
