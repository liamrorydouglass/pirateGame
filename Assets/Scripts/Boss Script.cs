using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossscrasdfipt : MonoBehaviour
{

    public GameObject warning;
    public GameObject player;

    public Vector3 startPosition;
    private float speed;
    private float amplitude;
    private float time;
    private float leniency = 1f;
    private float reset;
    private bool fired;
    public float bosschance;

    void Start()
    {
        time = 0f;
        startPosition = new Vector3(4.538f, Random.Range(.1f, 1.5f), 1);
        this.transform.position = startPosition;
        amplitude = Random.Range(2f, 8f);
        speed = 2 * 2 / amplitude;
        fired = false;
        bosschance = Random.Range(0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 10 & bosschance > 0f)
        {
            reset = Vector3.Distance(this.transform.position, startPosition);
            time += .017f;
            transform.position = startPosition - new Vector3(amplitude * Mathf.Sin(speed * time), 0.0f, 0.0f);
            if (time > 1 & reset < leniency)
            {
                // Debug.Break();
                time = 0f;
                reroll();
            }
            if (time > 1 & 1 - Mathf.Sin(speed * time) < .02 & !fired)
            {
                Debug.Log("BANG");
                shoot();
                shoot();
                shoot();
                fired = true;
            }
            //Debug.Log(Mathf.Sin(speed * time));

            //Debug.Log(time);
        }
    }

    void reroll()
    {
        startPosition = new Vector3(4.538f, Random.Range(-0.3f, 1.5f), 1);
        this.transform.position = startPosition;
        amplitude = Random.Range(1f, 8f);
        speed = 2 * 1 / amplitude;
        fired = false;
    }

    void shoot()
    {
        var pos = player.transform.position;
        Vector3 spread = new Vector3(Random.Range(-.7f, .7f), Random.Range(-.4f, .4f), 0f);

        Vector3 landing = pos + spread;

        GameObject cbl = Instantiate(warning, landing, Quaternion.identity) as GameObject;
        Destroy(cbl, 5);
    }
}
