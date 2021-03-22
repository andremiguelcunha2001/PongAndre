using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]

    float velocidade = 0.5f;

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;



    // Update is called once per frame
    void Update()
    {


        /**
         * se tecla para cima premida
         * então subir
         * senão se tecla para baixo premida
         * então descer
         */



        if (Input.GetKey(upKey))
        {
            // tarnsform.position += velocidade * vector3.up 

            transform.position =
                transform.position + velocidade * Vector3.up * Time.deltaTime;

        }
        else if (Input.GetKey(downKey))
        {
            transform.position =
                transform.position + velocidade * Vector3.down * Time.deltaTime;
            //Desce
        }

        float cameraHeight = Camera.main.orthographicSize;
        float halfPaddleSize = 0.5f;

        if (transform.position.y >= cameraHeight - halfPaddleSize)
        {
            // Na prática o códio abaixo faz isto: transform.position.y = 3f - 0.5f

            Vector3 positionAux = transform.position;
            positionAux.y = cameraHeight - halfPaddleSize;
            transform.position = positionAux;
        }


        if (transform.position.y <= -cameraHeight + halfPaddleSize)
        {
            // Na prática o códio abaixo faz isto: transform.position.y = 3f - 0.5f

            Vector3 positionAux = transform.position;
            positionAux.y = -cameraHeight + halfPaddleSize;
            transform.position = positionAux;

        }

    }
}
