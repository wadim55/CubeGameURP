using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ScoreManager : MonoBehaviour
{
   [SerializeField] private GameObject scoreGameObject;
   public GameObject[] allScore;
   public int scoreCount;
   [SerializeField] private Text scoreCountText;

   private void Start()
   {
     SpawnScore();
     allScore = GameObject.FindGameObjectsWithTag("Score");
   }

   private void Update()
   {
       scoreCountText.text = scoreCount.ToString();
   }

   private void SpawnScore()
   {
       for (int i = 0; i < 15; i++)
       {
           Instantiate(scoreGameObject, new Vector3(Random.Range(13, -13),
                   0.7f, Random.Range(13, -13)),
               Quaternion.Euler(0, 0, 0));
       }
   }
}
