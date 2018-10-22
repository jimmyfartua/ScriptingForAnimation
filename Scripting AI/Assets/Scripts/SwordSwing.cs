using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour {

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.H))
		{
			GetComponent<Animation>().Play("Take 001");
		}
		
	}
}
