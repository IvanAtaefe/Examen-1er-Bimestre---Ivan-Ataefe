using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen : MonoBehaviour
{
    //Anoto los datos de la consigna y declaro las constantes
    const float totalcampo = 20400;
    const float totalplatea = 16200;
    const float preciocampo = 1200;
    const float precioplatea = 2000;
    //Lo pongo en float, pese a que me queden números en notación cientifica, porque estoy manejando precios
    public float entradasvendidascampo;
    public float entradasvendidasplatea;
    const float totalentradas = totalcampo + totalplatea;
    bool error = false;
    void Start()
    {
        //Punto 4
        //Chequeo cada caso de error y escribo en la consola si encuentro uno.
            if (entradasvendidascampo < 0)
            {
                error = true;
                Debug.Log("¡Error! Las entradas vendidas en Campo no pueden ser menores a 0");
            }
            if (entradasvendidasplatea > totalplatea)
            {
                error = true;
                Debug.Log("¡Error! Las entradas vendidas en Platea no pueden ser mayores a la cantidad de entradas existentes");
            }
            if (entradasvendidascampo > totalcampo)
            {
                error = true;
                Debug.Log("¡Error! Las entradas vendidas en Campo no pueden ser mayores a la cantidad de entradas existentes");
            }
            if (entradasvendidasplatea < 0)
            {
                error = true;
                Debug.Log("¡Error! Las entradas vendidas en Campo no pueden ser menores a 0");
            }
        //Si no se encontro un error, empiezo a hacer calculos
        if (error == false)
        {
            //Punto 1
                Debug.Log("Se recaudo en Campo unos $" + (entradasvendidascampo * preciocampo) + "; ");
                Debug.Log("En platea unos $" + (entradasvendidasplatea * precioplatea) + ";");
                Debug.Log("Formando un total de $" + ((entradasvendidasplatea * precioplatea) + (entradasvendidascampo * preciocampo)) + ".");
            //Punto 2
                if (entradasvendidascampo == totalcampo){
                    Debug.Log("Campo: Sold Out!;");
                }
                else
                {
                    Debug.Log("Quedaron " + (totalcampo - entradasvendidascampo) + " entradas en Campo;");
                }
                if (entradasvendidasplatea == totalplatea)
                {
                    Debug.Log("Platea: Sold Out!");
                }
                else
                {
                    Debug.Log("Quedaron " + (totalplatea - entradasvendidasplatea) + " entradas en Platea;");
                }
            //Punto 3
                if (entradasvendidascampo + entradasvendidasplatea > totalentradas / 2)
                {
                    Debug.Log("¡El festival fue un éxito!");
                }
                else
                {
                    Debug.Log("Debemos mejorar la convocatoria");
                }
        }
        //Si encuentra un error, no hace nada
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
