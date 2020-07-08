using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class blocks : MonoBehaviour
{
    // Start is called before the first frame update
    int compteur = 0;
    public int resistance = 0;

    Text scoreText;
    int Score;

    void Start()
    {
        
    }
   

    void OnCollisionEnter2D(Collision2D collisioninfo)
    {
        compteur++;
        if(compteur == resistance)
        {
            Destroy(gameObject);
        }


        if (collisioninfo.gameObject.name == "Ball")
        {
            
                //this line will just add 1 point to the score
                Score++;
            //this line will convert the int score variable to a string variable
            scoreText.text = Score.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
