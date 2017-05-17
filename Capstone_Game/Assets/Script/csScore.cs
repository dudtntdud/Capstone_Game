using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csScore : MonoBehaviour {

    Text scoreLabel;

	// Use this for initialization
	void Start () {
        scoreLabel = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update () {
        scoreLabel.text = csGameManager.score.ToString();
	}

    void upScore()
    {
         
    }
}
