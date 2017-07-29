using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowPower : MonoBehaviour {
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    float time;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time <20)
        {
            Debug.Log(light1.GetComponent<Renderer>().material.GetColor("_TintColor"));
            light1.GetComponent<Renderer>().material.SetColor("_TintColor", new Color(0, 1, 0, Mathf.PingPong(time/10, 0.1f)));
        }
    }

}
