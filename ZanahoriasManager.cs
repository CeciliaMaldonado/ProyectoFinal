//Nombre del Desarrollador: Ana Cecilia Maldonado Medina
//Asignatira: Estructura de datos:
//Descripcion del uso de este codigo:
/*
Este script se utilizara para el marcador de zanahorias
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZanahoriasManager : MonoBehaviour
{
  
    public Text ZanahoriasRecogidas;

    public Text ZanahoriasTotales;

    private int TotaldeZanahorias;

    public void TodaslaszanaRecofidas()
    {
        if (transform.childCount ==1)
        {
            Debug.Log("mas vida");
        }

    }


    // Start is called before the first frame update
    private void Start()
    {
        TotaldeZanahorias = transform.childCount;
    }


    // Update is called once per frame
    private void Update()
    {
        //calcula las zanahorias que estan en escena
       ZanahoriasTotales.text = TotaldeZanahorias.ToString();
        //calcula la zanahorias recolectadas
        ZanahoriasRecogidas.text = transform.childCount.ToString();
    }
}
