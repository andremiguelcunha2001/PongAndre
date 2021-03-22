using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   float Velocidade = 5f;

    float tempo = 0f;
    float lancarbola = 2f;
    bool estadobola = true;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;

        if (estadobola == true)
        {
            if (tempo > lancarbola)
            {
                GetComponent<Rigidbody2D>().velocity = Velocidade * Random.insideUnitSphere;
                estadobola = false;
            }

        }
    }
  
}