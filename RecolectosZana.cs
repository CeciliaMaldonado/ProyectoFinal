//Nombre del Desarrollador: Ana Cecilia Maldonado Medina
//Asignatira: Estructura de datos:
//Descripcion del uso de este codigo:
/*
Este script se utilizara para recoger la zanahoria
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectosZana : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            //gameObject.transform.GetChild(0).gameObject.SetActive(true);

            FindObjectOfType<ZanahoriasManager>().TodaslaszanaRecofidas();

            Destroy(gameObject, 0.2f);
        }
    }

}
