
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNotBreak : MonoBehaviour
{

    public float xPos;
    public float yPos;
    public float zPos;

    IEnumerator OnTriggerEnter(Collider col)//Færir kubinn upp þegar það er klesst á hann siðan fer hann aftur niður þegar það er ekki verið að snerta hann.
    {
        transform.GetComponent<Collider>().isTrigger = false;//Slekkur á trigger á collider
        if (col.gameObject.tag == "Player")//If statement fer bara i gang ef player taggið collidar.
        {
            this.transform.position = new Vector3(xPos, yPos + 0.2F, zPos);//Færir kubinn
            yield return new WaitForSeconds(0.08F);
            this.transform.position = new Vector3(xPos, yPos, zPos);//Færir hann á original posistion.
            yield return new WaitForSeconds(0.25F);
            transform.GetComponent<Collider>().isTrigger = true;//gerir collider að trigger
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