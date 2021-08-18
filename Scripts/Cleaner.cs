using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    ScoreManager scoreManager;
    private Afx afx;

    private void Awake()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        afx = GameObject.FindObjectOfType<Afx>();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RightPositiveHit" || other.gameObject.tag == "LeftPositiveHit")
        {
            Destroy(other.transform.parent.gameObject);
        }
        else if (other.gameObject.tag == "Player")
        {
            scoreManager.Score -= 10;
            afx.fail.Play();
        }
    }
    //private void onTriggerEnter(Collision Other)
    //{
    //    if(collision.gameObject.tag == "RightPositiveHit"|| collision.gameObject.tag == "LeftPositiveHit")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //    else if(collision.gameObject.tag == "Player")
    //    {
    //        scoreManager.Score -= 10;
    //    }
    //}
}
