using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IB_MailCheck : Interactable
{
	public Text connectText;

	MailBoard board;
	SpriteRenderer sr;

	void Start()
	{
		board = GetComponentInParent<MailBoard>();
		sr = GetComponent<SpriteRenderer>();
	}

	protected override void InternalOnHover ()
	{
		
	}

	protected override void InternalOnMoveout ()
	{
		
	}

	protected override void InternalOnClick ()
	{
		if(isClicked)
			return;

		board.mailCount--;
		connectText.fontStyle = FontStyle.Normal;
		sr.color = Color.white;
	}
}
