using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eiler : MonoBehaviour {

		Rigidbody rb;
		float g = 9.8F;
		float l = 6F;
		float fw(float p) { return -(g/l)*Mathf.Sin(p); }
		float fp( float w) { return w; }

		float EilerP( float W, float h) {
		
			return h * fp(W);
		}
		float EilerW(float P, float h) {
		
			return h * fw(P);
		}
		float W ;
		float P ;
		float Pn;
		float Wn;
		void Start()
		{
			rb = GetComponent<Rigidbody>();
			W = 0;
			P = Mathf.PI / 2;
			Debug.Log (rb.position);
		}

		void Update ()
		{
			float h = Time.deltaTime;

			//for (int i = 1; i <= n; i++)
			Wn =W + EilerW (P, h);
			Pn =P + EilerP (W, h);
			rb.position = new Vector3 (l*Mathf.Sin (Pn),				//x
				-l*Mathf.Cos (Pn),	//y
				0f);
			Debug.Log (rb.position);
			P = Pn;
			W = Wn;
		}
	}
