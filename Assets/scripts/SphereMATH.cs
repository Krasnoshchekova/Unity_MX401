using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMATH : MonoBehaviour {

		Rigidbody rb;
		public float A = 0.01F;
		float g = 9.8F;
	public float l = 9F;
		float Omega;
	Vector3 now;
		void Start()
		{
			rb = GetComponent<Rigidbody>();
			ls ();

		Debug.Log (rb.position);
		now = rb.position;
		}

		void ls(){
		Omega = Mathf.Sqrt (g / l);
		}

		void Update()
		{
		rb.MovePosition( now + new Vector3( A*Mathf.Cos(Omega*Time.realtimeSinceStartup),				//x
											-A*Mathf.Abs(Mathf.Sin(Omega*Time.realtimeSinceStartup)),	//y
											0f) );														//z
		}
}
