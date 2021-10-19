using UnityEngine;
using System.Collections;

public class spacetofap : MonoBehaviour {
    public float delaytime;
    float timetojump = 0;
    int stop = 0;
    public float jumpforce;
    public float stopforce;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<continuemovingpls>().alive)
        {
            if (Input.GetKey(KeyCode.Space) && stop == 0)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(0, jumpforce, 0);
                stop = 1;
            }
            if (stop == 1)
            {
                timetojump += Time.deltaTime;
                if (timetojump >= delaytime)
                {
                    stop = 0;
                    timetojump = 0;
                }
            }
            if (gameObject.GetComponent<Transform>().position.y > 8 && stop == 0)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(0, -stopforce, 0);
                stop = 1;
            }
            if (gameObject.GetComponent<Transform>().position.y < -8 && stop == 0)
            {
                gameObject.GetComponent<Rigidbody>().AddForce(0, stopforce, 0);
                stop = 1;
            }
        }
	}
}
