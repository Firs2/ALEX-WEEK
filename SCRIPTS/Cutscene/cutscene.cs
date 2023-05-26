using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class cutscene : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject Singleplayer;
    public GameObject Camera_Cutscene;
    public GameObject Music_Cutscene;
    public GameObject Music_game;
    public GameObject Credits;
    public GameObject Hinge;

    void Start()
    {
        timeline.GetComponent<PlayableDirector>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {           
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            Camera_Cutscene.SetActive(true);
            Singleplayer.SetActive(false);
            Credits.SetActive(false);
            Music_Cutscene.SetActive(true);
            Hinge.SetActive(false);
            Music_game.SetActive(false);
            timeline.Play();
            StartCoroutine(timelineplay());

        }
       
    }

    IEnumerator timelineplay()
    {
        yield return new WaitForSeconds(26);
        Singleplayer.SetActive(true);
        Camera_Cutscene.SetActive(false);
        Credits.SetActive(true);
        Hinge.SetActive(false);

    }



}
