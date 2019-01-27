using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScriptVase : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject shadow;

    private int shadowNum = 0;

    // Use this for initialization
    void Start()
    {
        //gameObject.GetComponent<Animator>().Play("idle");
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
                //gameObject.GetComponent<Animator>().Play("rockingHorse");
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
        //shadow.transform.localScale = new Vector3(2 * GameObject.FindGameObjectWithTag("Shadow").transform.localScale.y, 1, 4 * GameObject.FindGameObjectWithTag("Shadow").transform.localScale.y);
        //Instantiate(shadow, spawnPoint.transform.position, Quaternion.identity);
        //shadow.transform.rotation = spawnPoint.transform.rotation;
        shadowNum++;
    }
}
