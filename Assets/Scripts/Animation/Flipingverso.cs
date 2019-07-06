using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipingverso : MonoBehaviour
{
    public Fliping carta; // script do mainimage 
    public Animator verso; // animação das "choices"
    public bool played = false; // pra verificar se já rodou a ultima animação
    // Start is called before the first frame update
    void Start()
    {
        verso = gameObject.GetComponent<Animator>();
    }
    void anima()// função que atua encima da animação do objetos "Choice" ida
    {
        verso.SetBool("Descent", true);
        if(carta.liberageral2 == true && carta.tempo >= 1 && played == false)
        {
            verso.SetBool("Ascent", true);
            verso.Play("Flip-choices-back");
            played = true;
        }
    }
    public void anima2()//função que atua encima da animação do objetos "Choice" volta
    {
        if (played == false)
        {
            verso.SetBool("Ascent", true);
            verso.Play("Flip-choices-back");
            carta.liberageral2 = true;
            played = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(carta.liberageral == true)
        {
            anima();
        }
    }
}
