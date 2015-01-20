using UnityEngine;
using System.Collections;

public class TurnTurretToTarget : MonoBehaviour {
    [SerializeField]
    Transform target;

	void Start () {
	
	}
	

	void Update () {
        transform.LookAt(target);
	}
}
