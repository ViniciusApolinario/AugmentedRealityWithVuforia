using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BehaviourCanvas : MonoBehaviour {

    private Text nammed;
    private Text moleculename;
    private Renderer rendi;

    private int count;

    void Start()
    {
        nammed = GameObject.Find("TextCanvas").GetComponent<Text>();
        moleculename = GameObject.Find("MolName").GetComponent<Text>();     
        nammed.text = "Tetraedrica";
        moleculename.text = "Gás Metano - CH4";
        count = 0;

    }
    //contador de 0 a X , controlado pelo botão
    public void Contador()
    {
        // 6 itens na lista
        
        count++;
        if (count > 5) count = 0;
        Drawer();

    }
    public void Drawer()
    {
        switch (count)
        {
            case 0:
                Debug.Log("case 0");
                nammed.text = "Tetraedrica";
                moleculename.text = "Gás Metano - CH4";
                this.transform.GetChild(1).gameObject.SetActive(true);
                this.transform.GetChild(2).gameObject.SetActive(false);
                this.transform.GetChild(3).gameObject.SetActive(false);
                this.transform.GetChild(4).gameObject.SetActive(false);
                this.transform.GetChild(5).gameObject.SetActive(false);
                this.transform.GetChild(6).gameObject.SetActive(false);

                break;
            case 1:
                Debug.Log("case 1");
                nammed.text = "Piramidal";
                moleculename.text = "Amônia - NH3";
                this.transform.GetChild(1).gameObject.SetActive(false);
                this.transform.GetChild(2).gameObject.SetActive(true);
                this.transform.GetChild(3).gameObject.SetActive(false);
                this.transform.GetChild(4).gameObject.SetActive(false);
                this.transform.GetChild(5).gameObject.SetActive(false);
                this.transform.GetChild(6).gameObject.SetActive(false);
                break;
            case 2:
                Debug.Log("case 2");
                nammed.text = "Triangular Plana";
                moleculename.text = "Trifluoreto De Boro - BF3";
                this.transform.GetChild(1).gameObject.SetActive(false);
                this.transform.GetChild(2).gameObject.SetActive(false);
                this.transform.GetChild(3).gameObject.SetActive(true);
                this.transform.GetChild(4).gameObject.SetActive(false);
                this.transform.GetChild(5).gameObject.SetActive(false);
                this.transform.GetChild(6).gameObject.SetActive(false);
                break;
            case 3:
                Debug.Log("case 3");
                nammed.text = "Angular";
                moleculename.text = "Agua - H20";
                this.transform.GetChild(1).gameObject.SetActive(false);
                this.transform.GetChild(2).gameObject.SetActive(false);
                this.transform.GetChild(3).gameObject.SetActive(false);
                this.transform.GetChild(4).gameObject.SetActive(true);
                this.transform.GetChild(5).gameObject.SetActive(false);
                this.transform.GetChild(6).gameObject.SetActive(false);
                break;
            case 4:
                Debug.Log("case 4");
                nammed.text = "Linear";
                moleculename.text = "Gás Carbonico - CO2";
                this.transform.GetChild(1).gameObject.SetActive(false);
                this.transform.GetChild(2).gameObject.SetActive(false);
                this.transform.GetChild(3).gameObject.SetActive(false);
                this.transform.GetChild(4).gameObject.SetActive(false);
                this.transform.GetChild(5).gameObject.SetActive(true);
                this.transform.GetChild(6).gameObject.SetActive(false);
                break;
            case 5:
                nammed.text = "?";
                moleculename.text = "n-butano";
                this.transform.GetChild(1).gameObject.SetActive(false);
                this.transform.GetChild(2).gameObject.SetActive(false);
                this.transform.GetChild(3).gameObject.SetActive(false);
                this.transform.GetChild(4).gameObject.SetActive(false);
                this.transform.GetChild(5).gameObject.SetActive(false);
                this.transform.GetChild(6).gameObject.SetActive(true);
                break;
                

            
        }
        
    }

    public void DrawnerLewis()
    {
        switch (count)
        {
            case 0:
                this.transform.GetChild(1).gameObject.SetActive(true);
                //this.transform.GetChild(1).GetComponent.<Renderer>().
                rendi = this.GetComponentInChildren<Renderer>();
               // rendi.material = new Material(Resources.Load)

                break;
            case 1:
                break;

        }



    }

    // Update is called once per frame
    void Update () {        
        
    }
}
