using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonball : MonoBehaviour
{
    public GameObject explosion;
    private float fadeouttime;
    private float alpha;
    private Color tmp;
    private bool exploded;
    // Start is called before the first frame update
    void Start()
    {
        this.fadeouttime = 1f;
        tmp = this.GetComponent<SpriteRenderer>().color;
        tmp.a = .68f;
        exploded = false;
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(tmp.a);

        tmp.a -= .01f;
        this.GetComponent<SpriteRenderer>().color = tmp;
        //Debug.Log(tmp.a);
        if(tmp.a < .2 & !exploded)
        {
            exploded = true;
            Vector3 adjust = new Vector3(0f, .1f, 0f);
            GameObject expl = Instantiate(explosion, this.transform.position + adjust, Quaternion.identity) as GameObject;
          
            Destroy(expl,2);
            
        }
    }
}

