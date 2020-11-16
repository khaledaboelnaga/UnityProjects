using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private string team;
    public InputField teamA1, teamA2, teamB1, teamB2;
    public Text teamANames, teamBNames;
    public  int teamAlphaScore;
    public  int teamBetaScore;
    public Button x;
    private int totalLammat = -195;
    private int totalKarohat = -130;
    private int totalMasaterMnEdena = -175;
    private int totalMasaterMnEdehom = -350;
    private Color red, blue;
    public bool kh,qs, qh, qd, qc = false;
    public bool alphaKH, alphaQS, alphaQH, alphaQD, alphaQC;
    public TextMeshProUGUI teamAScore;
    public TextMeshProUGUI teamAScore1;
    public TextMeshProUGUI teamBscore1;
    public TextMeshProUGUI teamBScore;
    // Start is called before the first frame update
    void Start()
    {

        teamAlphaScore = 0;
        teamBetaScore = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        teamAScore.text = teamAlphaScore.ToString();
        teamAScore1.text = teamAlphaScore.ToString();
        teamBScore.text = teamBetaScore.ToString();
        teamBscore1.text = teamBetaScore.ToString();
    }

    public void SetNames()
    {
        teamANames.text = "(" + teamA1.text + "-" + teamA2.text + ")";
        teamBNames.text = "(" + teamB1.text + "-" + teamB2.text + ")";
    }

    public void resetHand()
    {
        kh = false;
        qs = false;
        qh = false;
        qd = false;
        qc = false;
    }

    public void setSelectColor()
    {
        Debug.Log("ghyrt el loon");
        if (team == "alpha")
            //x.GetComponent
        if (team == "beta")
            x.GetComponent<Image>().color = new Color(180, 180, 250);
    }

    public void setDefaultHand()
    {
        if(team == "alpha")
        {
            alphaKH = false;
            alphaQS = false;
            alphaQH = false;
            alphaQD = false;
            alphaQC = false;
        }
        else
        {
            if (team == "beta")
            {
                alphaKH = true;
                alphaQS = true;
                alphaQH = true;
                alphaQD = true;
                alphaQC = true;
            }
        }

        
    }

    public void ResetDefaultHand()
    {
        if (team == "alpha")
        {
            alphaKH = false;
            alphaQS = false;
            alphaQH = false;
            alphaQD = false;
            alphaQC = false;
        }
        else
        {
            if (team == "beta")
            {
                alphaKH = true;
                alphaQS = true;
                alphaQH = true;
                alphaQD = true;
                alphaQC = true;
            }
        }


    }


    public void setQueensAndKingsTaken(int x)
    {
        if (x == 0)
            kh = true;
        if (x == 1)
            qs = true;
        if (x == 2)
            qh = true;
        if (x == 3)
            qd = true;
        if (x == 4)
            qc = true;
    }

    public void setHand(int x)
    {
        if (x == 0)
        {
            if (team == "alpha")
                alphaKH = true;
            else
                alphaKH = false;

        }

        if (x == 1)
        {
            if (team == "alpha")
                alphaQS = true;
            else
                alphaQS = false;

        }

        if (x == 2)
        {
            if (team == "alpha")
                alphaQH = true;
            else
                alphaQH = false;

        }

        if (x == 3)
        {
            if (team == "alpha")
                alphaQD = true;
            else
                alphaQD = false;

        }

        if (x == 4)
        {
            if (team == "alpha")
                alphaQC = true;
            else
                alphaQC = false;

        }

    }

    public void setLammatScore(int x)
    {
        if (team == "alpha") {
            teamAlphaScore += x;
            teamBetaScore += totalLammat - x;
        }

        if (team == "beta")
        {
            teamBetaScore += x;
            teamAlphaScore += totalLammat - x;
        }
    }

    public void setKarohatScore(int x)
    {
        if (team == "alpha")
        {
            teamAlphaScore += x;
            teamBetaScore += totalKarohat - x;
        }

        if (team == "beta")
        {
            teamBetaScore += x;
            teamAlphaScore += totalKarohat - x;
        }
    }

    public void setMasaterScoreAlpha()
    {
        //King Heart-----------------------------
        if (kh) 
         {
                if (alphaKH)
                    teamAlphaScore -= 75;
                else
                {
                    teamAlphaScore -= 150;
                    teamBetaScore += 75;
                }
         }
        else 
        {
            if (alphaKH)
            {
                teamBetaScore -= 150;
                teamAlphaScore += 75;
            }
            else
            {
                teamBetaScore -= 75;
            }
        }
        //Queen Spades-----------------------------
        if (qs)
        {
            if (alphaQS)
                teamAlphaScore -= 25;
            else
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
        }
        else 
        {
            if (alphaQS)
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
            else
            {
                teamBetaScore -= 25;
            }
        }
        //Queen Heart-----------------------------
        if (qh)
        {
            if (alphaQH)
                teamAlphaScore -= 25;
            else
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
        }
        else
        {
            if (alphaQH)
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
            else
            {
                teamBetaScore -= 25;
            }
        }
        //Queen Diamonds-----------------------------
        if (qd)
        {
            if (alphaQD)
                teamAlphaScore -= 25;
            else
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
        }
        else
        {
            if (alphaQD)
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
            else
            {
                teamBetaScore -= 25;
            }
        }
        //Queen Clubs-----------------------------
        if (qc)
        {
            if (alphaQC)
                teamAlphaScore -= 25;
            else
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
        }
        else
        {
            if (alphaQC)
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
            else
            {
                teamBetaScore -= 25;
            }
        }


    }

    public void setMasaterScoreBeta()
    {   
        //KH------------------------------------
        if (kh)
        {
            if (!alphaKH)
                teamBetaScore -= 75;
            else
            {
                teamBetaScore -= 150;
                teamAlphaScore += 75;
            }
        }
        else
        {
            if (!alphaKH)
            {
                teamAlphaScore -= 150;
                teamBetaScore += 75;
            }
            else
            {
                teamAlphaScore -= 75;
            }
        }
        //QS------------------------------------
        if (qs)
        {
            if (!alphaQS)
                teamBetaScore -= 25;
            else
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
        }
        else
        {
            if (!alphaQS)
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
            else
            {
                teamAlphaScore -= 25;
            }
        }
        //QH------------------------------------
        if (qh)
        {
            if (!alphaQH)
                teamBetaScore -= 25;
            else
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
        }
        else
        {
            if (!alphaQH)
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
            else
            {
                teamAlphaScore -= 25;
            }
        }
        //QD------------------------------------
        if (qd)
        {
            if (!alphaQD)
                teamBetaScore -= 25;
            else
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
        }
        else
        {
            if (!alphaQD)
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
            else
            {
                teamAlphaScore -= 25;
            }
        }
        //QC------------------------------------
        if (qc)
        {
            if (!alphaQC)
                teamBetaScore -= 25;
            else
            {
                teamBetaScore -= 50;
                teamAlphaScore += 25;
            }
        }
        else
        {
            if (!alphaQC)
            {
                teamAlphaScore -= 50;
                teamBetaScore += 25;
            }
            else
            {
                teamAlphaScore -= 25;
            }
        }

    }

    public void setJacksScore(int x)
    {
        if (team == "alpha")
        {
            teamAlphaScore += x;
            teamBetaScore += 500 - x;
        }
        if (team == "beta")
        {
            teamBetaScore += x;
            teamAlphaScore += 500 - x;
        }


    }



    public void setMasterScore()
    {
        if (team == "alpha")
            setMasaterScoreAlpha();
        if (team == "beta")
            setMasaterScoreBeta();
    }

    public void setAlpha()
    {
        team = "alpha";
    }

    public void setBeta()
    {
        team = "beta";
    }
}
