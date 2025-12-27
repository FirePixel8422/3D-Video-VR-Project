using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


public class VideoUISlot : MonoBehaviour
{
    [SerializeField] private VideoClip video;
    public VideoClip Video => video;

    [SerializeField] private Sprite thumbnail;
    [SerializeField] private string titel;


    [Header("Component Refs")]
    [SerializeField] private Image thumbNailRenderer;
    [SerializeField] private TextMeshProUGUI titelTextObj;

    public int Id { get; set; }


    private void Awake()
    {
        thumbNailRenderer.sprite = thumbnail;
        titelTextObj.text = titel;
    }
}