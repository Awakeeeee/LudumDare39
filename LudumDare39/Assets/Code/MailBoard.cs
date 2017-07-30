using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailBoard : MonoBehaviour 
{
	public int mailCount;
	public SpriteRenderer bg;

	public Material deactiveMat;
	IB_MailCheck[] checkBtns;

	bool finished;

	void Start()
	{
		finished = false;
		checkBtns = GetComponentsInChildren<IB_MailCheck>();
	}

	void Update()
	{
		if(finished)
			return;

		if(mailCount <= 0)
		{
			finished = true;
			Invoke("DeactivateBoard", 1f);
		}
	}

	void DeactivateBoard()
	{
		foreach(IB_MailCheck b in checkBtns)
		{
			b.GetComponent<SpriteRenderer>().material = deactiveMat;
		}

		bg.material = deactiveMat;
		GameManager.Instance.FinishOneThing();
	}
}
