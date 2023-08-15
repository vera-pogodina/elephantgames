using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MinoClick : MonoBehaviour, IPointerClickHandler

{
    private Animator anim;
    private AudioSource aSource;

    public void OnPointerClick(PointerEventData eventData)
    {
        anim.SetInteger("Stage", 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        aSource = GetComponent<AudioSource>();
    }
     public void EndAnimation()
    {
        anim.SetInteger("Stage", 0);
        aSource.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
