using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeExit : MonoBehaviour
{

    public AudioSource PipeSound;
    public GameObject FadeScreen;
    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject PipeEntry;
    public GameObject MainPlayer;


    IEnumerator OnTriggerEnter(Collider col)
    {
        PipeSound.Play();//Spilar PipeSound
        yield return new WaitForSeconds(0.495F);
        FadeScreen.SetActive(true);//Activatar Canvasinn
        FadeScreen.GetComponent<Animator>().enabled = true;//Activatar animatorinn á canvas
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;// slekkur á Canvas
        MainCam.SetActive(true);//Skiptir yfir í maincamera
        SecondCam.SetActive(false);//slekkur á ivan camera
        MainPlayer.transform.position = new Vector3(27,1.8F, 0.5F); //Færir playerinn á seinna pipeið  
        PipeEntry.GetComponent<Animator>().enabled = true;//PipeAnimaion færir playerinn upp
        FadeScreen.GetComponent<Animator>().enabled = true;//Canvas fer í gang
        yield return new WaitForSeconds(0.495F);
        FadeScreen.GetComponent<Animator>().enabled = false;//Stöðvar canvas animation
        yield return new WaitForSeconds(1);
        PipeEntry.GetComponent<Animator>().enabled = false;//Stoðvar mann ofan á pipe.
        FadeScreen.SetActive(false);//Slekkur á Canvas
    }
}