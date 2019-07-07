using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class mechanicaEvento : MonoBehaviour
{
    // Start is called before the first frame update
    private Image card;
    public FileInfo theSourceFile;
    protected StreamReader reader = null;
    public int sanidade;
    public string path;
    public string texti;
    public TextAsset filing;
    public GameObject [] Objeto;
    public string [] historia;
    public int temp = 0;
    void Start()
    {
        path = @"\Assets\Scripts\test.txt";
        if (!File.Exists(path))
            Debug.Log("existe");
        theSourceFile = new FileInfo(@"C:\Users\User\Documents\Projeto Unbrained\Assets\Scripts\test.txt");// colocar diretório onde se encontra o arquivo
        reader = theSourceFile.OpenText();
        while (texti != null)
        {
            texti = reader.ReadLine();
            historia[temp] = texti;
            Debug.Log(texti);
            temp += 1;
        }
        
    }
    public void eventos ()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
