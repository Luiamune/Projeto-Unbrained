using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rotate : MonoBehaviour {
	private float temp = 0;
	private bool rot = false;
    private float inicio;
    private float fim;
    private int direct=0;

    public float pos3;
    public float pos2;
    public float pos;

    

    public Sprite dir;
    public Sprite dirc;
    public Sprite esq;
    public Sprite esqc;

    private Vector2 mouse;
    private Vector2 my;
    private Vector2 dif;
    private Vector2 ini;

    private Vector2 novo;
    private Vector2 novo2;

    private float move;

    public GameObject pref;
    public GameObject pref2;
    private GameObject inicial;
    private GameObject inicial2;
	// Use this for initialization
	void Start () {
		
        
	}

	void OnMouseDrag(){
        novo = new Vector2(gameObject.transform.position.x + pos, gameObject.transform.position.y + pos2);
        novo2 = new Vector2(gameObject.transform.position.x - pos3, gameObject.transform.position.y + pos2);
        inicial2.transform.position = novo2;
        inicial.transform.position = novo;
        if (SceneManager.GetActiveScene().buildIndex != 6 && SceneManager.GetActiveScene().buildIndex != 33)
        {
            if (Time.timeScale == 1)
            {
               // mouse = Input.GetTouch(0).position;
               mouse = Input.mousePosition;
                mouse = Camera.main.ScreenToWorldPoint(mouse);
                //dif = mouse - (Vector2)transform.position;
                transform.position = mouse - dif;




               // if (Input.GetTouch(1).phase == TouchPhase.Began  && rot == false)
                if (Input.GetButtonDown("Rotate") && rot == false && Input.GetMouseButton(0))
                {
                    // fim = Input.GetTouch(1).position.x;
                   // inicio = Input.GetTouch(0).position.x;
                    rot = true;
                    direct = 0;
                }
                if (Input.GetButtonDown("Rotate1") && rot == false && Input.GetMouseButton(0))
                {
                    rot = true;
                    direct = 1;
                }
            }
        }
	}


	void OnMouseDown(){
        my = transform.position;
       // ini = Input.GetTouch(0).position;
        ini = Input.mousePosition;
        ini = Camera.main.ScreenToWorldPoint(ini);
        dif = ini - my;

        if (SceneManager.GetActiveScene().buildIndex != 6 && SceneManager.GetActiveScene().buildIndex != 33)
        {
            inicial = (GameObject)Instantiate(pref);
            inicial.transform.position = novo;
            inicial.SetActive(true);

            inicial2 = (GameObject)Instantiate(pref2);
            inicial2.transform.position = novo2;
            inicial2.SetActive(true);
        }
        if (Time.timeScale == 1)
        {
           
        }
	}


    // Update is called once per frame
    void FixedUpdate()
    {
        // movimento
        novo = new Vector2(gameObject.transform.position.x + pos, gameObject.transform.position.y + pos2);
        novo2 = new Vector2(gameObject.transform.position.x - pos3, gameObject.transform.position.y + pos2);
        // rotacao
        if (Time.timeScale == 1)
        {

            if (rot == true && direct == 1)
            {
                SpriteRenderer claro2 = inicial2.GetComponent<SpriteRenderer>();
                claro2.sprite = esqc;
                transform.Rotate(0, 0, 5);
                temp += 5;
                if (temp == 45)
                {
                    
                    rot = false;
                    temp = 0;
                    claro2.sprite = esq;
                }
                
                    // if (fim - inicio < 0)
                    // {
                    // transform.Rotate(0, 0, 5);
                    //  temp += 5;
                    //  if (temp == 45)
                    //  {
                    //   t.count += 1;
                    //   rot = false;
                    //    temp = 0;
                    // }
                    //  }
                    // else if (fim - inicio > 0)
                    // {
                    //    transform.Rotate(0, 0, -5);
                    //   temp += 5;
                    //    if (temp == 45)
                    //    {
                    //   t.count += 1;
                    //        rot = false;
                    //       temp = 0;
                    //    }
                    // }
                }
            if (rot == true && direct == 0)
            {
                SpriteRenderer claro = inicial.GetComponent<SpriteRenderer>();
                claro.sprite = dirc;
                transform.Rotate(0, 0, -5);
                temp += 5;
                if (temp == 45)
                {
                    
                    rot = false;
                    temp = 0;
                    claro.sprite = dir;
                }
            }
            }
        //if(Input.GetTouch(0).phase == TouchPhase.Canceled && rot == false && temp == 0)
        if (Input.GetMouseButton(0) == false && rot == false && temp == 0)
        {
            Destroy(inicial);
            Destroy(inicial2);
        }
    }


    
}
