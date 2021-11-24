using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeContoll : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed=5f;
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Vertical"));
        transform.Translate(Input.GetAxis("Vertical")*speed*Time.deltaTime,0,Input.GetAxis("Horizontal")*speed*Time.deltaTime);
    }
}
