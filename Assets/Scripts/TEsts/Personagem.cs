using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public GameObject[] paths;
    public RectTransform destination;
    public bool meio;
    public Vector3 currentpos;
    // Start is called before the first frame update
    void Start()
    {
        paths = GameObject.FindGameObjectsWithTag("Path");
        
    }
    public void Tomeiofirst(RectTransform destino)
    {       
        destination = paths[0].GetComponent<RectTransform>();
        currentpos = gameObject.GetComponent<RectTransform>().localPosition;
        StartCoroutine(moving(destino));
        
    }
    public void Moveto(RectTransform destino)
    {
        StopCoroutine("moving");
        destination = destino.GetComponent<RectTransform>();
        currentpos = gameObject.GetComponent<RectTransform>().localPosition;
        StartCoroutine(moving(destino));
    }

    public IEnumerator moving(RectTransform destiny)
    {
        float step = 0;
        while (gameObject.GetComponent<RectTransform>().localPosition != destination.localPosition)
        {
            gameObject.GetComponent<RectTransform>().localPosition = Vector3.Lerp(currentpos, destination.localPosition, step += Time.deltaTime);
            if (gameObject.GetComponent<RectTransform>().localPosition == destination.localPosition)
            {                     
                Moveto(destiny);
                step = 0;
            }
            yield return null;
        }        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
