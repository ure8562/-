using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowContoller : MonoBehaviour
{
    GameObject player;
    public float speed = -0.1f;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        // 프레임마다 등속으로 낙하
        transform.Translate(0, speed, 0);
        
        speed *= 1.01f;

        //화면 밖으로 나오면 오브젝트 소멸
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //충돌판정
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            //충돌할 경우 화살표 삭제
            Destroy(gameObject);
        }

    }
}
