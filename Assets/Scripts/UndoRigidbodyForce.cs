using UnityEngine;
using System.Collections;

public class UndoRigidbodyForce : MonoBehaviour {
	Rigidbody rb;

	void Start () {
		rb = this.GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		if(rb.velocity != Vector3.zero)rb.velocity=Vector3.zero;
	}
}
