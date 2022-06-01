using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float m = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().AddForce(new Vector2(m * speed , 1));
    }
}
