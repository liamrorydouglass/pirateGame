using UnityEngine;
using System.Collections;

public class mvmt : MonoBehaviour
{


    public float playerSpeed = 4f;
    public int floatpower;
    public int value;
    Gradient gradient;

    void Start()
    {
        value = 0;
        floatpower = 100;
        gradient = new Gradient();
        float gradvalue = floatpower / 100;


        GradientColorKey[] colorKey = new GradientColorKey[2];
        colorKey[0].color = Color.black;
        colorKey[0].time = 0.0f;
        colorKey[1].color = Color.green;
        colorKey[1].time = 1.0f;

        GradientAlphaKey[] alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 1.0f;
        alphaKey[1].time = 1.0f;

        gradient.SetKeys(colorKey, alphaKey);


        this.GetComponent<SpriteRenderer>().color = gradient.Evaluate(gradvalue);

    }

    void FixedUpdate()
    {
        if(floatpower < 0)
        {
            Debug.Log("LOSS GAME OVER");
        }
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
    }
    
   private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("hit detected");
        floatpower -= 5;
    }

    
}