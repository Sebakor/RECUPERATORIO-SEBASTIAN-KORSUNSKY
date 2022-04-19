using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJALTURA : MonoBehaviour
{

    public int edad;
    public float altura;
    





    void Start()
    {
        if (altura >= 1.2f && edad >= 13 ) 
        {
            Debug.Log(" Acceso permitodo ");

        }
        else
        {
            Debug.Log(" Acceso denegado " );
        }

        if (altura < 1f && edad < 1)
        {
            Debug.Log(" Error edad o altura no puede ser menor que 1 ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
