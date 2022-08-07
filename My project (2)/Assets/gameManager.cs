using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public int score = 0;
    public Text Text1;
    public Text textIncrement;
     int increment = 1;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increaseScore()
    {

        score+= increment;
        Text1.text = score.ToString();

    }
    public void store()
    {
        
        if (score >= 5) 
        {
            
            score -= 5;
            increment++;
            Text1.text = score.ToString();
            textIncrement.text = "inc: "+increment;
        }
        else
        {
            print("score is not enough");
        }
           
    }



}
