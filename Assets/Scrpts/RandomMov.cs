using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMov : MonoBehaviour {

	public float x = 0.10f;
	public float y = 0.0f;
	public float z = 0.0f;
	public bool regreso = false;
	public float distanciax=0;
	public float distanciaz=0;
	public float DistLIMIT = 4;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distanciax += x;
		//distanciaz += z;
		if (distanciax > DistLIMIT)
		{
			regreso = !regreso;
			distanciax = 0;
			distanciaz = 0;
		}
		if(regreso)
			transform.Translate (new Vector3 (-x, -y, -z),Space.World);
		else
			transform.Translate (new Vector3 (x, y, z),Space.World);
	}
}
