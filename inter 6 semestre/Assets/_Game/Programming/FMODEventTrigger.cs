using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD;

public class FMODEventTrigger : MonoBehaviour
{
    public static FMOD.Studio.EventInstance currentMusic;

    public void StartMusic(string _path)
    {
        FMOD.Studio.PLAYBACK_STATE state;
        currentMusic.getPlaybackState(out state);
        if(state != FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            UnityEngine.Debug.Log("already playing another event");
        }
        else
        {
            currentMusic = RuntimeManager.CreateInstance(_path);
            currentMusic.start();
        }
    }

    public void StopMusic(string _mode)
    {
        FMOD.Studio.STOP_MODE parsed_enum = (FMOD.Studio.STOP_MODE)System.Enum.Parse(typeof(FMOD.Studio.STOP_MODE), _mode);
        currentMusic.stop(parsed_enum);
    }

    public void PlayOneShotEvent(string _path)
    {
        RuntimeManager.PlayOneShot(_path, transform.position);
    }
}
