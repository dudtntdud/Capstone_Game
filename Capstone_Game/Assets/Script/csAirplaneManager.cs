using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csAirplaneManager : MonoBehaviour {

    public GameObject srcAirplane;

    // Use this for initialization
    void Start () {
		
	}
    float timer = 0.0f;
    float timerMax = 4.0f;

    // Update is called once per frame
    void Update () {
        //타이머에 시간을 더해 준다.
        timer += Time.deltaTime;

        //타이머가 0.3초보다 작으면 return시킨다.
        //return되면 함수는 바로 종료되어 뒤에 부분이 실행되지 않는다.
        if (timer < timerMax)
        {
            return;
        }
        //타이머를 다시 0으로 변경하고
        timer = 0;

        //x좌표를 -6에서 6까지 랜덤으로 생성한다.
        float randY = Random.Range(-0.4f, 0.05f);

        //소스 Fire 프리팹을 랜덤좌표X,7에 생성한다.
        Instantiate(srcAirplane, new Vector3(40, randY, 0), transform.rotation);
    }
}
