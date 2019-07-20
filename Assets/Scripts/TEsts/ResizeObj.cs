using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeObj : MonoBehaviour
{
    public RectTransform son;
    public RectTransform father;

    public float Foriginalheight;
    public float Foriginalwidth; // F para father, tamanho original do parent
    public float proporçãoW;
    public float proporçãoH;
    public float SoriginalHeight; // S para Son, tamnho desta imagem
    public float SoriginalWidth;
    private void Awake()
    {
    

        father = gameObject.transform.parent.gameObject.GetComponent<RectTransform>();
        son = gameObject.GetComponent<RectTransform>();
        Foriginalheight = father.rect.height;
        Foriginalwidth = father.rect.width;

        SoriginalHeight = son.rect.height;
        SoriginalWidth = son.rect.width;
    }
    // Start is called before the first frame update

    public void reajuste()
    {
        son.sizeDelta = new Vector2(father.rect.width * proporçãoW, father.rect.height * proporçãoH);
        Debug.Log(father.rect.width);
    }
    void Start()
    {
        proporçãoH = SoriginalHeight/Foriginalheight;
        proporçãoW = SoriginalWidth / Foriginalwidth;
        
    }

    // Update is called once per frame
    void Update()
    {
        reajuste();
    }
}
