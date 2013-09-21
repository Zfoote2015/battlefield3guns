using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public MouseAction Mouse;
	//public AudioController AudioController;
	//public GunController GunController;
	//public AnimationController AnimationController;
	//M9

		
	//bool Playing = true;
	void Update ()
	{			
		if (Input.GetMouseButtonDown(0))
		    {
			//Menu
			if (Mouse.OnCursorStay("SelectGun"))
			{
			Application.LoadLevel("SelectGunScene");
			Debug.Log("SelectGunScene");
			}
			if (Mouse.OnCursorStay("Credits"))
			{
			Application.LoadLevel("Credits_Scene");
			Debug.Log("Credit");
			}
			if (Mouse.OnCursorStay("Exit"))
			{
		    Application.Quit();
		    Debug.Log("Exit");
			}
		   //Credits
			if (Mouse.OnCursorStay("BackButton"))
			{
			Application.LoadLevel("Menu");	
			Debug.Log("Back Credits");
			}
		    //GunSelect
			if (Mouse.OnCursorStay("BackButton1"))
			{
			Application.LoadLevel("Menu");	
			Debug.Log("select gun back");
			}
			if (Mouse.OnCursorStay("M9"))	
			{
			Application.LoadLevel("M9");	
			}
			if (Mouse.OnCursorStay("M4A1"))	
			{
			Application.LoadLevel("M10");	
			}
			if (Mouse.OnCursorStay("AK-74M"))
			{	
			Application.LoadLevel("M11");	
			}
			if (Mouse.OnCursorStay("AS-VAL"))
			{	
			Application.LoadLevel("M12");	
			}
			if (Mouse.OnCursorStay("Barrett"))
			{	
			Application.LoadLevel("M13");	
			}
			if (Mouse.OnCursorStay("M60E4"))
			{	
			Application.LoadLevel("M14");	
			}
			if (Mouse.OnCursorStay("P90"))
			{	
			Application.LoadLevel("M15");	
			}
			if (Mouse.OnCursorStay("MP443"))
			{	
			Application.LoadLevel("M16");	
			}
			if (Mouse.OnCursorStay("SCARH"))
			{	
			Application.LoadLevel("M17");	
			}
			if (Mouse.OnCursorStay("ACWR"))
			{	
			Application.LoadLevel("M18");	
			}
			//InGame
			if (Mouse.OnCursorStay("BackButton2"))
			{
			Application.LoadLevel("SelectGunScene");	
			Debug.Log("select gun back");
			}
			//M9Controll
		 	
			
			
			
		
		   }
		 
		
          Mouse.RefreshHit();
	}
}
