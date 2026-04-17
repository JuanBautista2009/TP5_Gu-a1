using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculoPersonalizado : MonoBehaviour
{
    public float num1;
    public float num2;
    public float resultadoSuma;
    public float resultadoResta;
    public float resultadoMultiplicacion;
    public float resultadoDivision;

    void Start()
    {
        resultadoSuma = num1+num2;
        Debug.Log("El resultado de la suma entre " + num1 + " y " + num2 " es: " + resultadoSuma);
        resultadoResta = num1-num2;
        Debug.Log("El resultado de la resta entre " + num1 + " y " + num2 " es: " + resultadoResta);
        resultadoMultiplicacion = num1*num2;
        Debug.Log("El resultado de la multiplicacion entre " + num1 + " y " + num2 " es: " + resultadoMultiplicacion);
        resultadoDivision = num1/num2;
        Debug.Log("El resultado de la division entre " + num1 + " y " + num2 " es: " + resultadoDivision);
        }

    void Update()
    {
        
    }
}
