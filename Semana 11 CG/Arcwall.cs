using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arcwall : MonoBehaviour {

	public GameObject prefab;
	public int numberOfObjects = 20;
	public float radius = 5f;
	public float Xoffset = 0;
	public float Yoffset = 0;
	public float Zoffset = 0;
	public float RotacAngle = 0;
	public float ApertAngle = 0;

	void Start() {
		float initangle = Mathf.PI * (2*RotacAngle/360);
		for (int i = 0; i < numberOfObjects; i++) {
			float angle = i * Mathf.PI * (2*(ApertAngle-initangle)/360) / numberOfObjects;
			Vector3 pos = new Vector3(Mathf.Cos(initangle+angle), 0, Mathf.Sin(initangle+angle)) * radius;
			pos = pos + new Vector3(Xoffset, Yoffset, Zoffset);
			Instantiate(prefab, pos, Quaternion.identity);
		}
	}
}