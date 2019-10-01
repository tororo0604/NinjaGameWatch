using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{

    
    public float downTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("Down", 0f, downTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Down()
    {
        transform.Translate(0,-1,0);
    }
}
