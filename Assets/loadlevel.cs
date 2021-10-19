using UnityEngine;
using System.Collections;

public class loadlevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void load()
    {
        Application.LoadLevel("main");
    }
}
