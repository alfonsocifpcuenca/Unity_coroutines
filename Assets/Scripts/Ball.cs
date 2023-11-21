using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float velocidad = 5f; 
    public float limiteDerecho = 5f; // L�mite derecho
    public float limiteIzquierdo = -5f; // L�mite izquierdo

    private int direccion = 1;

    void Update()
    {
        // Obt�n la posici�n actual de la bola
        Vector3 posicion = transform.position;

        // Calcula el nuevo valor de la posici�n en el eje X
        float nuevaPosX = posicion.x + direccion * velocidad * Time.deltaTime;

        // Verifica si alcanz� los l�mites y cambia la direcci�n si es necesario
        if (nuevaPosX > limiteDerecho)
        {
            nuevaPosX = limiteDerecho;
            direccion = -1; // Cambia la direcci�n a izquierda
        }
        else if (nuevaPosX < limiteIzquierdo)
        {
            nuevaPosX = limiteIzquierdo;
            direccion = 1; // Cambia la direcci�n a derecha
        }

        // Asigna la nueva posici�n a la bola
        transform.position = new Vector3(nuevaPosX, posicion.y, posicion.z);
    }
}
