using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IB_LikeBtn : Interactable
{
	public Material afterMat;
	public Sprite afterBg;
	public SpriteRenderer bgSr;

	protected Animator anim;
	protected SpriteRenderer sr;

	protected void Start()
	{
		anim = GetComponent<Animator>();
		sr = GetComponent<SpriteRenderer>();
	}

	protected override void InternalOnMoveout ()
	{
		this.transform.localScale = Vector3.one * 0.3f;
	}

	protected override void InternalOnHover ()
	{
		this.transform.localScale = Vector3.one * 0.4f;
	}

	protected override void InternalOnClick ()
	{
		anim.SetTrigger("pressed");
		bgSr.sprite = afterBg;
		GameManager.Instance.FinishOneThing();
	}

	public void OnAnimEnd()
	{
		bgSr.material = afterMat;
		sr.material = afterMat;
	}
}
