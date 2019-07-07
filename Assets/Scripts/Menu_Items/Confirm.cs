using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Confirm : MonoBehaviour
{
    public bool exists = false;
    public GameObject yesno; //o objeto ao qual precisa confirmar alguma ação
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
