using System.Collections.Generic;
using UnityEngine;

public enum SoundType
{
    TypeSelect,
    TypeMove,
    TypePop,
    TypeGameOver
};

public class GerenciaSom : MonoBehaviour
{
    public List<AudioClip> clips;
    public static GerenciaSom Instance;
    AudioSource Source;

    private void Awake()
    {
        Instance = this;
        Source = GetComponent<AudioSource>();
    }

    public void PlaySound(SoundType clipType)
    {
        Source.PlayOneShot(clips[(int)clipType]);
    }
}
