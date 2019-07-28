using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schedule : MonoBehaviour
{
    public GameObject panel;


    public void openPanel()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("Open");
                animator.SetBool("Open", !isOpen);
            }
        }
    }

}
    