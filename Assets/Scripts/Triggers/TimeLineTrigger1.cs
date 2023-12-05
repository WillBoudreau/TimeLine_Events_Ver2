using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTrigger1 : MonoBehaviour
{
    [Header("TimeLine Events For Will Character")]
    [SerializeField] private PlayableDirector TimeLineEventWill;
    // Start is called before the first frame update
    void Start()
    {
        TimeLineEventWill.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        TimeLineEventWill.Play();
    }
}
