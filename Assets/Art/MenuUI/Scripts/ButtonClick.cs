using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image Image;
    [SerializeField] private Sprite pressed, unpressed;
    [SerializeField] private AudioClip pressedClip, unpressedClip;
    [SerializeField] private AudioSource Source;
    public void OnPointerDown(PointerEventData eventData)
    {
        Image.sprite = pressed;
        Source.PlayOneShot(pressedClip);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Image.sprite = unpressed;
        Source.PlayOneShot(unpressedClip);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Prototype 2");
    } 
}
