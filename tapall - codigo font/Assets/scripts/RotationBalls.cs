using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RotationBalls : MonoBehaviour
{

    public float velocity;
    bool right;

    public GameObject gameOver;
    public int pointing;

    public Text pointingText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){

        if(Input.GetMouseButtonDown(0)){
            right = !right;
        }

        if(right == false){
            transform.Rotate(new Vector3(0f, 0f, velocity * Time.deltaTime));
        }else{
            transform.Rotate(new Vector3(0f, 0f, -velocity * Time.deltaTime));
        }
    }

    

    public void callGameOver(){
        gameOver.SetActive(true);
    }

    public void restartGame(){
        SceneManager.LoadScene(0);
    }

    public void updatePointing(){
        pointing++;
        pointingText.text = pointing.ToString();
    }
}
