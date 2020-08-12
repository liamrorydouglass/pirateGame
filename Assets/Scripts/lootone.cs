using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lootone : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    public int weight;
    public int value;
    Gradient gradient;

    void Start()
    {
        player = GameObject.Find("boat");

        gradient = new Gradient();

        weight = Random.Range(1,80);
        value = weight * 10 + Random.Range(0, weight*3);
        float gradvalue = value / 800f;
        //textbox = GetComponent<Text>();

        GradientColorKey[] colorKey = new GradientColorKey[2];
        colorKey[0].color = Color.red;
        colorKey[0].time = 0.0f;
        colorKey[1].color = Color.yellow;
        colorKey[1].time = 1.0f;

        GradientAlphaKey[] alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 1.0f;
        alphaKey[1].time = 1.0f;

        gradient.SetKeys(colorKey, alphaKey);

        Vector3 scale = transform.localScale;
        scale.y = weight/100f + .5f; // your new value
        scale.x = 2* weight / 100f +.5f;
        transform.localScale = scale;

        this.GetComponent<SpriteRenderer>().color = gradient.Evaluate(gradvalue);


    }


    // Update is called once per frame
    void Update()
    {
        //textbox.text = "Value: " + value + " Weight: " + weight;
    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        Debug.Log("clicked");
        player.GetComponent<mvmt>().floatpower -= weight;
        player.GetComponent<mvmt>().value += value;
        Debug.Log(player.GetComponent<mvmt>().floatpower);
        Debug.Log(player.GetComponent<mvmt>().value);

    }
}
