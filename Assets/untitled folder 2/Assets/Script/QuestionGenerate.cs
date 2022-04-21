using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public int numAnswered = 0;
    public GameOver GameOverScreen;

    // Update is called once per frame
    void Update()
    {
        if (displayingQuestion == false && numAnswered < 11)
        {
            displayingQuestion = true;
            questionNumber = Random.Range(1, 21);
            if (questionNumber == 1)
            {
                Quiz.newQuestion = "What is 3!?";
                Quiz.newA = "9";
                Quiz.newB = "6";
                Quiz.newC = "30";
                Quiz.newD = "1";
                actualAnswer = "B";
                numAnswered++;
            }
            if (questionNumber == 2)
            {
                Quiz.newQuestion = "Who is the current US President?";
                Quiz.newA = "Joe Biden";
                Quiz.newB = "Donald Trump";
                Quiz.newC = "Barack Obama";
                Quiz.newD = "Al Gore";
                actualAnswer = "A";
                numAnswered++;
            }
            if (questionNumber == 3)
            {
                Quiz.newQuestion = "What is sodium?";
                Quiz.newA = "Sugar";
                Quiz.newB = "Pepper";
                Quiz.newC = "Salt";
                Quiz.newD = "Mustard";
                actualAnswer = "C";
                numAnswered++;
            }
            if (questionNumber == 4)
            {
                Quiz.newQuestion = "Where is the Great Barrier Reef?";
                Quiz.newA = "Japan";
                Quiz.newB = "Indonesia";
                Quiz.newC = "Brazil";
                Quiz.newD = "Australia";
                actualAnswer = "D";
                numAnswered++;
            }
            if (questionNumber == 5)
            {
                Quiz.newQuestion = "Programming language for beginners?";
                Quiz.newA = "C++";
                Quiz.newB = "Java";
                Quiz.newC = "C";
                Quiz.newD = "Python";
                actualAnswer = "B";
                numAnswered++;
            }
            if (questionNumber == 6)
            {
                Quiz.newQuestion = "What Disney Villain is based on an octopus?";
                Quiz.newA = "Fairy Godmother";
                Quiz.newB = "Jafar";
                Quiz.newC = "Maleficent";
                Quiz.newD = "Ursula";
                actualAnswer = "D";
                numAnswered++;
            }
            if (questionNumber == 7)
            {
                Quiz.newQuestion = "How many stars are in the American flag?";
                Quiz.newA = "48";
                Quiz.newB = "51";
                Quiz.newC = "50";
                Quiz.newD = "13";
                actualAnswer = "C";
                numAnswered++;
            }
            if (questionNumber == 8)
            {
                Quiz.newQuestion = "What does 'Sora' mean in English?";
                Quiz.newA = "Sky";
                Quiz.newB = "Sea";
                Quiz.newC = "Fly";
                Quiz.newD = "Wind";
                actualAnswer = "A";
                numAnswered++;
            }
            if (questionNumber == 9)
            {
                Quiz.newQuestion = "What animal has no arms or legs?";
                Quiz.newA = "Hippopotamus";
                Quiz.newB = "Snakes";
                Quiz.newC = "Tigers";
                Quiz.newD = "Dolphins";
                actualAnswer = "B";
                numAnswered++;
            }
            if (questionNumber == 10)
            {
                Quiz.newQuestion = "How many Harry Potter films were made?";
                Quiz.newA = "9";
                Quiz.newB = "7";
                Quiz.newC = "8";
                Quiz.newD = "10";
                actualAnswer = "C";
                numAnswered++;
            }
            if (questionNumber == 11)
            {
                Quiz.newQuestion = "What color is the sun?";
                Quiz.newA = "Yellow";
                Quiz.newB = "Blue";
                Quiz.newC = "Red";
                Quiz.newD = "White";
                actualAnswer = "D";
                numAnswered++;
            }

            if (questionNumber == 12)
            {
                Quiz.newQuestion = "What vegetable improves eyesight";
                Quiz.newA = "Carrot";
                Quiz.newB = "Celery";
                Quiz.newC = "Eggplant";
                Quiz.newD = "Broccoli";
                actualAnswer = "A";
                numAnswered++;
            }

            if (questionNumber == 13)
            {
                Quiz.newQuestion = "How many continents are there?";
                Quiz.newA = "6";
                Quiz.newB = "7";
                Quiz.newC = "9";
                Quiz.newD = "4";
                actualAnswer = "B";
                numAnswered++;
            }

            if (questionNumber == 14)
            {
                Quiz.newQuestion = "Who is not a Looney Tunes character?";
                Quiz.newA = "Porky Pig";
                Quiz.newB = "Tazmanian Devil";
                Quiz.newC = "Tweety";
                Quiz.newD = "Chip";
                actualAnswer = "D";
                numAnswered++;
            }

            if (questionNumber == 15)
            {
                Quiz.newQuestion = "Who is Superman's real identity?";
                Quiz.newA = "Bruce Wayne";
                Quiz.newB = "Clark Kent";
                Quiz.newC = "Tony Stark";
                Quiz.newD = "Wally West";
                actualAnswer = "B";
                numAnswered++;
            }

            if (questionNumber == 16)
            {
                Quiz.newQuestion = "Which of these people died in 2022?";
                Quiz.newA = "Betty White";
                Quiz.newB = "Kobe Bryant";
                Quiz.newC = "Bruce Lee";
                Quiz.newD = "Gilbert Gotfried";
                actualAnswer = "D";
                numAnswered++;
            }

            if (questionNumber == 17)
            {
                Quiz.newQuestion = "What is 999x999 ";
                Quiz.newA = "818,181";
                Quiz.newB = "998,001";
                Quiz.newC = "810,001";
                Quiz.newD = "999,999";
                actualAnswer = "B";
                numAnswered++;
            }

            if (questionNumber == 18)
            {
                Quiz.newQuestion = "What planet has the most moons?";
                Quiz.newA = "Neptune";
                Quiz.newB = "Saturn";
                Quiz.newC = "Earth";
                Quiz.newD = "Jupiter";
                actualAnswer = "D";
                numAnswered++;
            }

            if (questionNumber == 19)
            {
                Quiz.newQuestion = "San Fransokyo is a word from?";
                Quiz.newA = "San Francisco and Tokyo";
                Quiz.newB = "San Bernadino and Kyoto";
                Quiz.newC = "San Francisco and Nokia";
                Quiz.newD = "Santa Ana and Francisco";
                actualAnswer = "A";
                numAnswered++;
            }

            if (questionNumber == 20)
            {
                Quiz.newQuestion = "What animal has the most legs?";
                Quiz.newA = "Centipede";
                Quiz.newB = "Millipede";
                Quiz.newC = "Spider";
                Quiz.newD = "Jellyfish";
                actualAnswer = "B";
                numAnswered++;
            }
            //all questions go above this line
            Quiz.pleaseUpdate = false;
        }

        if (numAnswered == 10)
        {
            GameOverScreen.Setup();
        }
    }
}
