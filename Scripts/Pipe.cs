using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Pipe : MonoBehaviour
{
  
    private void OnTriggerEnter2D (Collider2D other)
    {
      if(other.TryGetComponent<Player>(out _))
      {
         ScoreManager.Instance.SetScore(1);
      }
    }
}
