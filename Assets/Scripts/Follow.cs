using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
    [SerializeField]
    private Transform target;

    [SerializeField]
    private float catchup = 0.23f;
    
    [SerializeField]
    private float zoomOutBySpeed = 0f;
   
   
    private BaseTank tankScript;
    private float startCameraDistance;


	void Start () {
        if (target != null) tankScript = target.gameObject.GetComponent<BaseTank>();
        startCameraDistance = transform.position.y;
	}
	

	void Update () {
        if (target != null)
        {
            Vector3 newPos = target.position;
            newPos.y = this.transform.position.y;
            transform.position = Vector3.MoveTowards(this.transform.position, newPos, catchup);
        }
        if (zoomOutBySpeed > 0) 
        {
            float speed = Mathf.Abs(tankScript.GetSpeed());
                      
            Vector3 pos = transform.position;
            pos.y = (speed * zoomOutBySpeed + startCameraDistance);
            transform.position = pos;

 
        }

    }
}
