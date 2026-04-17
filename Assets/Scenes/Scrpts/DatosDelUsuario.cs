using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
        public string nombre;
        public int edad;
        public float estaturs_en_metros;
        public bool donante;
    void Start()
    {
        Debug.Log("Mi nombre es " + nombre + ", tengo " + edad + " años, mi eststura es " + estaturs_en_metros + " y es " + donante + " que soy donante");
    }

    void Update()
    {
        
    }
}
