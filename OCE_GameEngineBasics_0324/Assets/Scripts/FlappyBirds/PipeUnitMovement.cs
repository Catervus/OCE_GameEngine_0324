using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeUnitMovement : MonoBehaviour
{
    private float speed;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void Initialise(float _spd)
    {
        speed = _spd;
    }
}
