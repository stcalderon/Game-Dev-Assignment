using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public float speed = 2f;
    //"public" means it is an action that can be seen happening
    //everything is "private" by default

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = this.transform.position;
        //this is the current position value of the transform object

        temp.x = temp.x + speed * Time.deltaTime;
        //need to add x to the value of temp so it moves
        //alt way of writing temp.x = temp.x + speed is:
        //temp.x += speed
        //to make it move over a course of time vs per frame you add the * Time

        this.transform.position = temp;
        //assign temp to the new position of the object
        //basically teleporting the object really quickly in small amounts
    }
}
