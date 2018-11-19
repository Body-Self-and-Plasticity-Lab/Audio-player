# Audio player
### Plays audios based on input

The included unitypackage shows a demo for single and multiple audios based on key input.

1. Use the AudioPlayer script and increase/decrease the number of "Clips" that you need from the Unity inspector (Clips, size). Add the corresponding audio clip for each element.

2. If you want to trigger the audios from keys:
 a. Enable Use Key Input.
 b. Match the size of the "Clips" to that of the "Key to Trigger Audio" 
 c. For using number keys to trigger, enable "Use Number Keys". Key 1 will correspond to Element 0 and so on...
 d. To use aditional keys: add the string corresponding to the key that you need to trigger each audio (i.e. return). The element   of the "Key to Trigger Audio" will match the audio clip of "Clips".

3. If you need to trigger the audios from elsewhere, call the Trigger call the TriggerAudio(int) function. The (int) corresponds to the audio Element that you want to trigger.

Note: by default playOnAwake is disabled, so the audios will not play automatically when running your scene.
