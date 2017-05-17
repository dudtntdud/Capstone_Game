using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csAirplane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(-0.05f, 0, 0));  //이동

        if(this.transform.position.x <= -4.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
