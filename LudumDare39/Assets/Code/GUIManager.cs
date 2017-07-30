using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : SingletonBase<GUIManager>
{
	public Text countingNum;
	public Canvas countingCanvas;

	void Start()
	{
		HideCursor();
		countingCanvas.gameObject.SetActive(false);
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
