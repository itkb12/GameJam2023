using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PieceInteraction : Interactable
{
    override public void TextToAppear()
    {
        if (this.name == "Piece1")
        {
            Globals.foundPiece[0] = true;
            textBoxText.text = "Found a piece of the picture";
            Destroy(this.gameObject);
        }
        else if (this.name == "Piece2")
        {
            Globals.foundPiece[1] = true;
            textBoxText.text = "Found a piece of the picture";
            Destroy(this.gameObject);
        }
        else if (this.name == "Piece3")
        {
            Globals.foundPiece[2] = true;
            textBoxText.text = "Found a piece of the picture";
            Destroy(this.gameObject);
        }
        else if (this.name == "Piece4")
        {
            Globals.foundPiece[3] = true;
            textBoxText.text = "Found a piece of the picture";
            Destroy(this.gameObject);
        }

    }
}
