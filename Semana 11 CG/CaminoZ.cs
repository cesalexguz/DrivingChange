using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminoZ : MonoBehaviour {

	public Transform brick;
	public float Xoffset = 0;
	public float Yoffset = 0;
	public float Zoffset = 0;
	public float LargoZ = 0;
	public float Alto = 0;


	void Start() {
		for (int y = 0; y < Alto; y++) {
			for (int z = 0; z < LargoZ; z++) {
				Instantiate(brick, new Vector3(0+Xoffset, y+Yoffset, z+Zoffset), Quaternion.identity);
			}
		}
	}
}
