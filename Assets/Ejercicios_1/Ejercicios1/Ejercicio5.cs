using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios1
{
    public class Ejercicio5 : MonoBehaviour
    {
        private GameObject[] cajas = new GameObject[30];

        // Start is called before the first frame update
        private void Start()
        {
            for (int i = 0; 1 < cajas.Length; i++)
            {
                GameObject.CreatePrimitive(PrimitiveType.Cube);
                cajas[i].transform.position = new Vector3(0, 0, i);
            }
        }
    }
}