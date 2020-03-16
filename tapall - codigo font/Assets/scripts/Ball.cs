using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public RotationBalls Controller;
    void OnCollisionEnter2D(Collision2D coliser) {
        
        if(coliser.gameObject.tag == "Point"){
            Destroy(coliser.gameObject);
            Controller.updatePointing();
        }

        if(coliser.gameObject.tag == "Plataform"){
            Controller.callGameOver();
        }    
    }
}
