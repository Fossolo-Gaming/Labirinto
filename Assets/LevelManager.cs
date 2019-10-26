using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Transform player;

    public List<Level> levels;

    private int levelIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Level l in levels)
        {
            l.Board.SetActive(false);
        }

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    public void LoadLevelIndex(int index)
    {
        if (levels.Count <= index) return;

        //deactivate previous level
        levels[levelIndex].Board.SetActive(false);

        levelIndex = index;

        //activate next one
        levels[levelIndex].Board.SetActive(true);

        //put pacman in starting point...
        player.position = levels[levelIndex].GetStartPoint().position;
    }

    public void NextLevel()
    {
        if (levels.Count <= levelIndex + 1) return;
        LoadLevelIndex(levelIndex + 1);
    }
}

[System.Serializable]
public class Level 
{
    public string name;
    public GameObject Board;
    public Transform GetStartPoint()
    {
        foreach (Transform t in Board.transform)
        {
            if (t.name == "starting point") {
                return t;
            }
        }
        Debug.LogError("not starting point in maze. Name the transform 'starting point' ");
        return null;
    }
}
