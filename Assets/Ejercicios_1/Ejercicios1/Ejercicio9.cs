using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios1
{
    public class Ejercicio9 : MonoBehaviour
    {
        private GameObject[] esferas = new GameObject[12];

        // Start is called before the first frame update
        private void Start()
        {
            esferas[0] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esferas[0].transform.localScale = new Vector3(1f, 1f, 1f);
            for (int i = 1; i <= esferas.Length; i++)
            {
                esferas[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esferas[i].transform.localScale = esferas[i - 1].transform.localScale * 2f;
            }
        }
    }
}