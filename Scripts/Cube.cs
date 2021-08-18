using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int speed;
   
    private void Update()
    {
        transform.position += Time.deltaTime* -transform.forward * speed;

    }
}
