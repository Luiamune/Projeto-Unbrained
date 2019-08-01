using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float temp = 0;
    public GameObject[] paths;
    public RectTransform destination;
    public List<RectTransform> schedule;

    public bool inicio = false;
    public int indexdaLista = 0;
    public bool meio;
    public Vector3 currentpos;
    // Start is called before the first frame update
    void Start()
    {
        paths = GameObject.FindGameObjectsWithTag("Path");
        
    }
    public void storage(RectTransform caminho)
    {
        schedule.Add(caminho);
        
    }
    public void pause()
    {
        inicio = false;
    }
    public void execucao()
    {       
        Tomeiofirst(schedule[indexdaLista]);
        inicio = true;
        //indexdaLista += 1;
        //Debug.Log(schedule.Count);
    }

    public void Tomeiofirst(RectTransform destino)
    {
        if (gameObject.GetComponent<RectTransform>().localPosition == paths[0].GetComponent<RectTransform>().localPosition)
        {
            meio = true;
            Moveto(destino);
        }
        else
        {
            destination = paths[0].GetComponent<RectTransform>();
            currentpos = gameObject.GetComponent<RectTransform>().localPosition;
            StartCoroutine(moving(destino));
        }
        
    }
    public void Moveto(RectTransform destino)
    {
        //StopCoroutine("moving");
        destination = destino.GetComponent<RectTransform>();
        currentpos = gameObject.GetComponent<RectTransform>().localPosition;
        StartCoroutine(moving(destino));
       
    }

    public IEnumerator moving(RectTransform destiny)
    {
        float step = 0;
        while (gameObject.GetComponent<RectTransform>().localPosition != destination.localPosition )
        {
            gameObject.GetComponent<RectTransform>().localPosition = Vector3.Lerp(currentpos, destination.localPosition, step += Time.deltaTime);
            if(inicio == false)
            {
                yield return null;
            }
            else if (gameObject.GetComponent<RectTransform>().localPosition == paths[0].GetComponent<RectTransform>().localPosition)
            {
                meio = true;
                Moveto(destiny);
                step = 0;

            }
            else if (gameObject.GetComponent<RectTransform>().localPosition == destination.localPosition &&
                indexdaLista < schedule.Count)
            {
                
                step = 0;
                // step = 0;                                              
                Debug.Log("end of line");
            }
            else
            {               
                meio = false;
                
            }
            yield return null;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (inicio)
        {
            temp += Time.deltaTime;
        }
        if(temp > 2.5 && schedule.Count-1 > indexdaLista)
        {
            indexdaLista += 1;
            temp = 0;
            execucao();
        }
    }
}
