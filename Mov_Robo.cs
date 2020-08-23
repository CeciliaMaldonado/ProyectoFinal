//Nombre del Desarrollador: Ana Cecilia Maldonado Medina
//Asignatira: Estructura de datos:
//Descripcion del uso de este codigo:
/*
Este script se utilizara para el movimiento de robo pollo
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Robo : MonoBehaviour
{

    [SerializeField]
    Vector3 puntoInicial;

    [SerializeField]
    float velocidad;

    [SerializeField]
    float extension;

    private void Start()
    {
        puntoInicial = transform.position;
    }

    private void Update()
    {
        Vector3 posSeno = new Vector3(0, Mathf.Sin(Time.time * velocidad) * extension, 0);
        transform.position = puntoInicial + posSeno;
    }

}
