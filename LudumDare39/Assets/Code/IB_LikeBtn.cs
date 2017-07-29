using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IB_LikeBtn : Interactable
{
	protected SpriteRenderer sr;
	protected Color originalColor;

	protected void Start()
	{
		sr = GetComponent<SpriteRenderer>();
		originalColor = sr.color;
	}

	protected override void InternalOnMoveout ()
	{
		sr.color = originalColor;
	}

	protected override void InternalOnHover ()
	{
		sr.color = Color.grey;
	}

	protected override void InternalOnClick ()
	{
		sr.color = Color.blue;
		GameManager.Instance.FinishOneThing();
	}
}
