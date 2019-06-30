using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Status_Behavior : MonoBehaviour
{public int  Vida = 100;
public int  Fome = 100;
public int Sono=100;
public int Higiene=100;
public int Sanidade=100;
    public Image vida;
    public Image sono;
    public Image fome;
    public Image higiene;
    public Image sanidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StatusExibit()
    {
        if (Vida > 50)
        {
            vida.enabled = false;
        }
        else
        {
            vida.enabled = true;
        }
        if (Sono > 50)
        {
            sono.enabled = false;
        }
        else
        {
            sono.enabled = true;
        }
        if (Fome > 50)
        {
            fome.enabled = false;
        }
        else
        {
            fome.enabled = true;
        }
        if (Higiene > 50)
        {
            higiene.enabled = false;
        }
        else
        {
            higiene.enabled = true;
        }
        if (Sanidade > 50)
        {
            sanidade.enabled = false;
        }
        else
        {
            sanidade.enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        StatusExibit();
    }
}
