using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Cuzzo : MonoBehaviour
{
    public GameObject[] objects;
    public Color[] colors;
    //objects[i].GetComponent<Renderer>().material.color = colors[i];
    // Start is called before the first frame update
    void Start()
    {
         for (int i = 0; i <= 3; i++)
         {
            objects[i].GetComponent<Renderer>().material.color = colors[i];
         }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
