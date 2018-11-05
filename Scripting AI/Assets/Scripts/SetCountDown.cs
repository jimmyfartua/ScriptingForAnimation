using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountDown : MonoBehaviour
{
	private GameM GMS;

	public void SetCountDownNow()
	{
		GMS = GameObject.Find("GameManager").GetComponent<GameM>();
		GMS.counterDownDone = true;
	}



}
