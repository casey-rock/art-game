using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1scorecontrol : MonoBehaviour {

   public GameObject textGameObject1;
   private int score;
   
   void Start () {
score = 0; 
UpdateScore ();	 }
   
   public void AddScore (
int newScoreValue) {
score += newScoreValue; UpdateScore ();	}

   void UpdateScore () {
	Text scoreTextA = textGameObject1.GetComponent<Text>();
	scoreTextA.text = "Score: " + score;	}	}
