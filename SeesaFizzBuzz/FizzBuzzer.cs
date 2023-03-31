using Microsoft.AspNetCore.SignalR.Protocol;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace SeesaFizzBuzz
{
    public class FizzBuzzer
    {
        string returnString = "";
        public string Buzz(int FizzBuzzNumber)
        {
            //No FizzBuzzing Zero
            if (FizzBuzzNumber != 0)
            {
                //No FizzBuzzing Negatives
                if (FizzBuzzNumber >= 0)
                {
                    //Rows Remain Neat, Stick To Multiples Of 5
                    if (FizzBuzzNumber % 5 != 0)
                    {
                        FizzBuzzNumber += 5 - (FizzBuzzNumber % 5);
                    }
                    //Create Container For The FizzBuzz Table And Ensure First Row Is Present And Center
                    stringAdd("<p class='text-center'>Here is the FizzBuzz sequence from 1 to " + FizzBuzzNumber + ":</p>");
                    stringAdd("<div class='container text-center mx-auto'>");
                    stringAdd("<div class='row justify-content-center'>");
                    //Loop And Create Rows, Columns And Cells For The FizzBuzz Output With Calculated Cell Content
                    for (int i = 1; i <= FizzBuzzNumber; i++)
                    {
                        switch (i)
                        {
                            //Lowest Common Multiple For 3 And 5 is 15, Injects FizzBuzz
                            //This Adds A Row When Not End Of FizzBuzz
                            case int n when ((n % 15 == 0) && (i != FizzBuzzNumber)):
                                stringAdd("<div class='col-2 rounded numberWrap bg-primary text-center'>FizzBuzz</div></div><div class='row justify-content-center'>");
                                break;
                            //This Closes Final Row If End Of FizzBuzz
                            case int n when ((n % 15 == 0) && (i == FizzBuzzNumber)):
                                stringAdd("<div class='col-2 rounded numberWrap bg-primary text-center'>FizzBuzz</div></div>");
                                break;
                                // Multiple of 3 Cannot End Row
                            case int n when (n % 3 == 0):
                                stringAdd("<div class='col-2 rounded numberWrap bg-success text-center'>Fizz</div>");
                                break;
                            //This Adds A Row When Not End Of FizzBuzz
                            case int n when ((n % 5 == 0) && (i != FizzBuzzNumber)):
                                stringAdd("<div class='col-2 rounded numberWrap bg-warning text-center'>Buzz</div></div><div class='row justify-content-center'>");
                                break;
                            //This Closes Final Row If End Of FizzBuzz
                            case int n when ((n % 5 == 0) && (i == FizzBuzzNumber)):
                                stringAdd("<div class='col-2 rounded numberWrap bg-warning text-center'>Buzz</div></div>");
                                break;
                            default:
                                //Not FizzBuzz Number, Print Number Only, Cannot End FizzBuzz Rows
                                stringAdd("<div class='col-2 rounded numberWrap bg-light text-center'>" + Convert.ToString(i) + "</div>");
                                break;
                        }
                    }
                    //Close Container Div And Parent Div
                    stringAdd("</div></div>");
                }
                else
                {
                    //Message For Non-Positive FizzBuzz Number
                    stringAdd("<p>Negative numbers, while possible valid multiples of 3 and 5, won't be Fizzbuzzed by this App. Keep it positive!</p>");
                }
            }
            else
            {
                //Message For Zero Or Nothing As Input
                stringAdd("<p>Zero, while a valid multiple of 3 and 5, won't be Fizzbuzzed by this App. Keep it positive!</p>");
            }

            return returnString;
        }
            private void stringAdd(string toAdd)
        {
            returnString += toAdd;
        }
    }
}


/* 
        stringAdd("<div class=\'container text-center\'><div class='row'>");
        for (int i = 1; i <= FizzBuzzNumber; i++)
        {

            if ((i % 3 == 0) && (i % 5 == 0) && (i != FizzBuzzNumber))
            {
                stringAdd("<div class='col numberWrap'>FizzBuzz</div></div><div class='row'>");
            }
            else if ((i % 3 == 0) && (i % 5 == 0) && (i == FizzBuzzNumber))
            {
                stringAdd("<div class='col numberWrap'>FizzBuzz</div></div>");
            }
            else if (i % 3 == 0)
            {
                stringAdd("<div class='col numberWrap'>Fizz</div>");
            }
            else if ((i % 5 == 0) && (i != FizzBuzzNumber))
            {
                stringAdd("<div class='col numberWrap'>Buzz</div></div><div class='row'>");
            }
            else if ((i % 5 == 0) && (i == FizzBuzzNumber))
            {
                stringAdd("<div class='col numberWrap'>Buzz</div></div>");
            }
            else
            {
                stringAdd("<div class='col numberWrap'>" + Convert.ToString(i) + "</div>");
            }
        }
        //close container
        stringAdd("</div>");*/