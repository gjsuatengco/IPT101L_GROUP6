using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SkinHandler : MonoBehaviour
{
    public SpriteRenderer sr1;
    public SpriteRenderer sr2;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkinP1 = 0;
    private int selectedSkinP2 = 0;
    public GameObject characterskin;

    public void nextOption(){
        selectedSkinP1 = selectedSkinP1 + 1;
        if(selectedSkinP1 == skins.Count){
            selectedSkinP1 = 0;
        }
        sr1.sprite = skins[selectedSkinP1];
    }

    public void backOption(){
        selectedSkinP1 = selectedSkinP1 - 1;
        if(selectedSkinP1 < 0){
            selectedSkinP1 = skins.Count - 1;
        }
        sr1.sprite = skins[selectedSkinP1];
    }

    public void nextOptionP2(){
        selectedSkinP2 = selectedSkinP2 + 1;
        if(selectedSkinP2 == skins.Count){
            selectedSkinP2 = 0;
        }
        sr2.sprite = skins[selectedSkinP2];
    }

    public void backOptionP2(){
        selectedSkinP2 = selectedSkinP2 - 1;
        if(selectedSkinP2 < 0){
            selectedSkinP2 = skins.Count - 1;
        }
        sr2.sprite = skins[selectedSkinP2];
    }

    public void playGame(){
        SceneManager.LoadScene("MainGame");
    }
}
