//Nombre del Desarrollador: Ana Cecilia Maldonado Medina
//Asignatira: Estructura de datos:
//Descripcion del uso de este codigo:
/*
Este script se utilizara para la destruccion del player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
