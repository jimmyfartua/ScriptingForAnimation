using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MoveNotGrounded")]
public class MoveNotGrounded : MovePattern 
{
	public override void Invoke(CharacterController controller, Transform transform)
	{
		
		Move(transform);
		Move(controller);
	}
}
