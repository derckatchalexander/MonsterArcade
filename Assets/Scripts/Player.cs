using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  
  public float JumpForce;
  public Rigidbody2D rb;
  public monsteranimation monsteranimation;
  

  private void Update()
  {
   
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            rb.velocity=new Vector2();
            rb.AddForce(transform.up*JumpForce, ForceMode2D.Impulse);
            monsteranimation.StartRotation();
        }
        monsteranimation.ApplyRotation(rb.velocity.x);
  }


  private void OnCollisionEnter2D(Collision2D other)
   {
    if(other.gameObject.CompareTag("PipePart"))
    {
      GameManager.instance.Lose();
      
    }
   }

}
