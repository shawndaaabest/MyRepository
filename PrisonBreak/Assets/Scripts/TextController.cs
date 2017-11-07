using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    enum states {cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom,
        corridor_0, stairs_0, floor, closet_door, corridor_1, stairs_1, in_closet };
    public Text myText;

    states myState;

    void Start()
    {
        myState = states.cell;
        //Initialize myState to cell
        cell();
    }

    void cell()
    {
        myText.text = "You are in a prison cell and want to escape." +
            "There are some dirty sheets on the bed, a mirror on the wall " +
            "and the door is locked from the outside \n\n" +
            "Press S to view the sheets, M to view the mirror and L to view the lock.";
    
        if (Input.GetKeyDown(KeyCode.S)) { myState = states.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.M)) { myState = states.mirror; }
        else if (Input.GetKeyDown(KeyCode.L)) { myState = states.lock_0; }
    }

    void sheets_0()
    {
        myText.text = "These sheets are quite dirty; What would you expect from this shitty prison?" +
            "\n\nPress R to return to the centre of the cell";

        if(Input.GetKeyDown(KeyCode.R)) { myState = states.cell; }
    }

    void lock_0()
    {
        myText.text = "This is one of those button locks. I have no idea what the combination is" +
            "\nI wish I could somehow see where the oily fingerprints were." +
            "\n\nPress R to return to the centre of the room";

        if (Input.GetKeyDown(KeyCode.R)) { myState = states.cell; }
    }

    void mirror()
    {
        myText.text = "This old and dirty mirror on the wall seems to be loose!" +
            "\n\n Press T to take the mirror or R to return to the centre of the room.";

        if (Input.GetKeyDown(KeyCode.T)) { myState = states.cell_mirror; }
        if (Input.GetKeyDown(KeyCode.R)) { myState = states.cell; }
    }
    
    void cell_mirror()
    {
        myText.text = "I'm still in my cell and my urge to escape, though empowering, " +
            "is depleting" +
            "\nThere are still some dirty sheets on the bed and the cell door is still firmly locked." +
            "\n\nPress S to view the sheets or L to view the lock";

        if (Input.GetKeyDown(KeyCode.S)) { myState = states.sheets_1; }
        if (Input.GetKeyDown(KeyCode.L)) { myState = states.lock_1; }
    }

    void sheets_1()
    {
        myText.text = "Holding a mirror in your hand wont make the sheet less disgusting!" +
            "\nPress R to return back to the centr of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = states.cell_mirror; }
    }

    void lock_1()
    {
        myText.text = "I carefully put the mirror thtought the rusty bars and turn it round to" +
            "view the lock. " +
            "\n You can now see the greesy fingerprints on the buttons." +
            "\nAfter many, many tries with different combinations, I finally guess the right sequence." +
            "\n\nPress O to open or R to go back in the centr of the cell.";

        if (Input.GetKeyDown(KeyCode.O)) { myState = states.corridor_0; }
        if (Input.GetKeyDown(KeyCode.R)) { myState = states.cell_mirror; }
    }

    void corridor_0()
    {
        myText.text = "You're free from the ridiculous cell, " +
            "\nnow to deal with the hundreds of guards :)" +
            "\nYou notice there are somes tairs to your left, a dead end with something shiny on the floor ahead of you" +
            "\nand a closet door to your right" +
            "\n\nYou can press S to climb the stairs,  F to view the floor or C to enter through the closet door.";
        
        if (Input.GetKeyDown(KeyCode.S)) { myState = states.stairs_0; }
        if (Input.GetKeyDown(KeyCode.F)) { myState = states.floor; }
        if (Input.GetKeyDown(KeyCode.C)) { myState = states.closet_door; }
    }

    void stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light." +
            "\nYou realize it isn't even break time yet, and you'd be cougt immediately." +
            "\nYou slither back down the stairs and reconsider." +
            "\n\nPres R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = states.corridor_0; }
    }

    void floor()
    {
        myText.text = "Rummaging around on the durty floor, you find a hairclip" +
            "\n\nPress ENTER for ok";

        if (Input.GetKeyDown(KeyCode.Return)) { myState = states.corridor_1; }
    }

    void closet_door()
    {
        myText.text = "You are lookign at a closet door, unfortunately it's locked." +
            "\nMaybe you could find something around to help incourage it open?" +
            "\n\nPress R to return to the corridor.";

        if (Input.GetKeyDown(KeyCode.R)) { myState = states.corridor_0; }
    }

    void corridor_1()
    {
        myText.text = "Still in the corridor, Floor still dirty, Still isn't break time, Hairclip in hand. " +
            "\nNow what? " +
            "\nYou wonder if that lock on the closet would succumb to " +
            "\n\to some lock-picking?" +
            "\n\nPress L to try unlocking the closet door or S to try the stairs.";

        if (Input.GetKeyDown(KeyCode.S)) { myState = states.stairs_1; }
        if (Input.GetKeyDown(KeyCode.L)) { myState = states.in_closet; }
    }

    void Update () {
        //Check the current state
        if (myState == states.cell) { cell(); }
        else if (myState == states.sheets_0) { sheets_0(); }
        else if (myState == states.mirror) { mirror(); }
        else if (myState == states.lock_0) { lock_0(); }
        else if (myState == states.cell_mirror) { cell_mirror(); }
        else if (myState == states.sheets_1) { sheets_1(); }
        else if (myState == states.lock_1) { lock_1(); }
        else if (myState == states.freedom) { corridor_0(); }
    }
}
