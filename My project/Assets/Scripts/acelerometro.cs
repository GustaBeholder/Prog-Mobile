using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acelerometro : MonoBehaviour
{
    private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
        MoveObject();

        
    }

    void MoveObject()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.acceleration.x; 
        direction.z = Input.acceleration.y;

        if(direction.sqrMagnitude > 1)
        {
            direction.Normalize();
        }
        direction *= Time.deltaTime;
        transform.Translate(direction * speed);

        if(direction.x > 0)
        {
            Debug.Log("Direita");
        }
        else
        {
            Debug.Log("Esquerda");
        }
        if(direction.z > 0)
        {
            Debug.Log("Cima");
        }
        else
        {
            Debug.Log("Baixo");
        }
    }
}
