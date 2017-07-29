using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
	public int allThingsCount;

	public void FinishOneThing()
	{
		GameManager.Instance.allThingsCount--;
		GUIManager.Instance.countingNum.text = GameManager.Instance.allThingsCount.ToString();
	}
}
