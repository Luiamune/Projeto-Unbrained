﻿using System.Collections;
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
    public int saude;
    
    public string path;
    public string texti;
    public TextAsset filing;
    public GameObject[] Objeto;
    public List<String> historia;
    public List<Char> lining;
    public int temp = 0;
    void Start()
    {
        Uri path = new Uri(Directory.GetCurrentDirectory() + @"\Assets\Scripts\test.txt");
        Debug.Log(Directory.GetCurrentDirectory());
        if (path.IsFile)
        {
            Debug.Log("existe " + path.ToString());
        }
        else
        {
            Debug.Log("nao existe " + path.ToString());
        }
        theSourceFile = new FileInfo(path.OriginalString); // colocar diretório onde se encontra o arquivo
        reader = theSourceFile.OpenText();
        while (texti != null)
        {

            texti = reader.ReadLine();
            historia.Add(texti);
            //Debug.Log(texti);
            temp += 1;
        }
        reader.Close();
    }
    // sanidade é tipo 0
    public int eventos(int parameters, int tipo)
    {
        switch (tipo)
        {
            default:
                return 0;
            case 0:
                sanidade += parameters;
                return sanidade;               
            case 1:
                return 0;
            case 2:
                return 0;
            case 3:
                return 0;
            case 4:
                return 0;
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
