using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider musicVolume;

    private void Start()
    {
        musicVolume.onValueChanged.AddListener(SetMusicLvl);
    }


    public void SetMusicLvl (float musicLvl)
    {
        mixer.SetFloat ("musicVol",Mathf.Log10 (musicLvl) *20);
    }

}