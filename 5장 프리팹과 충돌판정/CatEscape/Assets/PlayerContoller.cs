using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -9)
        {
            transform.Translate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 9)
        {
            transform.Translate(3, 0, 0);
        }
    }

    public void LButtonDown()
    {
        if (transform.position.x > -9)
        {
            transform.Translate(-3, 0, 0);
        }
    }

    public void RButtonDown()
    {
        if (transform.position.x < 9)
        {
            transform.Translate(3, 0, 0);
        }
    }
}
