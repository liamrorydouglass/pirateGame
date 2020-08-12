using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_controller : MonoBehaviour
{
    public GameObject director;


    private Vector3 startPosition;
    public float speed;
    private float time;

    void Start()
    {
        time = 0f;
        startPosition = new Vector3(-4.538f, Random.Range(.1f, -1.775f), 1f);
        this.transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        director directorscript = director.GetComponent<director>();
        //Debug.Log(director.GetComponent<director>());
        time += .017f;
        transform.position = startPosition + new Vector3(time * speed, 0f, 0f);
        
        if(Vector3.Distance(transform.position, startPosition) > 11f & directorscript.rerollenabled)
        {
            reroll();
        }
        
    }

    void reroll()
    {
        time = 0f;
        startPosition = new Vector3(-4.538f, Random.Range(.1f, -1.775f), 1f);
        this.transform.position = startPosition;
    }

}
