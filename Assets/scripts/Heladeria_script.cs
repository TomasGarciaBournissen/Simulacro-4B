using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria_script : MonoBehaviour
{
    public string gustoDeseado;
    public float PesoDeseado;
    float precioKilo = 1250;
    float descuento = (1 - 0.10f);
    float precioTotal;
    // Start is called before the first frame update
    void Start()
    {
        float precioGramo = precioKilo / 1000;
        gustoDeseado= gustoDeseado.ToUpper();

        if (PesoDeseado < 250 || PesoDeseado > 3000 || (gustoDeseado != "CHO" && gustoDeseado != "FRU" && gustoDeseado != "DDL"))
        {
            Debug.Log("Peso mayor a 3000 gramos o menor a 250 gramos o codigo de sabor invalido, revise los datos ingresados y vuelva a intentar");
        }
        else if (gustoDeseado == "CHO" || gustoDeseado == "DDL")
        {
            precioTotal = precioGramo * PesoDeseado;
            Debug.Log("Su total son " + precioTotal);
        }
        else
        {
            precioTotal = (precioGramo * PesoDeseado) * descuento;
            Debug.Log("Su total son " + precioTotal);
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        




    }
}
