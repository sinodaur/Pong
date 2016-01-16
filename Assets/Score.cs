using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    string score;
    public int player1Score;
    public int player2Score;
    TextMesh textMesh;

    
    // Use this for initialization
	void Start () {
        score = "0 : 0";
        player1Score = 0;
        player2Score = 0;
        textMesh = this.GetComponent<TextMesh>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        
        score = player1Score + " : " + player2Score;
        textMesh.text = score;
	}
}
