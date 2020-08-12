using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class director : MonoBehaviour
{
    public GameObject enemy;
    public GameObject rock;

    public int spawnnumberenemy;
    public int spawnnumberroock;

    private float time;
    private float leveltime;

    private float wavebuffer;
    private float wavetimerenemy;
    private float wavetimerrock;

    public bool rerollenabled;

    void Start()
    {
        time = 0f;
        leveltime = 0f;
        wavetimerenemy = 0f;
        wavetimerrock = 0f;
        wavebuffer = .5f;
       
        rerollenabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        time += .017f;
        leveltime += .017f;
        wavetimerenemy += .017f;
        wavetimerrock += .017f;

        if (GameObject.FindGameObjectsWithTag("Enemy").Length < spawnnumberenemy & wavetimerenemy > wavebuffer)
        {
            wavetimerenemy = .0f;
            Instantiate(enemy);
        }
        if (GameObject.FindGameObjectsWithTag("Rock").Length < spawnnumberroock & wavetimerrock > wavebuffer)
        {
            wavetimerrock = .0f;
            Instantiate(rock);
        }

        if(leveltime > 5)
        {
            rerollenabled = false;
        }

        if(leveltime > 10)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            spawnnumberenemy = 0;

            //Application.LoadLevel("island");
        }

    }
    
}
