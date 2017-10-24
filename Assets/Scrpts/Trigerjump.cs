using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigerjump : MonoBehaviour {

	public Animator anim;

	void OnCollisionEnter()
	{
		anim.SetBool("Jumptrig", true);
	}
	void OnCollisionExit()
	{
		anim.SetBool("Jumptrig", false);
	}	
}
