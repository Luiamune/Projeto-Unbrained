using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalepics : MonoBehaviour
{
    public cameraad Tela;
    private RectTransform estaPic;
    // Start is called before the first frame update
    void Start()
    {
        estaPic = gameObject.GetComponent<RectTransform>();
        reajuste();
    }
    public void reajuste()
    {
        estaPic.sizeDelta  = new Vector2(Tela.largura ,Tela.altura); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
