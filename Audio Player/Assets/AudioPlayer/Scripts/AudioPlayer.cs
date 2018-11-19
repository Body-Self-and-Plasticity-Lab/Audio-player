using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

	public AudioSource[] clips;
	public string[] keyToTriggerAudio;
	public bool useKeyInput;
	public bool useNumberKeys;


	void Awake () {
		foreach (AudioSource clip in clips) {
			clip.Stop(); //dissables play on awake
		
		}
	}
		
	
	// Update is called once per frame
	void Update () {
		if (useKeyInput)
			PlayAudioFromKeys ();
	}

	private void PlayAudioFromKeys(){
		
		if(useNumberKeys){
			for (int i = 0; i < clips.Length; i++) {
				if(Input.GetKeyDown((i+1).ToString()))
					clips[i].Play();
			}
		}

		else {
			for (int i = 0; i < clips.Length; i++) {
				if (Input.GetKeyDown (keyToTriggerAudio [i]))
					clips [i].Play ();
			}
		}
	}

	public void TriggerAudio(int audioIndex){		
		clips [audioIndex].Play ();
	}
}
