using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMATH : MonoBehaviour {

		Rigidbody rb;
	 float A = Mathf.PI/2F;
		float g = 9.8F;
	float p;
	    float l ;
		float Omega;
	float t;
	    Vector3 now;
		void Start()
		{
		rb = GetComponent<Rigidbody>();
		l = Mathf.Abs(rb.position.x);
		Debug.Log (l);
		Omega = Mathf.Sqrt (g / l);
		Debug.Log (Omega);
		}

		void Update()
		{
		t += Time.deltaTime;
		p = A * Mathf.Cos (Omega * t);
		Debug.Log ("Math: " + t + ", " + p+" "+A+" "+Omega);
		rb.position=new Vector3( l*Mathf.Sin(p),				//x
			-l*(Mathf.Cos(p)),	//y
			0f) ;														//z
		}
}
