using UnityEngine;
using System.Collections;

public class spawn_gates : MonoBehaviour {

    public GameObject gate;
    Vector3 playerpos;
    Vector3 gatepos;
    float cooldown = 2f;
    float cd = 0;
    int yolo = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        playerpos = GameObject.FindGameObjectWithTag("Player").transform.position;
        gatepos = new Vector3(playerpos.x + 10, Random.Range(-9,-4), playerpos.z);

        if (yolo == 0)
        {
            Instantiate(gate, gatepos,GameObject.FindGameObjectWithTag("Player").transform.rotation);
            yolo = 1;
        }
        else if (yolo == 1)
        {
            cd += Time.deltaTime;

                if(cd > cooldown)
                {
                    yolo = 0;
                    cd = 0;
                }
        }

	}
}
