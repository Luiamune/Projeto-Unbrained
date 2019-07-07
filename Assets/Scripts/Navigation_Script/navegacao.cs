using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class navegacao : MonoBehaviour
{
    public Scene current;
    public string naming;
    // Start is called before the first frame update
    void Start()
    {
        current = SceneManager.GetActiveScene();
        naming = current.name;
    }
    public void navegate()
    {
        Debug.Log("nome");
        if(naming == "Panel" && gameObject.name == "configButton")
        {
            SceneManager.LoadScene("Config");
        }
       else if (naming == "Panel" && gameObject.name == "playButton")
        {
            SceneManager.LoadScene("Teste_Mecanica1");
        }
        else if (naming == "Panel" && gameObject.name == "buttonCredit")
        {
            SceneManager.LoadScene("Credits");
        }
        else if (naming == "Config" && gameObject.name == "Button")
        {
            SceneManager.LoadScene("Panel");
        }
        else if (naming == "Credits" && gameObject.name == "Voltar")
        {
            SceneManager.LoadScene("Panel");
        }
        else if (naming == "Logo" && gameObject.name == "Logo")
        {
            SceneManager.LoadScene("Panel");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
