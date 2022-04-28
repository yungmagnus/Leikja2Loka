using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollected : MonoBehaviour
{
    public AudioSource CoinAudio;
    private void OnTriggerEnter(Collider other)
    {
        ScoreTextScript.coinAmount += 1;//Bættir við +1 i coins i canvas
        CoinAudio.Play();//spilar hljoð þegar coin er tekinn
        Destroy(gameObject);//Eyðir coin ur borðinu
    }
   
  
}
