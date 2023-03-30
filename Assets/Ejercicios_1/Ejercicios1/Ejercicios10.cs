using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios1
{
    public class Ejercicios10 : MonoBehaviour
    {
        private GameObject cubo;

        // Start is called before the first frame update
        private void Start()
        {
            cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.name = "cubo";
            cubo.transform.position = new Vector3(1f, 1f, 1f);
            // GameObject[] coincide = GameObject.FindObjectsOfType<GameObject>();
        }

        // Update is called once per frame
        private void Update()
        {
            cambioNombreX(1f, cubo);
        }

        private void cambioNombreX(float coord, GameObject x)
        {
            string nombre = "Uno";

            // if (coord == x.transform.position.x)
            {
                x.name = nombre;
            }
        }
    }
}