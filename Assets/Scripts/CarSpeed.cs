using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSpeed : MonoBehaviour
{
    public Text text;
    public float speed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = (rb.velocity.magnitude) * 2.0f;
        text.text = "KM/H: "+ speed.ToString("F2");
    }
}
