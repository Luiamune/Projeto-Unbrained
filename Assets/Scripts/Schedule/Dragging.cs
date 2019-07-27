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
    private TouchPhase touchPhase;
    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTouch()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
                transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);
            }
        }
        //initialposition = Camera.main.ScreenToWorldPoint(mouse);
        //objectposition = transform.position;
        //diference = initialposition - objectposition;
    }
    //private void OnMouseDrag()
   // {
       // mouse = Input.mousePosition;
       // mouse = Camera.main.ScreenToWorldPoint(mouse);
       // transform.position = mouse - diference;
   // }
    // Update is called once per frame
   // void Update()
   // {
   // }
}