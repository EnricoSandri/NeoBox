using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHand : MonoBehaviour
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
        if (other.gameObject.tag == "RightPositiveHit")
        {
            scoreManager.Score +=10;

            //play a nice sound
            vfx.red.Play();
            afx.win.Play();
            Destroy(other.transform.parent.gameObject);
            
        }
        else if (other.gameObject.tag == "LeftPositiveHit")
        {
            // do not add the score 
            scoreManager.Score -=5;
            //play a buzz sound
            afx.fail.Play();
            Destroy(other.transform.parent.gameObject);
        
        }
    }
}
    
