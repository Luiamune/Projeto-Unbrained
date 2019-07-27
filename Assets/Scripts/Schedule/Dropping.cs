using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropping : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "drop" && Input.GetMouseButton(0) == false)
        {
            collision.gameObject.transform.position = gameObject.transform.position;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter");

    }
}