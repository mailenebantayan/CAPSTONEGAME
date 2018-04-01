using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMECONTROLLER : MonoBehaviour {

	public GameObject Story1 ; 

	public GameObject Story2;

	public GameObject Story3;

	public GameObject Story4;

	public GameObject Story5;

	public GameObject Story6;

	public GameObject Story7;

	public GameObject Story8;

	public GameObject Story9;

	public GameObject Story10;

	public GameObject Story11;

	public GameObject Story12;

	public GameObject Story13;

	public GameObject Story14;

	public GameObject Story15;

	public GameObject Story16;

	public GameObject Story17;

	public GameObject Story18;


	// Use this for initializatio
	void Start () {
	}

	public void SkipButton(){
		SceneManager.LoadScene ("level1.");
	}

		public void NextStory () {
			Story1.SetActive (false);
			Story2.SetActive (true);
	}

		public void NextStory2 () {
		Story2.SetActive (false);
		Story3.SetActive (true);
	}

		public void PreviousStory2 () {
		Story1.SetActive (true);
		Story2.SetActive (false);
	}

		public void NextStory3 (){
		Story3.SetActive (false);
		Story4.SetActive (true);
	}

		public void PreviousStory3 (){
		Story2.SetActive (true);
		Story3.SetActive (false);
	}

		public void NextStory4 () {
		Story4.SetActive (false);
		Story5.SetActive (true);
	}

	public void PreviousStory4 (){
		Story3.SetActive (true);
		Story4.SetActive (false);
	}
	public void NextStory5 (){
		Story5.SetActive (false);
		Story6.SetActive (true);
	}

	public void PreviousStory5 (){
		Story4.SetActive (true);
		Story5.SetActive (false);
	}
	public void NextStory6 (){
		Story6.SetActive (false);
		Story7.SetActive (true);
	}
	public void PreviousStory6 (){
		Story5.SetActive (true);
		Story6.SetActive (false);
	}
	public void NextStory7 (){
		Story7.SetActive (false);
		Story8.SetActive (true);
	}
	public void PreviousStory7 (){
		Story6.SetActive (true);
		Story7.SetActive (false);
	}
	public void NextStory8 (){
		Story8.SetActive (false);
		Story9.SetActive (true);
	}
	public void PreviousStory8 (){
		Story7.SetActive (true);
		Story8.SetActive (false);
	}
	public void NextStory9 (){
		Story9.SetActive (false);
		Story10.SetActive (true);
	}
	public void PreviousStory9 (){
		Story8.SetActive (true);
		Story9.SetActive (false);
	}
	public void NextStory10 (){
		Story10.SetActive (false);
		Story11.SetActive (true);
	}
	public void PreviousStory10 (){
		Story9.SetActive (true);
		Story10.SetActive (false);
	}
	public void NextStory11 (){
		Story11.SetActive (false);
		Story12.SetActive (true);
	}
	public void PreviousStory11 (){
		Story10.SetActive (true);
		Story11.SetActive (false);
	}
	public void NextStory12 (){
		Story12.SetActive (false);
		Story13.SetActive (true);
	}

	public void PreviousStory12 (){
		Story11.SetActive (true);
		Story12.SetActive (false);
	}
	public void NextStory13 (){
		Story13.SetActive (false);
		Story14.SetActive (true);
	}

	public void PreviousStory13 (){
		Story12.SetActive (true);
		Story13.SetActive (false);
	}
	public void NextStory14 (){
		Story14.SetActive (false);
		Story15.SetActive (true);
	}

	public void PreviousStory14 (){
		Story13.SetActive (true);
		Story14.SetActive (false);
	}
	public void NextStory15 (){
		Story15.SetActive (false);
		Story16.SetActive (true);
	}

	public void PreviousStory15 (){
		Story14.SetActive (true);
		Story15.SetActive (false);
	}
	public void NextStory16 (){
		Story16.SetActive (false);
		Story17.SetActive (true);
	}

	public void PreviousStory16 (){
		Story15.SetActive (true);
		Story16.SetActive (false);
	}
	public void NextStory17 (){
		Story17.SetActive (false);
		Story18.SetActive (true);
	}

	public void PreviousStory17 (){
		Story16.SetActive (true);
		Story17.SetActive (false);
	}
 
	public void PreviousStory18 (){
		Story17.SetActive (true);
		Story18.SetActive (false);
	}

		// Update is called once per frame
	void Update () {
	}
}