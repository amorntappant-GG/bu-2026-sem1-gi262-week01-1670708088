using UnityEngine;

public class Assignment : MonoBehaviour
{
    void Start()
    {
        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        // As10_CalculateWeaponDamage();
         As11_DeterminePlayerRank();
    }

    public int as01Number;

    public void As01_CheckNumberSign()
    {
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;

    public void As02_GetDayName()
    {
        switch (as02Day)
        {
            case 1:
                Debug.Log("Monday");
                break;

            case 2:
                Debug.Log("Tuesday");
                break;

            case 3:
                Debug.Log("Wednesday");
                break;

            case 4:
                Debug.Log("Thursday");
                break;

            case 5:
                Debug.Log("Friday");
                break;

            case 6:
                Debug.Log("Saturday");
                break;

            case 7:
                Debug.Log("Sunday");
                break;

            default:
                Debug.Log("Invalid day");
                break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;

    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;

    public void As04_GetGrade()
    {
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    public int as05Year;

    public void As05_IsLeapYear()
    {
        if (as05Year % 400 == 0 ||
            (as05Year % 4 == 0 && as05Year % 100 != 0))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;

    public void As06_Calculate()
    {
        double result = 0;

        switch (as06Op)
        {
            case '+':
                result = as06Num1 + as06Num2;
                break;

            case '-':
                result = as06Num1 - as06Num2;
                break;

            case '*':
                result = as06Num1 * as06Num2;
                break;

            case '/':
                if (as06Num2 == 0)
                {
                    Debug.Log("Cannot divide by zero");
                    return;
                }

                result = as06Num1 / as06Num2;
                break;

            default:
                Debug.Log("Invalid operator");
                return;
        }

        Debug.Log("Result: " + result);
    }

    public int as07Month;

    public void As07_GetSeason()
    {
        // แบ่งฤดูตามเดือน
        if (as07Month >= 3 && as07Month <= 5)
        {
            Debug.Log("Summer");
        }
        else if (as07Month >= 6 && as07Month <= 10)
        {
            Debug.Log("Rainy");
        }
        else if (as07Month == 11 || as07Month == 12 ||
                 as07Month == 1 || as07Month == 2)
        {
            Debug.Log("Winter");
        }
        else
        {
            Debug.Log("Invalid month");
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;

    public void As08_PurchasingSystemExample()
    {
        int total = as08Quantity * as08Price;

        if (as08Payment >= total)
        {
            int change = as08Payment - total;

            Debug.Log("Total: " + total);
            Debug.Log("Change: " + change);
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;

    public void As09_RockPaperScissorsExample()
    {
        // 1 = Rock
        // 2 = Paper
        // 3 = Scissors

        if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("Draw");
        }
        else if (
            (as09UserChoice == 1 && as09ComputerChoice == 3) ||
            (as09UserChoice == 2 && as09ComputerChoice == 1) ||
            (as09UserChoice == 3 && as09ComputerChoice == 2)
        )
        {
            Debug.Log("Player Wins");
        }
        else
        {
            Debug.Log("Computer Wins");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;

    public void As10_CalculateWeaponDamage()
    {
        int damage = as10BaseDamage;

        switch (as10WeaponType)
        {
            case "Sword":
                damage += 20;
                break;

            case "Bow":
                damage += 10;
                break;

            case "Gun":
                damage += 50;
                break;

            default:
                Debug.Log("Unknown weapon");
                return;
        }

        Debug.Log("Damage: " + damage);
    }

    public int as11Score;
    public int as11CompletionTime;

    public void As11_DeterminePlayerRank()
    {
        if (as11Score >= 80 && as11CompletionTime <= 60)
        {
            Debug.Log("S Rank");
        }
        else if (as11Score >= 70 && as11CompletionTime <= 90)
        {
            Debug.Log("A Rank");
        }
        else if (as11Score >= 60)
        {
            Debug.Log("B Rank");
        }
        else
        {
            Debug.Log("C Rank");
        }
    }
}