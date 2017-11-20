using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJDestroy : MonoBehaviour {

	public float TiempoParaDest=1.0f; 
		void OnCollisionEnter (Collision col)
		{
			if(col.gameObject.name == "Car")
			{
				Destroy (this.gameObject,TiempoParaDest);
			}
		}
}