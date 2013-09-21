using UnityEngine;
using System.Collections;


public class MouseAction : MonoBehaviour
{
    //public GameController GameController;
	//public AudioController AudioController;
	//public GunController GunController;
	//public AnimationController AnimationController;
	
	
	
	RaycastHit MouseHit;
    bool Hitted;
	
    void Start()
	{
		
			
	}
	
	void Update()
    {
        Ray rRay = camera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(rRay, out MouseHit, Mathf.Infinity))
        {
            Hitted = false;
            return;
        }
        Hitted = true;
		
		
		
		
			
	
	
	}

    /*Vector3 MouseLastPos;
    void RespondCameraMoving()
    {
        Vector3 Delta = Input.mousePosition - MouseLastPos;
        Vector3 DeltaHalfScreen = new Vector3(Input.mousePosition.x - ((Screen.width - Screen.width*0.2f) / 2), Input.mousePosition.y - (Screen.height / 2), 0);
        
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.position += new Vector3(DeltaHalfScreen.x / (Screen.width - Screen.width*0.2f),
                    -Input.GetAxis("Mouse ScrollWheel") * 20.0f, DeltaHalfScreen.y / (Screen.height));
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.position += new Vector3(-DeltaHalfScreen.x / (Screen.width - Screen.width * 0.2f),
                    -Input.GetAxis("Mouse ScrollWheel") * 20.0f, -DeltaHalfScreen.y / (Screen.height));
        }

        

        MouseLastPos = Input.mousePosition;
    }*/

    public Vector3 GetHitPoint()
    {
        if (!Hitted) return Vector3.zero;

        return MouseHit.point;
    }

    /* ///////////////////////////////////////////////
     * //Funções para checar colisão do mouse       //
     * //Chamá-las junto com o RefreshHit() no final//
     *////////////////////////////////////////////////

    string LastHitName = null;
    string LastHitTag = null;
    Transform LastHitTransform = null;
    public void RefreshHit()
    {
        if (!Hitted) return;
        LastHitName = MouseHit.transform.name;
        LastHitTag = MouseHit.transform.tag;
        LastHitTransform = MouseHit.transform;
    }

	public bool OnCursorEnter (string TagOrName)
    {
        if (!Hitted) return false;
        if (MouseHit.transform.name != LastHitName && MouseHit.transform.name == TagOrName)
            return true;
        if (MouseHit.transform.tag != LastHitTag && MouseHit.transform.tag == TagOrName)
            return true;

		return false;
	}
    public bool OnCursorEnter(Transform tTransform)
    {
        if (!Hitted) return false;
        if (MouseHit.transform != LastHitTransform && MouseHit.transform == tTransform)
            return true;

        return false;
    }

    public bool OnCursorStay(string TagOrName)
    {
        if (!Hitted) return false;
        if (MouseHit.transform.name == TagOrName)
            return true;

        if (MouseHit.transform.tag == TagOrName)
            return true;

        return false;
    }
    public bool OnCursorStay(Transform tTransform)
    {
        if (!Hitted) return false;
        if (MouseHit.transform == tTransform)
            return true;

        return false;
    }
    
    public bool OnCursorExit (string TagOrName)
    {
        if (!Hitted) return false;
        if (MouseHit.transform.name != LastHitName && LastHitName == TagOrName)
            return true;
        if (MouseHit.transform.tag != LastHitTag && LastHitTag == TagOrName)
            return true;

        return false;
    }
    public bool OnCursorExit(Transform tTransform)
    {
        if (!Hitted) return false;
        if (MouseHit.transform != LastHitTransform && LastHitTransform == tTransform)
            return true;

        return false;
    }
}