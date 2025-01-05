using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  public class RotateObject : MonoBehaviour
{
    public float speed = 100.0f;

    void Update() =>
        // Вращаем объект вокруг своей оси
        transform.Rotate(new Vector3 (0, 0, 1), speed * Time.deltaTime);
}
