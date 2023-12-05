using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimeLineTrigger2 : MonoBehaviour
{
    [Header("TimeLine Events For the trash")]
    [SerializeField] private PlayableDirector TimeLineEventTrash;
    // Start is called before the first frame update
    void Start()
    {
        TimeLineEventTrash.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        TimeLineEventTrash.Play();
    }
}
