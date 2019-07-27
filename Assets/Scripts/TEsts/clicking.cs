using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class clicking : MonoBehaviour
{
    // Start is called before the first frame update
    public mechanicaEvento controle;
    public int mudanca = 5;
    public int tipo = 0;
    public Text parameter;
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        int novovalor;
        novovalor = controle.eventos(mudanca, tipo);
        parameter.text = novovalor.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
