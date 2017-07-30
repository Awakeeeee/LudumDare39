using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBoard : MonoBehaviour 
{
	public Material finishMat;
	public int numLeft;
	public Text displayText;
	public Transform holes;
	public Transform mole;
	public Transform bg;

	bool finished;

	void Start()
	{
		displayText.text = numLeft.ToString();
		finished = false;
	}

	void Update()
	{
		if(finished)
			return;
		
		if(numLeft <= 0)
		{
			finished = true;
			displayText.text = "WIN!";
			mole.gameObject.SetActive(false);
			Invoke("Finish", 2.0f);
		}
	}

	void Finish()
	{
		bg.GetComponent<SpriteRenderer>().material = finishMat;
		holes.gameObject.SetActive(false);
		GameManager.Instance.FinishOneThing();
	}

	public void GetOne()
	{
		numLeft--;
		displayText.text = numLeft.ToString();
	}
}
