using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loot;
    public int weight;
    public int value;

    void Start()
    {
        weight = loot.GetComponent<lootone>().weight;
        value = loot.GetComponent<lootone>().value;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
