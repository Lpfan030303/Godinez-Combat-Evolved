using UnityEngine;
using System.Collections;

public class characterselec : MonoBehaviour {

	public Transform menuSel, moreInfo;
	public void MoreInfo (bool clicked){
		
		if (clicked == true) {
			moreInfo.gameObject.SetActive (clicked);
			menuSel.gameObject.SetActive (false);
		} else {
			moreInfo.gameObject.SetActive (clicked);
			menuSel.gameObject.SetActive (true);
		}

	}

}
