using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {
    public GameController GameController;
	public AudioController AudioController;
	public GunController GunController;
	public MouseAction Mouse;
	//M9Animation
  	public AnimationClip M9SlideAnimation;
	public AnimationClip M9TriggerAnimation;
	public AnimationClip M9MagAnimation;
	public ParticleEmitter M9FireParticle;
	public AnimationClip M9HammerAnimation;
	//M4A1Animation
	public AnimationClip M4A1MagAnimation;
	public AnimationClip M4A1PullBackAnimation;	
	public AnimationClip M4A1TriggerAnimation;
	//
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//M9
	    if(Input.GetMouseButtonDown(0)){
        if (Mouse.OnCursorStay("M9FireButton"))
	    {
	    Debug.Log("M9Fire");
	    animation.Play("M9SlideAnimation");
		animation.Play("M9TriggerAnimation");
		animation.Play("M9HammerAnimation");
				Debug.Log("Fire");
			
			}
		if (Mouse.OnCursorStay("M4A1ReloadButton"))
	    {
	    Debug.Log("M4A1");
	    animation.Play("M4A1Reload1Animation");
		//animation.Play("M9TriggerAnimation");
		//animation.Play("M9HammerAnimation");
				Debug.Log("Fire");
			
		}
		if(Mouse.OnCursorStay("M9ReloadButton"))
			{
			animation.Play("M9Reload1Animation");	
			Debug.Log("magaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
			}
			
		
		
		
		
		}
		

		
	}
}

	