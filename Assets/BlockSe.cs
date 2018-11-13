using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSe : MonoBehaviour {

    public AudioSource cubeSE;
    // Use this for initialization
    void Start () {
        cubeSE = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
     //   if (Input.GetKeyDown(KeyCode.K))
   //    {
   //         cubeSE.PlayOneShot(cubeSE.clip);

        }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
         if(collision.gameObject.tag == "Cube")
           cubeSE.PlayOneShot(cubeSE.clip);
    }
}
