using UnityEngine;
using System.Collections;

public class cameraad : MonoBehaviour {
	public float aspect;
    public RectTransform tela;
    public float altura;
    public float largura;
	// Use this for initialization
	void Awake () {
        Debug.Log(Screen.height);
        Debug.Log(Screen.height * Camera.main.aspect);
        //Camera.main.aspect = aspect;
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
