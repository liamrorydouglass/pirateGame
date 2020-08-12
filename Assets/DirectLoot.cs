using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectLoot : MonoBehaviour
{
    public GameObject loot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject loot1 = Instantiate(loot);
        GameObject loot2 = Instantiate(loot);
        GameObject loot3 = Instantiate(loot);
        loot1.GetComponent<lootone>().weight = 69;
    }
}
