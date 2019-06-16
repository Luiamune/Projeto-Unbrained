using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mechanicaEvento : MonoBehaviour
{
    // Start is called before the first frame update
    private Image card;
    public GameObject Objeto;
    void Start()
    {
       card = gameObject.GetComponent<Image>();
        desliga();
    }
    public void evento_flip()
    {

    }
    void liga()
    {
        Objeto.SetActive(true);
        card.enabled = false;
    }
    void desliga()
    {
        Objeto.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
