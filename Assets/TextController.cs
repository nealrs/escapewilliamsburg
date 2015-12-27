using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {venue, mta, cab, bar, drink, dj, dj2, smoke, outside, poetry, steve, over1, over2, over3};
	private States currentState;
	private int money;
	private bool vinyl;

	// Use this for initialization
	void Start () {
		money = 15;
		vinyl = false;
		currentState = States.venue;
	}

	// Update is called once per frame
	void Update () {
		if (currentState == States.venue) {Venue();}
		else if (currentState == States.mta) {Mta();}
		else if (currentState == States.cab) {Cab();}
		else if (currentState == States.bar) {Bar();}
		else if (currentState == States.drink) {Drink();}
		else if (currentState == States.dj) {Dj();}
//		else if (currentState == States.dj2) {Dj2();}
		else if (currentState == States.smoke) {Smoke();}
//		else if (currentState == States.outside) {Outside();}
//		else if (currentState == States.poetry) {Poetry();}
//		else if (currentState == States.steve) {Steve();}
//		else if (currentState == States.over1) {Over1();}
//		else if (currentState == States.over2) {Over2();}
//		else if (currentState == States.over3) {Over3();}

	}

	void Venue (){
		text.text = "You're on the street in Williamsburg after a secret acoustic Skrillex show. It's late, you want to get home, and your trust fund is running low ($"+money+").\n\n" +
		"Do you:\n\n- [T]ry the L train?\n- [H]ail a cab\n- [W]alk to your favorite speakeasy?";

		if (Input.GetKeyDown (KeyCode.T)) {
			currentState = States.mta;
		}
		else if (Input.GetKeyDown (KeyCode.H)) {
			currentState = States.cab;
		}
		else if (Input.GetKeyDown (KeyCode.W)) {
			currentState = States.bar;
		}
	}

	void Mta (){
		text.text = "Sorry bub, the L is fucked. You can't take the train home tonight.\n\n" +
		"Press [R] to return to the venue.";

		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.venue;
		}
	}

	void Cab ()
	{

		if (money <= 25) {
			text.text = "The ride home is at least $25, and you've only got $" + money + ".\n\n";
		} else {
			text.text = "Every Uber driver in NYC is on the UWS right now and all the cabbies are changing shifts. Sorry broheim.\n\n";
		}
		text.text += "Press [R] to return to the venue.";

		if (Input.GetKeyDown (KeyCode.R)) {
			currentState = States.venue;
		}
	}

	void Bar (){
		text.text = "Welcome to Defenestrator, Williamsburg's newest speakeasy. Bearded bartenders are mixing drinks and the DJ is remixing bluegrass records.\n\n" +
		"Do you:\n\n- [G]et a Drink?\n- [T]alk to the DJ?\n- [B]um a smoke outside?\n- [H]ead back to the venue?";


		if (Input.GetKeyDown (KeyCode.G)) {
			currentState = States.drink;
		}
		else if (Input.GetKeyDown (KeyCode.T)) {
			currentState = States.dj;
		}
		else if (Input.GetKeyDown (KeyCode.B)) {
			currentState = States.smoke;
		}
		else if (Input.GetKeyDown (KeyCode.H)) {
			currentState = States.venue;
		}
	}

	void Drink (){ 
		text.text = "I hope that $"+money+" craft cocktail was worth it, because now you're broke, drunk, and have no way to get home.\n\nG A M E  O V E R\n\nGotta admit though, it's a pretty chill way to go.\n\nPress [P] to play again.";

		if (Input.GetKeyDown (KeyCode.P)) {
			Start ();
		}
	}


	void Dj (){

		//print ("vinyl is: "+ vinyl);

		//if (vinyl == false) {
		text.text = "The DJ thinks your musical taste is really derivative.\n\nPress [H] to head back to the bar.";
		vinyl = true;
			//currentState = States.bar;

		/*}*else {
			text.text = "The DJ is busy right now.\n\nPress [H] to head back to the bar.";

			if (Input.GetKeyDown (KeyCode.H)) {
				currentState = States.bar;
			}

		}*/

			if (Input.GetKeyDown (KeyCode.H)) {
				currentState = States.bar;
			}

	}


	void Smoke (){

		if (vinyl == false) {
			text.text = "A wan looking art student hands you a Ligget -- but before you can light it, you get creamed by a BMX biker gang.\n\n G A M E  O V E R\n\n Press [P] to play again.";

		} else {
			text.text = "After scoring a rollie, you see Steve Burns from Blue's Clues performing slam poetry on the corner. He really digs your pocket square made out of marled yarn and drives you home in his DeLorean.\n\nS U C C E S S !!  Y O U  W I N !! \n\nPress [P] to play again.";
		}

		if (Input.GetKeyDown (KeyCode.P)) {
				Start ();
			}
	}



}
