using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
  public float Start;
  public float End;
  public float speed;

  void Update()
  {
    if(transform.position.x <= End)
    {
          transform.Translate(Vector2.left*speed*Time.deltaTime);
          if(transform.position.x >= Start)
           {
              transform.Translate(-Vector2.left*speed*Time.deltaTime);
           }
    }
    if(transform.position.x >= Start)
    {

     transform.Translate(-Vector2.left*speed*Time.deltaTime);
    }
  }
}
