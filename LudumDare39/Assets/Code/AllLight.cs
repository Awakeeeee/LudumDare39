using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLight : MonoBehaviour {
    public float TurnOffTime;
    public Light[] lights;
    float oldrange;
    float time;
	// Use this for initialization
	void Start () {
        lights = FindObjectsOfType<Light>();
        oldrange = lights[0].range;
	}
	
	// Update is called once per frame
	void Update(){
        time = time + Time.deltaTime;
        for(int i = 0; i < lights.Length; i++)
        {
            if (lights[i].type == LightType.Point)
            {
                lights[i].range = time / TurnOffTime*oldrange;
                if (lights[i].range == 0)
                {
                    lights[i].intensity = 0;
                }
            }
        }
	}

}
