using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{
   private float speed = 20f;
   [SerializeField] private GameObject scoreManager;

   private void Start()
   {
      scoreManager.GetComponent<ScoreManager>().allScore = GameObject.FindGameObjectsWithTag("Score");
   }
   
   private void Update()
   {
      Move();
   }
   
   private void Move()
   {
      float h = Input.GetAxis("Horizontal");
      transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed * h);

      float v = Input.GetAxis("Vertical");
      transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed * v);
   }

   private void OnTriggerEnter(Collider other)
   {
      GameObject score = other.gameObject;

      if (other.tag == "Score")
      {
         for (int i = 0; i < scoreManager.GetComponent<ScoreManager>().allScore.Length; i++)
         {
            if (score == scoreManager.GetComponent<ScoreManager>().allScore[i])
            {
               scoreManager.GetComponent<ScoreManager>().scoreCount++;
               Destroy(score);
               break;
            }
         }
      }
   }
}
