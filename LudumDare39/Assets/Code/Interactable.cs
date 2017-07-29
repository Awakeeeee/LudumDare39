using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
	
	protected bool isHovering = false;
	protected bool isClicked = false;


	public void OnMoveOut()
	{
		if(isClicked)
			return;

		if(!isHovering)
			return;

		isHovering = false;
		InternalOnMoveout();
	}

	public void OnHover()
	{
		if(isClicked)
			return;

		if(isHovering)
			return;
	
		isHovering = true;
		InternalOnHover();
	}

	public void OnClick()
	{
		isClicked = true;
		InternalOnClick();
	}

	//different performances in here
	protected virtual void InternalOnHover()
	{}
	protected virtual void InternalOnMoveout()
	{}
	protected virtual void InternalOnClick()
	{}
}
