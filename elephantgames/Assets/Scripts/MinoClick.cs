using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MinoClick : MonoBehaviour, IPointerClickHandler

{
    private Animator anim;

    public void OnPointerClick(PointerEventData eventData)
    {
        anim.SetInteger("Stage", 1);
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
     public void EndAnimation()
    {
        anim.SetInteger("Stage", 0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
