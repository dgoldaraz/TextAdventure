using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	private enum States{ presentation, farShelf_0, farShelf_1,exit_0, can, closeShelf_0,
						 exit_1, closeShelf_1, exit_2, cash, backDoor_0,
						 backDoor_1, backDoor_2, keysPanel_0, death_0, death_1, death_2,
						 death_3, death_4, phone_0, phone_1, police};
						 
	private States myState;
	public Text text;
	private int timesDead = 0;
	private bool updateDead = true;
	// Use this for initialization
	void Start () 
	{
		myState = States.presentation;
	}
	
	void Presenation()
	{
		text.text = "You are in a SuperMarket when suddenly one masked thieve points a gun to the dependant. "+
					"You quickly hides behind one of the shelves and think what to do.\n\n"+
					"Press Space to Start\n";
		
		if(Input.GetKeyDown(KeyCode.Space))       {myState = States.farShelf_0;}
	}
	
	void FarShelf()
	{
		text.text = "Yo can hear the thief making some noises, but you can't see him."+
					" Looking around you can see the exit door and a big self full of cans.\n\n"+
					"Press E to move to the Exit door\n"+
					"Press T to move close to the Till\n"+
					"Press C to get a Tomato soup Can\n";
					
		if(Input.GetKeyDown(KeyCode.E))       {myState = States.exit_0;}
		else if(Input.GetKeyDown(KeyCode.T))  {myState = States.closeShelf_0;}
		else if(Input.GetKeyDown(KeyCode.C))  {myState = States.can;}
	}
	
	void Exit0()
	{
		text.text = "You get next to the exit door, but there is another thief outside waiting!\n" +
					"If you dare to escape he probably shoot you.\n\n"+
					"Press R to Return\n"+
					"Press E to Escape\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.farShelf_0;}
		else if(Input.GetKeyDown(KeyCode.E))  {myState = States.death_0;}
	}
	
	void Death0()
	{
		if(updateDead)
		{
			timesDead++;
			updateDead = false;
		}
		text.text = "\"I can do it!\" You think, so you open the door and with a great impulse you run to your freedom."+
					" But you won't go to far until BANG! you feel a sharp pain in the back and hit the ground."+
					"\"I should have tried another option\", that's your last thought while you die...\n\n"+
					"Times Dead: " + timesDead +"\n"+
					"Press R or Space to Restart";
					
		if(Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Space))
		{
			updateDead = true;
			myState = States.presentation;
		}
	}
	void Death1()
	{
		if(updateDead)
		{
			timesDead++;
			updateDead = false;
		}
		text.text = "You run as fast as you can. The thief has seen you and start to move his hand."+
					"You throw the can to him, expecting to escape. The shoot pierces the can and hits you in the middle of the chest."+
					"\"I should have tried another option\", that's your last thought while you die...\n"+
					"Times Dead: " + timesDead +"\n"+
					"Press R or Space to Restart";
		
		if(Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Space))
		{
			updateDead = true;
			myState = States.presentation;
		}
	}
	
	void Death2()
	{
		if(updateDead)
		{
			timesDead++;
			updateDead = false;
		}
		text.text = "You open the door without making any noise, the freedom is in front of you, but you should look back"+
					"\"Hey you! Stop right now!\" you heard while you are running. You expect the next sound \"BANG, BANG\""+
					"\"I should have tried another option\", that's your last thought while you die...\n\n"+
					"Times Dead: " + timesDead +"\n"+
					"Press R or Space to Restart";
		
		if(Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Space))
		{
			updateDead = true;
			myState = States.presentation;
		}
	}
	void Death3()
	{
		if(updateDead)
		{
			timesDead++;
			updateDead = false;
		}
		text.text = "You search in the booth. \"Aha! Here is a customer number\" You start pressing the buttons and a lady ask what can she help with."+
					"\"Help! Please, the supermarket is being attacked and I dont know how many time...\" \"BANG, BANG\""+
					"\"I should have tried another option\", that's your last thought while you die...\n"+
					"Times Dead: " + timesDead +"\n"+
					"Press R or Space to Restart";
		
		if(Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Space))
		{
			updateDead = true;
			myState = States.presentation;
		}
	}
	void Death4()
	{
		if(updateDead)
		{
			timesDead++;
			updateDead = false;
		}
		text.text = "You leave the phone, really scared and try to hide. While you are turning around, the phone hit the ground."+
					"\"Hey! Is anybody there? Don't move\" You run away, hoping that the thief dont sho..\"BANG, BANG\""+
					"\"I should have tried another option\", that's your last thought while you die...\n\n"+
					"Times Dead: " + timesDead +"\n"+
					"Press R or Space to Restart";
		
		if(Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Space))
		{
			updateDead = true;
			myState = States.presentation;
		}
	}
	void CloseShelf_0()
	{
		text.text = "You can see the thief shouting to the dependant and holding a big gun. He can't see you but he looks really nervous. " +
					"The situation looks bad, and you don't dare to move closer while the thief is around.\n\n"+
					"Press R to Return\n";
					
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.farShelf_0;}
	}
	
	void Can()
	{
		text.text = "You have now a big heavy Tomato soup can." +
					" Clearly, you can't attack the thief with it but maybe it's useful.\n\n"+
					"Press E to move to the Exit door\n"+
					"Press T to Throw the can, make some noise and run to the Till.\n"+
					"Press R to Leave the can and Return\n";
					
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.farShelf_0;}
		if(Input.GetKeyDown(KeyCode.E))       {myState = States.exit_1;}
		if(Input.GetKeyDown(KeyCode.T))       {myState = States.closeShelf_1;}
	}
	
	void CloseShelf_1()
	{
		text.text = "The thief has moved away so this is your oportunity to try something."+
					"The bad news are that the dependant is with him, so you won't have any help."+
					"From here, you can see the Exit Door, a Back Door and the Till\n\n"+
					"Press E to move to the Exit.\n"+
					"Press B to move to the Back Door.\n"+
					"Press T to move to the Till.\n";
		
		if(Input.GetKeyDown(KeyCode.E))       	   {myState = States.exit_2;}
		else if(Input.GetKeyDown(KeyCode.B))       {myState = States.backDoor_0;}
		else if(Input.GetKeyDown(KeyCode.T))       {myState = States.keysPanel_0;}
	}
	
	void Exit1()
	{
		text.text = "You get next to the exit door, but there is another thief outside waiting!\n" +
					"If you dare to escape he probably shoot you. At least now you have the Tomato soup can.\n\n"+
					"Press R to Return\n"+
					"Press E to Escape\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.can;}
		else if(Input.GetKeyDown(KeyCode.E))  {myState = States.death_1;}
	}

	void Exit2()
	{
		text.text = "The exit door is open, and you can see another thief outside.\n" +
					"Suddenly, the thief move, it's your oportunity to escape!\n\n"+
					"Press R to Return\n"+
					"Press E to Escape\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.closeShelf_1;}
		else if(Input.GetKeyDown(KeyCode.E))  {myState = States.death_2;}
	}
		
	void BackDoor0()
	{
		text.text = "You are close to the back door which has a windows. Inside you can see a phone booth.\n" +
					"The door is close. Today its not your day.\n\n"+
					"Press T to move next to the Till\n"+
					"Press R to Return\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.closeShelf_1;}
		else if(Input.GetKeyDown(KeyCode.T))   {myState = States.keysPanel_0;}
	}
	void BackDoor1()
	{
		text.text = "You are close to the back door which has a windows. Inside you can see a phone booth.\n" +
					"One of the keys fits the locker and opens the door\n\n"+
					"Press P to move next to the Phone.\n"+
					"Press R to close the door and Return\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.keysPanel_0;}
		else if(Input.GetKeyDown(KeyCode.P))   {myState = States.phone_0;}
	}
	void BackDoor2()
	{
		text.text = "You are close to the back door which has a windows. Inside you can see a phone booth.\n" +
					"One of the keys fits the locker and opens the door\n\n"+
					"Press P to move next to the Phone.\n"+
					"Press R to close the door and Return\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.keysPanel_0;}
		else if(Input.GetKeyDown(KeyCode.P))   {myState = States.phone_1;}
	}
	void KeyPanel0()
	{
		text.text = "Next to the till you can see some keys. It should open something so beter get it.\n" +
					"Also, the cash register seems to be open.\n\n"+
					"Press B to get the keys and move to the Back Door\n"+
					"Press M to get the keys, stole some Money and move to the Back Door.\n"+
					"Press R to move back to the corridor.\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.closeShelf_1;}
		else if(Input.GetKeyDown(KeyCode.B))       {myState = States.backDoor_1;}
		if(Input.GetKeyDown(KeyCode.M))       {myState = States.backDoor_2;}
	}
	void Phone0()
	{
		text.text = "You catch the phone and press 112. \"Please, insert some coins\" you hear." +
					"You search in your pockets, but there is no coin. \"I cant go back...the thief is searching me.\" You think."+
					"Unbelievable! How can a phone not let me call for help? \n\n"+
					"Press C to try another Call\n"+
					"Press R to Return to the Back Door\n";
		
		if(Input.GetKeyDown(KeyCode.R))       {myState = States.backDoor_1;}
		else if(Input.GetKeyDown(KeyCode.C))   {myState = States.death_3;}
	}
	void Phone1()
	{
		text.text = "You catch the phone and press 112. \"Please, insert some coins\" you hear." +
					"You put some of the coins that you get from the cash machine. Also, you heard some noise behind you\n\n"+
					"Press P to call the Police.\n"+
					"Press H to Hide. \n";
		
		if(Input.GetKeyDown(KeyCode.P))       {myState = States.police;}
		else if(Input.GetKeyDown(KeyCode.H))   {myState = States.death_4;}
	}
	
	void Police()
	{
		text.text = "\"Hello? Police? I need some help please! The supermarket has been attack and I dont know how much time can I be hidden.\" you hear.\n" +
					"Ok, we are on your way. Hide and wait for us."+
					"You hide and waits. In five minutes you listen some strong noises. You close your eyes, waiting for the best."+
					"After a while, you can heard \"Are you all right? Dont you worry, we are here.\"\n"+
					"Congratulations! You won the game!!\n\n"+
					"Times Dead: " + timesDead +"\n"+
					"Press R to restart. \n";
		
		if(Input.GetKeyDown(KeyCode.R)|| Input.GetKeyDown(KeyCode.Space))       {myState = States.presentation;}
	}
	
	// Update is called once per frame
	void Update ()
	 {
		if(myState == States.presentation)      	{Presenation();}
		else if(myState == States.farShelf_0)      	{FarShelf();}
		else if( myState == States.exit_0)      	{Exit0();}
		else if( myState == States.closeShelf_0)	{CloseShelf_0();}
		else if( myState == States.can)         	{Can();}
		else if( myState == States.closeShelf_1)	{CloseShelf_1();}
		else if( myState == States.death_0)       	{Death0();}
		else if( myState == States.death_1)       	{Death1();}
		else if( myState == States.death_2)       	{Death2();}
		else if( myState == States.death_3)       	{Death3();}
		else if( myState == States.death_4)       	{Death4();}
		else if( myState == States.exit_1)      	{Exit1();}
		else if( myState == States.exit_2)      	{Exit2();}
		else if( myState == States.backDoor_0)      {BackDoor0();}
		else if( myState == States.keysPanel_0)     {KeyPanel0();}
		else if( myState == States.backDoor_1)     	{BackDoor1();}
		else if( myState == States.backDoor_2)     	{BackDoor2();}
		else if( myState == States.phone_0)     	{Phone0();}
		else if( myState == States.phone_1)     	{Phone1();}
		else if( myState == States.police)     		{Police();}
	}
}
