using UnityEngine;

public static class Scoreing {
	private static int score=0;

	
	public static void AddScore(){
		score++;
	}
	public static int GetScore(){
		return score;
	}
	
}
