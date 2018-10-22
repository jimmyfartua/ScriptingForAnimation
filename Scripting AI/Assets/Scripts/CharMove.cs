using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
	[RequireComponent(typeof(CharacterController))]

	public class CharMove : MonoBehaviour {

		private CharacterController controller;
		public MovePattern Pattern;

		private void Start()
		{
			controller = GetComponent<CharacterController>();
		}
	

		void Update()
		{
			Pattern.Invoke(controller, transform);
		
		}
	}
}
