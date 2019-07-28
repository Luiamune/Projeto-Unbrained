using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schedule_Slots : MonoBehaviour
{
    public GameObject emptyObject;
    public GameObject[] vector;
    public GameObject[] value;
    public GameObject gameObjectType;
    void Start()
    {
        int i;
    vector = new GameObject[5];
        for (i = 0; i < 5; i++)
        {
            vector[i] = Instantiate(emptyObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {

        }
    }
}

