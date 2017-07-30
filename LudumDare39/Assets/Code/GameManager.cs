using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
	public Light[] batteryLights;

	private int allThings;
	public int allThingsCount {get {return allThings;}}

	void Start()
	{
		allThings = 0;
	}

	public void FinishOneThing()
	{
		allThings--;
		GUIManager.Instance.countingNum.text = allThingsCount.ToString();
	}

	public void OpenLights()
	{
		foreach(Light l in batteryLights)
		{
			l.gameObject.SetActive(true);
		}
	}

	public void StartCounting()
	{
		allThings = 5;
		GUIManager.Instance.countingNum.text = allThingsCount.ToString();
		GUIManager.Instance.countingCanvas.gameObject.SetActive(true);
	}
}
