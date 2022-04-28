using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaDeath : MonoBehaviour
{

    public GameObject Goomba;

    IEnumerator OnTriggerEnter(Collider col)
    {
        this.GetComponent<BoxCollider>().enabled = false;//Slekkur á box collider.
        Goomba.GetComponent<GoombaMove>().enabled = false;//Stöðvar ovinn
        Goomba.transform.localScale -= new Vector3(2, 0.8F, 0.4F);//minnkar ovinn
        Goomba.transform.localPosition -= new Vector3(0, 0.6F, 0);
        yield return new WaitForSeconds(1);
        Goomba.transform.position = new Vector3(0, -1000, 0);//felur ovinn
    }
}