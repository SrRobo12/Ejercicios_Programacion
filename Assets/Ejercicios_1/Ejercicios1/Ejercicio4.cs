using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios1
{
    public class Ejercicio4 : MonoBehaviour
    {
        //Ej4
        private GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        public void Start()
        {
            esfera.AddComponent<Rigidbody>();
        }
    }
}