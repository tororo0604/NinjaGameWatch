using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    public float acceleration = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xSpeedControll();
        ySpeedControll();
    }

    void xSpeedControll(){
        transform.position = new Vector3(transform.position.x + xSpeed * 0.01f, transform.position.y, 0f);
        if(Input.GetKey(KeyCode.RightArrow)){
            xSpeed += acceleration * 0.01f;
        } else if(Input.GetKey(KeyCode.LeftArrow)){
            xSpeed -= acceleration * 0.01f;
        } else {
            xSpeed = speedDown(xSpeed);
        }
    }

    void ySpeedControll(){
        transform.position = new Vector3(transform.position.x, transform.position.y + ySpeed * 0.01f, 0f);
        if(Input.GetKey(KeyCode.UpArrow)){
            ySpeed += acceleration * 0.01f;
        } else if(Input.GetKey(KeyCode.DownArrow)){
            ySpeed -= acceleration * 0.01f;
        } else {
            ySpeed = speedDown(ySpeed);
        }
    }

    float speedDown(float speed){
        if(speed < 0.01f && speed > -0.01f){
            speed = 0f;
        }else if(speed > 0){
            speed -= acceleration * 0.01f;
        }else if(speed < 0){
            speed += acceleration * 0.01f;
        }
        return speed;
    }
}
