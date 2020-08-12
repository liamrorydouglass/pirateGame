using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    private float time;
    private float fadeouttime;
    private float alpha;
    private Color tmp;

    // Start is called before the first frame update
    void Start()
    {
        this.fadeouttime = 1f;
        tmp = this.GetComponent<SpriteRenderer>().color;
        tmp.a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        tmp.a -= .01f;
        this.GetComponent<SpriteRenderer>().color = tmp;

    }
}
