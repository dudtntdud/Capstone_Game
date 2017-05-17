using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class csMapManagement : MonoBehaviour {
    private SpriteRenderer spriteRenderer;
    

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine("flickButton");
    }

    IEnumerator flickButton()
    {
        int countTime = 0;

        while (countTime < 1000)
        {
            if (countTime % 60 > 30) spriteRenderer.color = new Color32(255, 255, 255, 90);
            else spriteRenderer.color = new Color32(255, 255, 255, 255);

            yield return new WaitForSeconds(0.01f);

            countTime++;
        }

        yield return new WaitForSeconds(0.01f);
    }
}
