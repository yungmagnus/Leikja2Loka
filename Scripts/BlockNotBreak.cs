
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNotBreak : MonoBehaviour
{

    public float xPos;
    public float yPos;
    public float zPos;

    IEnumerator OnTriggerEnter(Collider col)//F�rir kubinn upp �egar �a� er klesst � hann si�an fer hann aftur ni�ur �egar �a� er ekki veri� a� snerta hann.
    {
        transform.GetComponent<Collider>().isTrigger = false;//Slekkur � trigger � collider
        if (col.gameObject.tag == "Player")//If statement fer bara i gang ef player taggi� collidar.
        {
            this.transform.position = new Vector3(xPos, yPos + 0.2F, zPos);//F�rir kubinn
            yield return new WaitForSeconds(0.08F);
            this.transform.position = new Vector3(xPos, yPos, zPos);//F�rir hann � original posistion.
            yield return new WaitForSeconds(0.25F);
            transform.GetComponent<Collider>().isTrigger = true;//gerir collider a� trigger
        }
    }

    // Use this for initialization
    void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
    }


}