using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTrigger3 : MonoBehaviour
{
    [Header("TimeLine Events For Jumpscare")]
    [SerializeField] private PlayableDirector TimeLineEventJumpscare;
    // Start is called before the first frame update
    void Start()
    {
        TimeLineEventJumpscare.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        TimeLineEventJumpscare.Play();
    }
}
