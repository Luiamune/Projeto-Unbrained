using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragdrop : MonoBehaviour
{
    private Vector2 position1;
    private Vector2 position2;
    private Vector2 initialposition;
    private Vector2 mouse;
    private Vector2 objectposition;
    private Vector2 diference;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        mouse = Input.mousePosition;
        initialposition = Camera.main.ScreenToWorldPoint(mouse);
        objectposition = transform.position;
        diference = initialposition - objectposition;
    }
    private void OnMouseDrag()
    {
        mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToWorldPoint(mouse);
        transform.position = mouse - diference;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
