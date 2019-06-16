using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehavior : MonoBehaviour
{
    public float Som = 0f;
    public float Musica = 0f;
    public Slider musica;
    public Slider som;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetMusic();
    }
    public void GetMusic()
    {
        Musica = musica.value;
         Som = som.value;
    }
}