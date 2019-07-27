using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamanhoTexto : MonoBehaviour
{
    public float currentscalex;
    public float currentscaley;
    public float currentscalex2;
    public float currentscaley2;
    public ResizeObj father;
    public RectTransform fatherrect;
    public float scalax;
    public float scalay;
    public float once = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        father = gameObject.transform.parent.gameObject.GetComponent<ResizeObj>();
        fatherrect = gameObject.transform.parent.GetComponent<RectTransform>();       
    }
    void Start()
    {

        currentscalex = fatherrect.rect.width;
        currentscaley = fatherrect.rect.height;

        
    }
    public void rescaling(float currentscalex, float currentscaley)
    {
        currentscaley2 = fatherrect.rect.height;
        currentscalex2 = fatherrect.rect.width;
        scalax = fatherrect.rect.width/ currentscalex;
        scalay = fatherrect.rect.height / currentscaley;
        gameObject.GetComponent<RectTransform>().localScale = new Vector3(scalay/2, scalay/2, 1);
        Debug.Log(father.proporçãoH);
        Debug.Log(father.proporçãoW);
    }
    // Update is called once per frame
    void Update()
    {
        if (once < 0.5)
        {
            rescaling(currentscalex, currentscaley);
            once += Time.deltaTime;
        }
    }
}
