using UnityEngine;
using System.Collections;

public class TurnTurret : MonoBehaviour {
	public Camera camera;

	void Start () {
	
	}
	

	void Update () {


		Vector3 mousePos = Input.mousePosition;
		mousePos.z = camera.transform.position.y-1.5f;
		Vector3 worldPos = camera.ScreenToWorldPoint( mousePos);

		transform.LookAt(worldPos);
	}
}
