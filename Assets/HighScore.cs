using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "HighScore", menuName = "HighScore", order = 1)]
public class HighScore : ScriptableObject 
{
    public int[] scores = {0,0,0,0,0,0,0,0,0,0};
    public int index = 0;
}
