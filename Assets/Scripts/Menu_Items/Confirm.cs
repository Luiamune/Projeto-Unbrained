using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Confirm : MonoBehaviour
{
    public bool exists;
    public GameObject[] yesno; //o objeto ao qual precisa confirmar alguma ação

    public void Start()
    {
        unconfirmed();
    }

    public void confirmed()
    {
        exists = false;
        if (!exists)
        {
            foreach (GameObject g in yesno)
            {
                g.SetActive(true);
            }
        }
    }
    public void unconfirmed()
    {
        exists = true;
        if (exists)
        {
            foreach (GameObject g in yesno)
            {
                g.SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
