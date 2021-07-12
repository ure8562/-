using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float lenght = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "목표 지점까지" + lenght.ToString("F2") + "m";

        if (lenght >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지" + lenght.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임오버!";
        }

    }
}
