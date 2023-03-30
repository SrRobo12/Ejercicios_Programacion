using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios1
{
    public class Ejercicio8 : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cubo.transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject cubo2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cubo2.transform.localScale = cubo.transform.localScale * 2f;
            GameObject cubo3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cubo3.transform.localScale = cubo2.transform.localScale * 2f;
        }
    }
}