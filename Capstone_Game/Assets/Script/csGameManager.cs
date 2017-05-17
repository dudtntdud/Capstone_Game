using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csGameManager : MonoBehaviour {
    public static int score;
    public static int hp;
    public static bool isUnBeatTime = false;

    private csHero cshero;
    // Use this for initialization
    void Start () {
        cshero = GameObject.Find("hero").GetComponent<csHero>();
        score = 0;
        hp = 4;
	}
	
	// Update is called once per frame
	void Update () {
	    if(hp <= 0)
        {
            //GameOver();
        }

        if (cshero.transform.position.x >= 35.0f)
        {
            //Clear();
        }
	}
}
