using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testaifiaj : MonoBehaviour {
	public float Velocidad;
	public static int Puntaje=60;
	public Vector3 lastalgo= new Vector3();
	public GUIStyle estilo_nombre;

	void Update(){
		Velocidad = Vector3.Distance(lastalgo,this.transform.position);
		lastalgo = this.transform.position;
	}
	void OnGUI(){
		if (Puntaje <= 0) {
			GUI.Label (new Rect (150, 100, 200, 30), "Perdiste, te quedaste sin puntos! ", estilo_nombre);
			if(GUI.Button(new Rect(600,40, 250, 40), "Volver")){
				Application.LoadLevel ("Mainmenu3");
				Puntaje=60;
			}

		} else {
			GUI.Label (new Rect(40,40, 250, 40), "Velocidad: "+(Mathf.Round(Velocidad*100)), estilo_nombre);
			GUI.Label (new Rect(300,40, 250, 40), "Puntaje: "+Puntaje, estilo_nombre);
			if(GUI.Button(new Rect(600,40, 250, 40), "Volver")){
				Application.LoadLevel ("Mainmenu3");
				Puntaje=60;
			}
		}
	}
}
