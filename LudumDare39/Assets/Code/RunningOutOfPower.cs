using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunningOutOfPower : MonoBehaviour 
{
	public float timeLeft;
	public Color fullPowerCol;
	public Color lowPowerCol;
	public MeshRenderer batteryMesh;
	public Text powerText;

	Light pointLight;
	Material mat;
	float startIntensity;
	float timer;
	bool outOfPower;

	void Start()
	{
		timer = 0.0f;
		outOfPower = false;
		pointLight = GetComponent<Light>();
		pointLight.color = fullPowerCol;
		startIntensity = pointLight.intensity;
		mat = batteryMesh.material;
	}

	void Update()
	{
		if(outOfPower)
			return;
		
		if(timer < timeLeft)
		{
			pointLight.intensity = Mathf.Lerp(startIntensity, 0.1f, timer / timeLeft);
			pointLight.color = Color.Lerp(fullPowerCol, lowPowerCol, timer / timeLeft);
			Color c = Color.Lerp(Color.green, Color.red, timer / timeLeft);
			c = new Color(c.r, c.g, c.b, 0.6f);
			mat.SetColor("_Color", c);
			powerText.text = ((1 - timer / timeLeft) * 100).ToString("F0") + "%";
			timer += Time.deltaTime;
		}else
		{
			outOfPower = true;
			pointLight.color = lowPowerCol;
			pointLight.intensity = 0f;
			powerText.text = "0%";
		}
	}
}
