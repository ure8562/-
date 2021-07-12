using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
