using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour
{
	Rigidbody rb;
	public float A = 0.01F;
	public float k = 0.05F;
	float Omega;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		ls ();
    }

	void ls(){
		Omega = Mathf.Sqrt (k / rb.mass);
	}

    void Update()
    {
		rb.MovePosition( new Vector3( 0f, A*Mathf.Cos(Omega*Time.realtimeSinceStartup), 0f) );
    }
}