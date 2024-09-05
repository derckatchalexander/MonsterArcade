using System.Collections;
using System.Collections.Generic;
using UnityEngine;


  public class anim1 : MonoBehaviour
{
    public float speed1 = 100.0f;

    void Update() =>
        // Вращаем объект вокруг своей оси
        transform.Rotate(new Vector3 (0, 0, -1), speed1 * Time.deltaTime);
}
