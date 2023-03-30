using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicios1
{
    public class Ejercicio3 : MonoBehaviour
    {
        public void Start()
        {
            GameObject cubo = new GameObject("Cubo");
            cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.localScale = new Vector3(1, 1, 1);
            cubo.transform.localScale = Vector3.one * 2f;
        }
    }
}