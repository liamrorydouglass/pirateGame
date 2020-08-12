using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectLoot1 : MonoBehaviour
{
    public GameObject loot;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = this.transform.position;
        GameObject loot1 = Instantiate(loot, pos + new Vector3(Random.Range(-1f, 1f), Random.Range(-.5f, .5f), 0), Quaternion.identity);
        GameObject loot2 = Instantiate(loot, pos + new Vector3(Random.Range(-1f, 1f), Random.Range(-.5f, .5f), 0), Quaternion.identity);
        GameObject loot3 = Instantiate(loot, pos + new Vector3(Random.Range(-1f, 1f), Random.Range(-.5f, .5f), 0), Quaternion.identity);
        loot1.GetComponent<lootone>().weight = 69;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
