using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addscore : MonoBehaviour {
    GameObject scorem;
	// Use this for initialization
	void Start () {
        scorem = GameObject.FindGameObjectWithTag("scorem");
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter(Collider o)
    {
        if (scorem.GetComponent<scoremana>().yolo == 0)
        {
            scorem.GetComponent<scoremana>().incscore();
            scorem.GetComponent<scoremana>().yolo = 1;
        }
        
    }
}
