using System;
using System.Collections.Generic;
using System.Text;

namespace FindNumber
{
    class GameOperations
    {
        string csNumber;             // Computer's number which is try to find the player 
        string[] resultList;         // List of all numbers which are matching player's number

        int resultCount;      // count of result list element

        public GameOperations()
        {
            csNumber = "";
            resultList = new string[4536];  // four-digit number which all digit are different, its count 4536 
                                            // The first digit shouldn’t be 0. Count 9*9*8*7.

            LoadFirstResults();             // Fill possible match number in the reulst list 

            SetCSNumber();                  // pick number which is try to find the player
        }

        /// <summary>
        /// Create number which is try to find the player
        /// </summary>
        private void SetCSNumber()
        {
            int tempNumber = -1;
            Random rnd = new Random();   //random number generator

            for (int i = 0; i < 4; i++)   // for loop
            {
                do   
                {
                    if (i > 0)
                        tempNumber = rnd.Next(0, 10);   // all number 0..9
                    else
                        tempNumber = rnd.Next(1, 10);   // The first digit shouldn’t be 0. 1..9 

                } while (csNumber.IndexOf(tempNumber.ToString()) >= 0); // check it for use before. 


                csNumber = csNumber + tempNumber.ToString();  //add digit to result
            }

        }

        /// <summary>
        /// Get function for computer's number
        /// </summary>
        /// <returns>Computer's number</returns>
        public string GetCSNumber()
        {
            return csNumber;
        }

        /// <summary>
        /// Get count of the result list element
        /// </summary>
        /// <returns>count of the result list element</returns>
        public int GetResultCount()
        {
            return resultCount;
        }

        /// <summary>
        /// Create all four-digit number which all digit are different, and add result list
        /// </summary>
        private void LoadFirstResults()
        {
            resultCount = 0;

            for (int i = 1; i < 10; i++)   // the first digit shouldn’t be 0 so loop start 1 
            {
                for (int j = 0; j < 10; j++)  // second digit
                {
                    if ((j == i))             // check first digit for block repetitive number
                        continue;

                    for (int k = 0; k < 10; k++) // third digit
                    {
                        if ((k == i) || (k == j)) // check first and second digits for block repetitive number 
                            continue;

                        for (int l = 0; l < 10; l++) // fourth digit
                        {
                            if ((l == i) || (l == j) || (l == k)) // check first, second and yhird digits for block repetitive number
                                continue;

                            resultList[resultCount] = "" + i.ToString() + j.ToString() + k.ToString() + l.ToString();
                            resultCount++;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Clearing all data and prepare game for play again
        /// </summary>
        public void ResetGame()
        {
            csNumber = "";

            LoadFirstResults();   // Fill possible match number in the reulst list

            SetCSNumber();        // pick number which is try to find the player

        }

        /// <summary>
        /// Compare two number and return clue. explain detail number compare rules in the
        /// 'Rules of the Game' screen
        /// </summary>
        /// <param name="firstNumber">1. number</param>
        /// <param name="secondNumber">2. number</param>
        /// <returns>Compare result</returns>
        public string CompareNumbers(string firstNumber, string secondNumber)
        {
            string result = "";
            int posNum = 0, negNum = 0;
            int tempPos, tempNeg;       

            for (int i = 0; i < 4; i++)
            {
                tempPos = 0;
                tempNeg = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (firstNumber[i] == secondNumber[j])
                    {
                        if (i == j)      // positive match (number and digit-place are right)
                            tempPos++;
                        else             // negative match (number is right but digit-place wrong)
                            tempNeg++;
                    }
                }

                // player guesses that has a repetitive number. And if it has positive and negative match
                // only positive match add clue. Explain rules of the game
                if (tempPos > 0)     
                    posNum++;
                else if (tempNeg > 0)  
                    negNum++;
            }

            if (posNum > 0)     //positive match add clue
                result = result + "+" + Convert.ToString(posNum);

            if (negNum > 0)   // negative match add clue
            {
                if (result != "")
                    result = result + " ";

                result = result + "-" + Convert.ToString(negNum);
            }

            if (result == "") // if it has not match the clue be '0'
                result = "0";


            return result;  // return clue
        }

        /// <summary>
        /// Compare guess number and computer's number.After compare operation return clue
        /// explain detail number compare rules in the
        /// </summary>
        /// <param name="secondNumber">guess number</param>
        /// <returns>compare operation result</returns>
        public string CompareNumbers(string secondNumber)
        {
            string result = "";
            string firstNumber = csNumber; 

            int posNum = 0, negNum = 0;
            int tempPos, tempNeg;        

            for (int i = 0; i < 4; i++)
            {
                tempPos = 0;
                tempNeg = 0;

                for (int j = 0; j < 4; j++)
                {
                    if (firstNumber[i] == secondNumber[j])
                    {
                        if (i == j)       // positive match (number and digit-place are right)
                            tempPos++;
                        else             // negative match (number is right but digit-place wrong)
                            tempNeg++;
                    }
                }

                // player guesses that has a repetitive number. And if it has positive and negative match
                // only positive match add clue. Explain rules of the game
                if (tempPos > 0)  
                    posNum++;
                else if (tempNeg > 0)
                    negNum++;
            }

            if (posNum > 0)    //positive match add clue
                result = result + "+" + Convert.ToString(posNum);

            if (negNum > 0)   //negative match add clue
            {
                if (result != "")
                    result = result + " ";

                result = result + "-" + Convert.ToString(negNum);
            }

            if (result == "") //  if it has not match the clue be '0'
                result = "0";


            return result;  // return clue
        }

        /// <summary>
        /// Create coputer's guess
        /// </summary>
        /// <returns>Guess number</returns>
        public string FindGuess()
        {
            string result = "";

            Random rnd = new Random();  //random number generator
            result = resultList[rnd.Next(0, resultCount)];  //pick a number in the result list 

            return result;
        }

        /// <summary>
        /// Scan all result list according to guess number and it's clue. 
        /// After this operation list refresh with last clue
        /// </summary>
        /// <param name="guessNum">Guess number</param>
        /// <param name="result">Guess number's clue</param>
        public void ProcessResult(string guessNum, string result)
        {

            string[] tmpResultList = new string[resultCount];  // temporary list
            int tempCount = 0;   // counter of temporary list 


            for (int i = 0; i < resultCount; i++) // all result list scann
            {
                if (CompareNumbers(guessNum, resultList[i]) == result) // find same clue to guess number
                {
                    tmpResultList[tempCount] = resultList[i];  // if the number same clue add temp result list
                    tempCount++;

                }
            }

            for (int i = 0; i < resultCount; i++) //the temporary list is transferred to the result list
                resultList[i] = tmpResultList[i];

            resultCount = tempCount; // tranfser list element number
        }

    }
}
