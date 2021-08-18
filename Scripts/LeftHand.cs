using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHand : MonoBehaviour
{
    private ScoreManager scoreManager;
    private Vfx vfx;
    private Afx afx;

    private void Awake()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        vfx = GameObject.FindObjectOfType<Vfx>();
        afx = GameObject.FindObjectOfType<Afx>();
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "LeftPositiveHit")
       {
            scoreManager.Score+=10; ;
            //add the score
            //play a nice sound

            vfx.blue.Play();
            afx.win.Play();
            Destroy(other.transform.parent.gameObject);
            Debug.Log(other.gameObject + "destroyed");
       }
       else if( other.gameObject.tag == "RightPositiveHit" )
        {
            scoreManager.Score -=5;
            // do not add the score 
            //play a buzz sound
            afx.fail.Play();
            Destroy(other.transform.parent.gameObject);
            Debug.Log(scoreManager.Score.ToString());
        }
    }
    
}
