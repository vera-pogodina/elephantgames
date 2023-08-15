using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class BtnOnClick : MonoBehaviour, IPointerClickHandler
{
    private Animator anim;

    public void OnPointerClick(PointerEventData eventData)
    {
        anim.Play("Btn_show");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
