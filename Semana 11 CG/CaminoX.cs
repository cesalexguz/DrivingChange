using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminoX : MonoBehaviour {

	public Transform brick;
	public float Xoffset = 0;
	public float Yoffset = 0;
	public float Zoffset = 0;
	public float LargoX = 0;
	public float Alto = 0;


	void Start() {
		for (int y = 0; y < Alto; y++) {
			for (int x = 0; x < LargoX; x++) {
				Instantiate(brick, new Vector3(x+Xoffset, y+Yoffset, 0+Zoffset), Quaternion.identity);
			}
		}
	}
}
