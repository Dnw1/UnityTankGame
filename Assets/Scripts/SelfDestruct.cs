using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {
    private ParticleSystem ps;
    private Light light;


	void Start () {
        ps = this.gameObject.GetComponent<ParticleSystem>();
        light = this.gameObject.GetComponent<Light>();

	}
	

	void Update () {

        if(light.intensity>0)light.intensity -= 0.5f;
        if (ps.isStopped) Destroy(this.gameObject);
	}
}
