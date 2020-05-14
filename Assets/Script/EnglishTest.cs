using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;


public class EnglishTest : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool nextQuestion;
    public static bool preQuestion;
    public int questionNr;

    public GameObject buttonPre;
    public GameObject buttonNext;

    public static bool clickA;
    public static bool clickB;
    public static bool clickC;
    public static bool clickD;

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public Button buttonD;

    public string fileName = "Study/Answer.csv";

    ColorBlock colorBlock;
    ColorBlock defaultColorBlock;


    string[] questions;
    TextMeshProUGUI questionText;
    string Test1;
    string[] answers;
    string answersString;
    

    void Start()
    {

        colorBlock = new ColorBlock();
        //colorBlock.normalColor = new Color(0.16f, 0.59f, 0.92f);

        defaultColorBlock = new ColorBlock();
       // defaultColorBlock.normalColor = Color.white;

        colorBlock.pressedColor = new Color(1f, 0.0f, 0.0f, 1.0f);
        colorBlock.highlightedColor = new Color(0f, 1f, 0.0f, 1.0f);
        colorBlock.disabledColor = new Color(0f, 0f, 1, 1.0f);

        defaultColorBlock.pressedColor = new Color(1f, 0.0f, 0.0f, 1.0f);
        defaultColorBlock.highlightedColor = new Color(1f, 1f, 1f, 1.0f);
        defaultColorBlock.disabledColor = new Color(0f, 0f, 1, 1.0f);

        nextQuestion = false;
        preQuestion = false;

        questionNr = 0;
        questionText = gameObject.GetComponent<TextMeshProUGUI>();
       // questions = new string[20];

        questions = new string[ ]{"1. \"Are you sure this will do for you?\"\n \"I think I can _____________ .\"\nA. have it done \nB. get it to do \nC.make it do \nD. do it do ",
                               "2. Professor Wilson ____________ to give a paper on world politics. \nA.complied \nB.accepted \nC.consented \nD.submitted",
                               "3. When a soldier receives orders, he has to obey them ____________ . \nA.prudently \nB. promptly \nC. profoundly \nD. patiently",
                               "4. _____________ is the act of insulting or showing contempt for God. \nA. delinquency \nB. piety \nC. reverence \nD. blasphemy",
                               "5. Because Mr Jones is ____________ , he is not so likely to regard you as a threat. \nA. self-confident \nB. self-assertive \nC. self-contained \nD. self-conscious",
                               "6. She tried to ________________ me into going shopping with her, but I refused. \nA. make \nB. persuade \nC. convince \nD. suggest",
                               "7. A deluge is the same as a _______________ . \nA. downpour \nB. blizzard \nC. hailstorm \nD. meltdown",
                               "8. The new manager doesn’t ______________ of smoking in the conference room. \nA. allow \nB. accept \nC. approve \nD. permit",
                               "9. He is as good at ______________ others as he is at praising himself. \nA. flaying \nB. flaunting \nC. flabbergasting \nD. flattering",
                               "10. These days almost anything _________________. \nA. does \nB. goes \nC. makes \nD. clings",
                               "11. Who goes there? Friend or _______________? \nA. fiend \nB. enemy \nC. fob \nD.foe",
                               "12. I work for an insurance company and deal with all the _____________ that come in. \nA. queries \nB. inquiries \nC. requests \nD. questions",
                               "13. George is doing an additional _______________ in graphic design. \nA. research \nB. practice \nC. course \nD. study",
                               "14. Far-_____________ actions have a very wide influence and effect a great number of things. \nA. fetched \nB. stretching \nC. sighted \nD. reaching",
                               "15. Thank God you have come _____________! The train leaves in three minutes. \nA. lastly \nB. finally \nC. at the end \nD. at last",
                               "16. Mr Jones said the plan had _____________ similarities with the previous one. \nA. superfluous \nB. superstitious \nC. superficial \nD. supercilious",
                               "17. The _____________ period of economic growth soon ended. \nA. brief \nB.concise \nC.abrupt \nD.little",
                               "18. They were _______________ even to the charm, eloquence and beauty of Miss Finchley. \nA. impertinent \nB. impervious \nC. impious \nD. impeccable",
                               "19. All conference participants wore ______________ with their names. \nA. badges \nB. tags \nC. labels \nD. signs",
                               "20. Their _____________ made them take a trip round the world. \nA. watchband \nB. wanderlust \nC.walloping \nD. wastage"
        };

        answers = new string[] {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};
        

    }

    // Update is called once per frame
    void Update()
    {

        if (PostureDetection.testModule)
        {
            //Debug.Log("let's see");

            if (questionNr == 0)
            {
                //Debug.Log(questionNr + "!!!!");
                buttonPre.SetActive(false);
            } else
            {
                buttonPre.SetActive(true);
            }

            UpdateButtonColor();

            if (nextQuestion == true)
            {
                questionNr++;
                UpdateQuestion(questionNr);
                nextQuestion = false;
            }

            if (preQuestion == true)
            {

                questionNr--;
                UpdateQuestion(questionNr);
                preQuestion = false;
            }

            UpdateAnswer();

            if (questionNr == 19)
            {
                SaveAnswer();
            }
        }

       
    }

    void UpdateQuestion(int questionNr)
    {
        questionText.text = questions[questionNr];
    }

    void UpdateAnswer()
    {
        if(clickA)
        {
            answers[questionNr] = "A";
            clickA = false;
            PrintAnswers();
        }

        if(clickB)
        {
            answers[questionNr] = "B";
            clickB = false;
            PrintAnswers();
        }

        if (clickC)
        {
            answers[questionNr] = "C";
            clickC = false;
            PrintAnswers();

        }

        if (clickD)
        {
            answers[questionNr] = "D";
            clickD = false;
            PrintAnswers();

        }

    }

    void SaveAnswer()
    {
        ConvertArrayToString();
        File.WriteAllText(fileName, answersString);
    }

    void ConvertArrayToString()
    {
        answersString = "";
        for (int i=0; i<20; i++)
        {
            answersString += answers[i];
        }
    }


    void PrintAnswers()
    {
        string ans = "";
        for(int i =0; i< answers.Length; i++)
        {
            ans += answers[i];
        }
        Debug.Log(ans);
    }

    void UpdateButtonColor()
    {
        
        
        if (answers[questionNr] == "A")
        {
            buttonA.image.color = new Color(0.16f, 0.59f, 0.92f);
            buttonB.image.color = Color.white;
            buttonC.image.color = Color.white;
            buttonD.image.color = Color.white;

            /*buttonA.colors = colorBlock;
            buttonB.colors = defaultColorBlock;
            buttonC.colors = defaultColorBlock;
            buttonD.colors = defaultColorBlock;*/

        } else if (answers[questionNr] == "B")
        {
            /*buttonA.colors = defaultColorBlock;
            buttonB.colors = colorBlock;
            buttonC.colors = defaultColorBlock;
            buttonD.colors = defaultColorBlock;*/
            buttonB.image.color = new Color(0.16f, 0.59f, 0.92f);
            buttonA.image.color = Color.white;
            buttonC.image.color = Color.white;
            buttonD.image.color = Color.white;

        } else if (answers[questionNr] == "C")
        {
            buttonC.image.color = new Color(0.16f, 0.59f, 0.92f);
            buttonA.image.color = Color.white;
            buttonB.image.color = Color.white;
            buttonD.image.color = Color.white;
        } else if (answers[questionNr] == "D")
        {
            buttonD.image.color = new Color(0.16f, 0.59f, 0.92f);
            buttonA.image.color = Color.white;
            buttonB.image.color = Color.white;
            buttonC.image.color = Color.white;
        } else
        {
            buttonA.image.color = Color.white;
            buttonB.image.color = Color.white;
            buttonC.image.color = Color.white;
            buttonD.image.color = Color.white;
        }
    }
    
}
