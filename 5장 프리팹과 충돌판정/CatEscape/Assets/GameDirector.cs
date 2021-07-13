using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private float time = 0;
    GameObject timer;
    GameObject hpgauge;
    // Start is called before the first frame update
    void Start()
    {
        this.hpgauge = GameObject.Find("hpGauge");
        this.timer = GameObject.Find("GameTimer");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hpgauge.GetComponent<Image>().fillAmount != 0f)
        {
            time += Time.deltaTime;
            this.timer.GetComponent<Text>().text = time.ToString("F2");
        }
        else
        {

            this.timer.GetComponent<Text>().text = time.ToString("F2") + " Game Over!";
        }
    }

    public void DecreaseHp()
    {
        this.hpgauge.GetComponent<Image>().fillAmount -= 0.25f;
    }
    
}


