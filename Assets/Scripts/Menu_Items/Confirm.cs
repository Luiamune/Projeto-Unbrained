using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Confirm : MonoBehaviour
{
    public bool exists = false;
    public GameObject yesno; //o objeto ao qual precisa confirmar alguma ação
    public Image placeholder;
    public Button botao;
    public string nomeobjeto; // nome do objeto botão que irá ter precisar de alguma confirmação 
    // Start is called before the first frame update
    void Start()
    {
        yesno = GameObject.Find(nomeobjeto);
        placeholder = gameObject.GetComponent<Image>();
        botao = gameObject.GetComponent<Button>();
        placeholder.enabled = false;
        botao.enabled = false;
    }
    public void confirmed()
    {
        if (yesno.GetComponent<navegacao>() && yesno.GetComponent<navegacao>().yes == true)
        {
            placeholder.enabled = true;
            botao.enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
