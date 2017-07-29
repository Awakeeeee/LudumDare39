using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IB_DoorHandle : Interactable 
{
	public float handleOpenTime;
	public float doorOpenTime;
	public Transform door;
	public Transform handle;

	Quaternion originDoorRo;
	Quaternion originHandleRo;

	void Start()
	{
		originDoorRo = door.transform.localRotation;
		originHandleRo = handle.transform.localRotation;
	}

	protected override void InternalOnMoveout ()
	{
		
	}

	protected override void InternalOnHover ()
	{
		
	}

	protected override void InternalOnClick ()
	{
//		if(isClicked)
//			return;
		
		if(GameManager.Instance.allThingsCount <= 0)
		{
			StartCoroutine(Open());
		}else
		{
			Debug.Log("Your things are not done yet.");
		}
	}

	IEnumerator Open()
	{
		yield return StartCoroutine(HandleOpen());

		yield return StartCoroutine(DoorOpen());
	}

	IEnumerator DoorOpen()
	{
		Quaternion target = Quaternion.Euler(0f, 90f, 0f);

		float timer = 0.0f;

		while(timer < doorOpenTime)
		{
			door.transform.localRotation = Quaternion.Lerp(originDoorRo, target, timer / doorOpenTime);
			timer += Time.deltaTime;
			yield return null;
		}

		door.transform.localRotation = target;
	}

	IEnumerator HandleOpen()
	{
		Quaternion target = Quaternion.Euler(0f, 90f, 90f);

		float timer = 0.0f;

		while(timer < handleOpenTime)
		{
			handle.transform.localRotation = Quaternion.Lerp(originHandleRo, target, timer / handleOpenTime);
			timer += Time.deltaTime;
			yield return null;
		}

		handle.transform.localRotation = target;
	}
}
