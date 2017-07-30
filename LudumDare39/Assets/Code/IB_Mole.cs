using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IB_Mole : Interactable
{
	public Transform[] holes;
	public Sprite normalImage;
	public Sprite hitImage;
	public float interval;

	GameBoard board;
	SpriteRenderer sr;
	float timer;

	void Start()
	{
		board = GetComponentInParent<GameBoard>();
		sr = GetComponent<SpriteRenderer>();
		timer = 0.0f;
	}

	void Update()
	{
		timer += Time.deltaTime;

		if(timer > interval)
		{
			Reset();
			timer = 0.0f;
		}
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
		sr.sprite = hitImage;
		board.GetOne();
	}

	void Reset()
	{
		sr.sprite = normalImage;
		this.transform.position = holes[Random.Range(0, holes.Length)].position + Vector3.right * 0.07f;
		isClicked = false;
	}
}
