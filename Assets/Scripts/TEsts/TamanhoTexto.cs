using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamanhoTexto : MonoBehaviour
{
    public ResizeObj father;
    public RectTransform fatherrect;
    public float scalax;
    public float scalay;
    // Start is called before the first frame update
    void Start()
    {
        float currentscalex;
        float currentscaley;

        father = gameObject.transform.parent.gameObject.GetComponent<ResizeObj>();
        fatherrect = gameObject.transform.parent.gameObject.GetComponent<RectTransform>();
        Debug.Log(father.Foriginalheight);
        Debug.Log(father.Foriginalwidth);
        Debug.Log(fatherrect.rect.width);
        Debug.Log(fatherrect.rect.height);

        currentscalex = gameObject.GetComponent<RectTransform>().localScale.x;
        currentscaley = gameObject.GetComponent<RectTransform>().localScale.y;
        rescaling(currentscalex, currentscaley);
    }
    public void rescaling(float currentscalex, float currentscaley)
    {
        scalax = fatherrect.rect.width/father.father.rect.width;
        scalay = fatherrect.rect.height / father.father.rect.height;

        gameObject.GetComponent<RectTransform>().localScale = new Vector3(currentscalex / scalax, currentscaley / scalax, 1);
        
    }
    // Update is called once per frame
    void Update()
    {
    }
}
