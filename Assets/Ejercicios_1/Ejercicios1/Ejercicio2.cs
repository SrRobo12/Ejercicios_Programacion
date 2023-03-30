using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios1
{
    public class Ejercicio2 : MonoBehaviour
    {
        private GameObject Ej2;

        public void Start()
        {
            Ej2 = new GameObject("Ejercicio02");
            Ej2.transform.position = new Vector3(111.1f, -5f, 4.5f);
        }
    }
}