using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tas_firlatma : MonoBehaviour
{
    public Rigidbody2D tas_rb2D; //tasin rigidbodysini baglamak icin tanimliyoruz
    bool egerClicked = false; //mouse tiklanip tiklanmadigini kontrol etmek icin
    public Rigidbody2D bn; //baglanti noktasi rigidbody

    void Update()
    {
        if(egerClicked==true)
        {
            tas_rb2D.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);//tas mouse'u takip ediyor
        }
    }
    void OnMouseDown() //mouse ile tasa tikladigimizda
    {
        egerClicked = true;
    }
    void OnMouseUp() //mouse biraktigimizda
    {
        egerClicked = false;
    }
}
