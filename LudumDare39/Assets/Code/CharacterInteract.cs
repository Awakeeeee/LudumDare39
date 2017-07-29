using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteract : MonoBehaviour 
{
	public LayerMask checkLayer;

	Interactable currenIB;

	void Start()
	{

	}

	void Update()
	{
		Ray eyeRay = new Ray(this.transform.position, this.transform.forward);
		RaycastHit hit;

		if(Physics.Raycast(eyeRay, out hit, 100f, checkLayer, QueryTriggerInteraction.Collide))
		{
			Interactable ib = hit.transform.GetComponent<Interactable>();

			if(ib != null)
			{
				currenIB = ib;
				currenIB.OnHover();

				if(Input.GetButtonDown("Fire1"))
				{
					currenIB.OnClick();
				}
			}
			else
			{
				
			}
		}
		else
		{
			if(currenIB != null)
			{
				currenIB.OnMoveOut();
				currenIB = null;
			}
		}

	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawRay(this.transform.position, this.transform.forward * 100f);
	}
}
