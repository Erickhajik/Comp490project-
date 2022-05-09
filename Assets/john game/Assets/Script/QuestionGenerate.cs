using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public int numQuestions = 0;

    // Update is called once per frame
    void Update()
    {
        
        if (displayingQuestion == false)
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
                numQuestions++;
            }
            if (questionNumber == 2)
            {
                Quiz.newQuestion = "Who is the current US President?";
                Quiz.newA = "Joe Biden";
                Quiz.newB = "Donald Trump";
                Quiz.newC = "Barack Obama";
                Quiz.newD = "Al Gore";
                actualAnswer = "A";
                numQuestions++;
            }
            if (questionNumber == 3)
            {
                Quiz.newQuestion = "What is sodium?";
                Quiz.newA = "Sugar";
                Quiz.newB = "Pepper";
                Quiz.newC = "Salt";
                Quiz.newD = "Mustard";
                actualAnswer = "C";
                numQuestions++;
            }
            if (questionNumber == 4)
            {
                Quiz.newQuestion = "Where is the Great Barrier Reef?";
                Quiz.newA = "Japan";
                Quiz.newB = "Indonesia";
                Quiz.newC = "Brazil";
                Quiz.newD = "Australia";
                actualAnswer = "D";
                numQuestions++;
            }
            if (questionNumber == 5)
            {
                Quiz.newQuestion = "Best programming language for beginners?";
                Quiz.newA = "C++";
                Quiz.newB = "Java";
                Quiz.newC = "C";
                Quiz.newD = "Python";
                actualAnswer = "B";
                numQuestions++;
            }
            if (questionNumber == 6)
            {
                Quiz.newQuestion = "What Disney Villain is based on an octopus?";
                Quiz.newA = "Fairy Godmother";
                Quiz.newB = "Jafar";
                Quiz.newC = "Maleficent";
                Quiz.newD = "Ursula";
                actualAnswer = "D";
                numQuestions++;
            }
            if (questionNumber == 7)
            {
                Quiz.newQuestion = "How many stars are in the American flag?";
                Quiz.newA = "48";
                Quiz.newB = "51";
                Quiz.newC = "50";
                Quiz.newD = "13";
                actualAnswer = "C";
                numQuestions++;
            }
            if (questionNumber == 8)
            {
                Quiz.newQuestion = "What does 'Sora' mean in English?";
                Quiz.newA = "Sky";
                Quiz.newB = "Sea";
                Quiz.newC = "Fly";
                Quiz.newD = "Wind";
                actualAnswer = "A";
                numQuestions++;
            }
            if (questionNumber == 9)
            {
                Quiz.newQuestion = "What animal has no arms or legs?";
                Quiz.newA = "Hippopotamus";
                Quiz.newB = "Snakes";
                Quiz.newC = "Tigers";
                Quiz.newD = "Dolphins";
                actualAnswer = "B";
                numQuestions++;
            }
            if (questionNumber == 10)
            {
                Quiz.newQuestion = "How many Harry Potter films were made?";
                Quiz.newA = "9";
                Quiz.newB = "7";
                Quiz.newC = "8";
                Quiz.newD = "10";
                actualAnswer = "C";
                numQuestions++;
            }
            if (questionNumber == 11)
            {
                Quiz.newQuestion = "What is the actual color of our sun?";
                Quiz.newA = "Yellow";
                Quiz.newB = "Blue";
                Quiz.newC = "Red";
                Quiz.newD = "White";
                actualAnswer = "D";
                numQuestions++;
            }

            if (questionNumber == 12)
            {
                Quiz.newQuestion = "What vegetable improvez eyesight";
                Quiz.newA = "Carrot";
                Quiz.newB = "Celery";
                Quiz.newC = "Eggplant";
                Quiz.newD = "Broccoli";
                actualAnswer = "A";
                numQuestions++;
            }

            if (questionNumber == 13)
            {
                Quiz.newQuestion = "How many continents are on Earth?";
                Quiz.newA = "6";
                Quiz.newB = "7";
                Quiz.newC = "9";
                Quiz.newD = "4";
                actualAnswer = "B";
                numQuestions++;
            }

            if (questionNumber == 14)
            {
                Quiz.newQuestion = "Which of this is not a Looney Tunes character?";
                Quiz.newA = "Porky Pig";
                Quiz.newB = "Tazmanian Devil";
                Quiz.newC = "Tweety";
                Quiz.newD = "Chip";
                actualAnswer = "D";
                numQuestions++;
            }

            if (questionNumber == 15)
            {
                Quiz.newQuestion = "Who is Superman's real identity?";
                Quiz.newA = "Bruce Wayne";
                Quiz.newB = "Clark Kent";
                Quiz.newC = "Tony Stark";
                Quiz.newD = "Wally West";
                actualAnswer = "B";
                numQuestions++;
            }

            if (questionNumber == 16)
            {
                Quiz.newQuestion = "Which of these people died in 2022?";
                Quiz.newA = "Betty White";
                Quiz.newB = "Kobe Bryant";
                Quiz.newC = "Bruce Lee";
                Quiz.newD = "Gilbert Gotfried";
                actualAnswer = "D";
                numQuestions++;
            }

            if (questionNumber == 17)
            {
                Quiz.newQuestion = "What is 999x999 ";
                Quiz.newA = "818,181";
                Quiz.newB = "998,001";
                Quiz.newC = "810,001";
                Quiz.newD = "999,999";
                actualAnswer = "B";
                numQuestions++;
            }

            if (questionNumber == 18)
            {
                Quiz.newQuestion = "What planet has the most moons?";
                Quiz.newA = "Neptune";
                Quiz.newB = "Saturn";
                Quiz.newC = "Earth";
                Quiz.newD = "Jupiter";
                actualAnswer = "D";
                numQuestions++;
            }

            if (questionNumber == 19)
            {
                Quiz.newQuestion = "San Fransokyo is a word from?";
                Quiz.newA = "San Francisco and Tokyo";
                Quiz.newB = "San Bernadino and Kyoto";
                Quiz.newC = "San Francisco and Nokia";
                Quiz.newD = "Santa Ana and Francisco";
                actualAnswer = "A";
                numQuestions++;
            }

            if (questionNumber == 20)
            {
                Quiz.newQuestion = "What animal has the most legs?";
                Quiz.newA = "Centipede";
                Quiz.newB = "Millipede";
                Quiz.newC = "Spider";
                Quiz.newD = "Jellyfish";
                actualAnswer = "B";
                numQuestions++;
            }
            //all questions go above this line
            Quiz.pleaseUpdate = false;
        }
        
    }
}
