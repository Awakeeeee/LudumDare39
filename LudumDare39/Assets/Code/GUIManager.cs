using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : SingletonBase<GUIManager>
{
	public Text countingNum;

	void Start()
	{
		HideCursor();
		countingNum.text = GameManager.Instance.allThingsCount.ToString();
	}

	public void HideCursor()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	public void ShowCursor()
	{
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = true;
	}
}
