//Nombre del Desarrollador: Ana Cecilia Maldonado Medina
//Asignatira: Estructura de datos:
//Descripcion del uso de este codigo:
/*
Este script se utilizara para generar el control del avatar jugador
*/
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{//Inicio del cuerpo de la clase

    //++++++++++área para declarar variables++++++++++

    //El tipo de datos_nombre de variable
    Rigidbody2D fisicasRB2D;

    //al declarar una variable como publica esta se podra visualizar en el inspector
    public float fuerzaSaltoPersonaje;

    public int vida;

    // serialized field cumple con el muestreo de variables en el inspector pero mantiene su acceso privado
    [SerializeField]
    float velocidadPersonaje;

   
    //************************************************

    // Start is called before the first frame update
    void Start()
    {
        // "=" sirnifica asignación
        // "GetComponent<>" lee el componente de cirto tipo
        fisicasRB2D = GetComponent<Rigidbody2D>();
        fuerzaSaltoPersonaje = 8.0f;
        velocidadPersonaje = 3.0f;
        vida = 10;
    }

    // Update is called once per frame
    void Update()
    {

        #region Movimiento personaje
        // Movimiento de desplazamiento al la derecha
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            fisicasRB2D.velocity = new Vector2(velocidadPersonaje, fisicasRB2D.velocity.y);
        }
        // Movimiento de desplazamiento al la derecha
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            fisicasRB2D.velocity = new Vector2(-velocidadPersonaje, fisicasRB2D.velocity.y);
        }
        #endregion

        #region Salto
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            fisicasRB2D.AddForce(Vector2.up * fuerzaSaltoPersonaje, ForceMode2D.Impulse);
            
        }

        #endregion

      



    }






}
