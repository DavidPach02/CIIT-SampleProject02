using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Player name
    public string playerName;

    // Puzzle game
    // Number of moves that the players can do in order to exit
    // Moves can be UP, DOWN, LEFT, RIGHT
    // Player must escape in a set number of moves

    public int numberOfMoves;
    public int currentMove = 0;
    public string[] moves = { "UP", "DOWN", "LEFT", "RIGHT" };

    public List<string> moveAnswer;
    public List<string> playerMoves;

    // Start is called before the first frame update
    void Start()
    {
        // While the player moves are still less than the number of moves
        while (currentMove < numberOfMoves)
        {
            // Player can declare move (0 - 3)
            int randomNumber = Random.Range(0, moves.Length);
            string moveName = moves[randomNumber];
            Debug.Log("[" + currentMove + "] " + playerName + " moves " + moveName);

            playerMoves.Add(moveName);
            currentMove++;
        }

        // Declare if the player successfully got the code
        Debug.Log(playerName + " cracked the code? " + IsCodeCracked(moveAnswer, playerMoves));
    }

    bool IsCodeCracked(List<string> movesA, List<string> movesB)
    {
        // After the number of moves are exhausted
        // Check if player got the code
        for (int i = 0; i < playerMoves.Count; i++)
        {
            if (playerMoves[i] != moveAnswer[i])
            {
                return false;
            }
        }

        return true;
    }

    void ThisIsMyMethod()
    {
        Debug.Log("HELLO WORLD!");
    }
}
