using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSchedule : MonoBehaviour
{

    public GameObject Schedule;

    public void OpenPanel()
    {
        Animator animator = Schedule.GetComponent<Animator>();
        if (animator != null)
        {
            bool isOpen = animator.GetBool("open");
            animator.SetBool("open", !isOpen);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
