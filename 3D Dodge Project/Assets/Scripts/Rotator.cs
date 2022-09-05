using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    private float timeCounter = 0f;

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        timeCounter += Time.deltaTime;

        if (timeCounter >= 5f)
        {
            rotationSpeed += 5;
            rotationSpeed = -rotationSpeed;
            timeCounter = 0f;
        }
    }
}
