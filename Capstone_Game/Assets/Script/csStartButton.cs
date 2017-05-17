using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class csStartButton : MonoBehaviour {

    public static bool isClick = false;

    // Use this for initialization
    void Start () {
    }

    public void GotoSelect()
    {
        if (isClick == false)
        {
            GameObject.Find("Main Camera").SendMessage("FadeOut", SendMessageOptions.DontRequireReceiver);
        }
        //SceneManager.LoadScene("1.Select_stage");
    }

    // Update is called once per frame
    public void GotoAirport()
    {
        if (isClick == false)
        {
            GameObject.Find("Main Camera").SendMessage("FadeOut", SendMessageOptions.DontRequireReceiver);
        }
        //SceneManager.LoadScene("Stage_Airport");
    }

    public void GotoExPlain()
    {
        if (isClick == false)
            SceneManager.LoadScene("2.Explain_Airport");
    }

    public void GotoVR()
    {
        SceneManager.LoadScene("3.VR_Airport");
    }
}
