using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AIHuevo : MonoBehaviour
{
    public float velocidad = 3.0f;

    public float TiempodEspera;

    public Transform[] puntos;

    private float StartTiempoEspera = 1;

    private int i = 0;

    private Vector2 actualPos;


    // Start is called before the first frame update
    void Start()
    {
        TiempodEspera = StartTiempoEspera;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntos[i].transform.position, velocidad*Time.deltaTime);

        if (Vector2.Distance(transform.position,puntos[i].transform.position)<0.1f)
        {
            if (TiempodEspera <= 0)
            {
                if (puntos[i]!=puntos[puntos.Length-1])
                {
                    i++;

                }
                else
                {
                    i = 0;
                }

                TiempodEspera = StartTiempoEspera;
            }
            else
            {
                TiempodEspera -= Time.deltaTime;
            }
        }



    }
}
