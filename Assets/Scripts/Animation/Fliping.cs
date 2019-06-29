using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliping : MonoBehaviour
{
    public Animator Flip;
    public Vector2 temp;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void flipping()
    {
        if (Flip.GetCurrentAnimatorStateInfo(0).IsName("Event-flip"))           
        {
            Flip.SetBool("Finished", true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
