using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios1
{
    public class Ejercicio6 : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera.transform.position = new Vector3(0, 0, 0);
            GameObject esfera2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera2.transform.position = new Vector3(100, 0, 0);
        }
    }
}