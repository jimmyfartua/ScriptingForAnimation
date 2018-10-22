using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "FloatBool")]
public class FloatBool : FloatInput
{
	public override float Value

	{
		get
		{
			if (Input.GetButton(InputType))
			{
				return value;
			}
			else
			{
				return 0;
			}
		}
	}
}

