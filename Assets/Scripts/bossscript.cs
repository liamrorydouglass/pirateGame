using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossscript : MonoBehaviour
{

    public GameObject warning;
    public GameObject player;

    public Vector3 startPosition;
    private float speed;
    private float amplitude;
    private float time;
    private float leniency = .2f;
    private float reset;
    private bool fired;
    public float bosschance;
    private bool bosstime;
    void Start()
    {
        time = 0f;
        startPosition = new Vector3(5.538f, 1.43f, 1);
        this.transform.position = startPosition;
        amplitude = Random.Range(2f, 8f);
        speed = 2 * 2 / amplitude;
        fired = false;
        bosstime = false;
        bosschance = Random.Range(0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(SceneManager.GetSceneByName("island"));
        //Debug.Log("SPEED:");
        time += .017f;
        if (time > 10)
        {
            if (!bosstime)
            {
                time = 0;
            }
            bosstime = true;
        }
        if (bosstime)
        {
            if(bosschance < 0.0f | time > 15)
            {
                Scene sceneToLoad = SceneManager.GetSceneByName("Scenes/island");
                //Debug.Log(sceneToLoad);
                Debug.Log(1);
                SceneManager.LoadScene("island");
                Debug.Log(2);
                SceneManager.MoveGameObjectToScene(player.gameObject, sceneToLoad);
                Debug.Log(3);

                Application.LoadLevel("Scenes/island");
            }
            Debug.Log("BOSSFIGHT");
            reset = Vector3.Distance(this.transform.position, startPosition);
           
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
                shoot();
                shoot();
                shoot();

                fired = true;
            }
        }
        //Debug.Log(Mathf.Sin(speed * time));

        //Debug.Log(time);
    }

    void reroll()
    {
        startPosition = new Vector3(4.538f, 1.43f, 1);
        this.transform.position = startPosition;
        amplitude = Random.Range(1f, 8f);
        speed = 2 * 1 / amplitude;
        fired = false;
    }

    void shoot()
    {
        var pos = player.transform.position;
        Vector3 spread = new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-.7f, .7f), 0f);

        Vector3 landing = pos + spread;

        GameObject cbl = Instantiate(warning, landing, Quaternion.identity) as GameObject;
        Destroy(cbl, 5);
    }
}
