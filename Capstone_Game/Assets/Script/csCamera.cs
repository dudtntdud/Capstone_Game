using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCamera : MonoBehaviour {
    public GameObject hero;
    Transform heroTransform;

	// Use this for initialization
	void Start () {
        heroTransform = hero.transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(heroTransform.position.x + 3.41f, this.transform.position.y, -10);

    }  
}
