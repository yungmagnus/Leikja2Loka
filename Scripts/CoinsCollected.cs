using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollected : MonoBehaviour
{
    public AudioSource CoinAudio;
    private void OnTriggerEnter(Collider other)
    {
        ScoreTextScript.coinAmount += 1;//B�ttir vi� +1 i coins i canvas
        CoinAudio.Play();//spilar hljo� �egar coin er tekinn
        Destroy(gameObject);//Ey�ir coin ur bor�inu
    }
   
  
}
