using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IB_Metube : Interactable{
    public Sprite play;
    public Sprite pause;
    public GameObject jindu;
    SpriteRenderer thissp;
    bool go;
    float playtime;
	// Use this for initialization
	void Start ()
    {
        thissp = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (go)
        {
            playtime += Time.deltaTime;
            if (playtime < 10)
            {
                jindu.transform.localScale = new Vector3(1, 1, playtime / 10);
            }
            else
            {
                go = false;
            }
        }
    }

    protected override void InternalOnMoveout()
    {
        this.transform.localScale =new Vector3(0.2f, 0.7f, 0.1f);
    }

    protected override void InternalOnHover()
    {
        this.transform.localScale = new Vector3(0.1f, 0.35f, 0.1f);
    }

    protected override void InternalOnClick()
    {
        if (go == false)
        {
            thissp.sprite = pause;
            go = true;
        }
        else
        {
            thissp.sprite = play;
            go = false;
        }
    }
   
}
