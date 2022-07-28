using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseWall : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D col)
   {
      if (col.gameObject.CompareTag(Tags.Ball))
      {
         FindObjectOfType<GameManager>().GameOver();
      }
   }
}
