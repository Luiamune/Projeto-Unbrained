using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliping : MonoBehaviour
{
    public Animator Flip;
    public Vector2 temp;

    public bool liberageral2 = false;
    public bool liberageral = false; 
    public bool libera = false; // libera para o inicio da animação das escolhas
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        Flip = gameObject.GetComponent<Animator>();
    }
    public void flipping()
    {
        if (Flip.GetCurrentAnimatorStateInfo(0).IsName("Event-flip"))           
        {
            Flip.SetBool("Finished", true);
            libera = true;
        }
    }
    public void temporal()// para medir o tempo das animações
    {
        if (libera == true || liberageral2 == true)
        {
            tempo += Time.deltaTime;
        }
        if (tempo > 1 && liberageral2 == false)
        {
            libera = false;
            liberageral = true;
            tempo = 0;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        temporal();
    }
}
