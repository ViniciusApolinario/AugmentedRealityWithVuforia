using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorMoles : MonoBehaviour {

    public bool IsLewis = false;
    public Material Prefab;
    public Material Lewies;
    private GameObject[] Handler = null;
    private int HC;
 
    
	// Use this for initialization
	void Start () {

       //Prefab = AssetDatabase.FindAssets();



    }
	public void Localizador()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Handler = GameObject.FindGameObjectsWithTag("ligacao");
            HC = Handler.Length;
            for(int i= 0 ; i<HC ; i++)
            {
                Handler[i].gameObject.GetComponent<Renderer>().material = Lewies;
            }
            Handler = null;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Handler = GameObject.FindGameObjectsWithTag("ligacao");
            HC = Handler.Length;
            for (int i = 0; i < HC; i++)
            {
                Handler[i].gameObject.GetComponent<Renderer>().material = Prefab;
            }
            Handler = null;
        }
    }
	// Update is called once per frame
	void Update () {
        Localizador();
    }
}
