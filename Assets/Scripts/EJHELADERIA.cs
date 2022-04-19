using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJHELADERIA : MonoBehaviour

{
    public string Gusto1;
    public string Gusto2;
    public string Gusto3;

    string DDL;
    string FRU;
    string CHO;


    public int CantidadDeHelado; 




    void Start()
    {
        if (Gusto1 != DDL && Gusto1 != FRU &&  Gusto1 != CHO && Gusto3 != DDL && Gusto3 != FRU && Gusto3 != CHO && Gusto3 != DDL && Gusto3 != FRU && Gusto3 != CHO)
        {
            Debug.Log(" Error  gusto de helado no encontrado ");
        }

        if (CantidadDeHelado < 250 || CantidadDeHelado > 3000)
        {
            Debug.Log(" Error  supero  no alcanzo la cantidad de helado requerida ");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
