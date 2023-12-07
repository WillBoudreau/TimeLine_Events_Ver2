using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTrigger2 : MonoBehaviour
{
    [Header("TimeLine Events For the Second Event")]
    [SerializeField] private PlayableDirector TimeLineEvent2;
    // Start is called before the first frame update
    void Start()
    {
        TimeLineEvent2.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        TimeLineEvent2.Play();
    }
}
