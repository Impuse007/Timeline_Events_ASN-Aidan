using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{

    public GameObject timeline;


    private void OnTriggerEnter(Collider other)
    {
        PlayableDirector pd = timeline.GetComponent<PlayableDirector>();
        if (pd != null)
        {
            pd.Play();
        }
    }
}

