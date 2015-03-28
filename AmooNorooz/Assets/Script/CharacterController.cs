using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public Animator MyCharacterController;

	void Update()
	{
		if(Input.GetKey(KeyCode.Space))
		{
			MyCharacterController.SetBool("HighJump",true);
		}
		else
		{
			MyCharacterController.SetBool("HighJump",false);
		}
		if(Input.GetKey(KeyCode.Q))
		{
			MyCharacterController.SetBool("rollL",true);
		}
		else
		{
			MyCharacterController.SetBool("rollL",false);
		}
		if(Input.GetKey(KeyCode.W))
		{
			MyCharacterController.SetBool("rollR",true);
		}
		else
		{
			MyCharacterController.SetBool("rollR",false);
		}


	}
}
