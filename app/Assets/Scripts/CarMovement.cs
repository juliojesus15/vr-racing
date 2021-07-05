using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(":D");   
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("XD");
        float vertical = Input.GetAxis("Vertical");
        transform.position = transform.position + vertical * transform.forward * 10f * Time.deltaTime;

        float velocidadGiro = 55f * Input.GetAxis("Horizontal");
        transform.Rotate(0f, velocidadGiro * Time.deltaTime, 0f);
    }
}
