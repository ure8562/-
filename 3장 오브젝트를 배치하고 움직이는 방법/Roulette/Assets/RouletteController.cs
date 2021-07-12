using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 회전 속도
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //클릭시 회전 속도 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }
        
        // 회전 속도 만큼 룰렛을 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);

        // 룰렛 속도 감속(감쇠)
        this.rotSpeed *= 0.993f;
    }
}
