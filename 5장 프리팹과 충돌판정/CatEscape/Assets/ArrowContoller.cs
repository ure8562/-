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
        // �����Ӹ��� ������� ����
        transform.Translate(0, speed, 0);
        
        speed *= 1.01f;

        //ȭ�� ������ ������ ������Ʈ �Ҹ�
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�浹����
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

            //�浹�� ��� ȭ��ǥ ����
            Destroy(gameObject);
        }

    }
}
