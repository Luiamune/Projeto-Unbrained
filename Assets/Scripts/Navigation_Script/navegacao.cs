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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
