using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
	//variaveis//
	//M9
	public AudioClip M9Shoting1Sound;
	public bool M9IsShoting = true;
	public bool M9IsReloading;
	
	public AudioClip M9Reload1Sound;
	
	// links//
	public MouseAction Mouse;
	public GameController GameController;
	public GunController GunController;
	public AnimationController AnimationController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 if(Input.GetMouseButtonDown(0)){
        if (Mouse.OnCursorStay("M9FireButton"))
	    {
	    Debug.Log("M9Fire");
	    audio.PlayOneShot(M9Shoting1Sound);
		
				Debug.Log("Fire");
			
			}
	
		if(Mouse.OnCursorStay("M9ReloadButton"))
			{
			
			audio.PlayOneShot(M9Reload1Sound);	
			Debug.Log("mag");
			}
		
		
		}
}
	
}