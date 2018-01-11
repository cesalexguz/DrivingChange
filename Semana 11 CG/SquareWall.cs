using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareWall : MonoBehaviour {

	public GameObject prefab;
	public int DensidadObjects = 20;
	public float Xoffset = 0;
	public float Yoffset = 0;
	public float Zoffset = 0;
	public float Alto = 0;
	public float Anacho = 0;

	void Start() {
		Vector3 des = new Vector3(Xoffset, Yoffset, Zoffset);
		for (int i = 0; i < DensidadObjects; i++) {
			float z = Anacho/DensidadObjects;
			float x = Alto/DensidadObjects;
			Vector3 posx1 = new Vector3(0+(Anacho/2), 0, x*i-(Alto/2));
			Vector3 posx2 = new Vector3(0-(Anacho/2), 0, x*i-(Alto/2));
			Vector3 posy1 = new Vector3(z*i-(Anacho/2), 0, 0+(Alto/2));
			Vector3 posy2 = new Vector3(z*i-(Anacho/2), 0, 0-(Alto/2));
			Instantiate(prefab, (posx1+des), Quaternion.identity);
			Instantiate(prefab, (posx2+des), Quaternion.identity);
			Instantiate(prefab, (posy1+des), Quaternion.identity);
			Instantiate(prefab, (posy2+des), Quaternion.identity);
		}
	}
}