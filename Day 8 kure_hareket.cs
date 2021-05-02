using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kure_hareket : MonoBehaviour
{
    Vector3 yon;
    public float hiz;

    void Start()
    {
        yon = Vector3.forward; //ileri hareket (0,0,1)
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) //mouse'un sol tusuna basildiysa
        {//x = left, z = forward
            if (yon.x==0) //x e gitmiyorum z yonunde gidiyorum
            {
                yon = Vector3.left; 
            }
            else //yani x yonunde gidiyorum
            {
                yon = Vector3.forward; //z ye dondur
            }
        }
    }

    void FixedUpdate()
    {
        Vector3 kure_move = yon * Time.deltaTime * hiz; //kure hareket vektoru
        transform.position += kure_move; //
    }
}
