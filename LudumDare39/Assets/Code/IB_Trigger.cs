using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IB_Trigger : Interactable 
{
	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator>();
	}

	protected override void InternalOnMoveout ()
	{
		
	}

	protected override void InternalOnHover ()
	{
		
	}

	protected override void InternalOnClick ()
	{
		if(isClicked)
			return;
		
		FPSCharacterController.Instance.freezed = false;
		anim.SetTrigger("press");
		GameManager.Instance.OpenLights();
		GameManager.Instance.StartCounting();
	}
}
