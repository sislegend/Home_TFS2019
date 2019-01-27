using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScriptPiano : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject shadow;

    private int shadowNum = 0;

    // Use this for initialization
    void Start()
    {
        shadow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Candle")
        {
            if (shadowNum == 0)
            {
                SpawnShadow();
            }
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Candle")
        {
            // gameObject.GetComponent<Animator>().Play("idle");
        }
    }
    public void SpawnShadow()
    {
        shadow.SetActive(true);
        shadowNum++;
    }
}
