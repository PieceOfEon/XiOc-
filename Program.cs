using System;
using System.Reflection.Metadata.Ecma335;

XO xo = new();

char vvod;
do
{
    Console.WriteLine("1 - Game one");
    Console.WriteLine("2 - Game bot VS bot");
    Console.WriteLine("3 - Game bot Vs Player");
    Console.WriteLine("Exit - ESC");

    vvod = Console.ReadKey().KeyChar;
    switch (vvod)
    {
        case '1':
            {
                xo.Zap();
                xo.GameOne();
                Console.ReadLine();
                break;
            }
        case '2':
            {
                xo.Zap();
                xo.GameBot();
                
                break;
            }
        case '3':
            {
                xo.Zap();
                xo.PlayerVSbot();
                
                break;
            }
    }
} while (vvod != 27);
class XO
{
    public Random random=new Random();
    public bool Prov(string A)
    {
        bool f = false;
        for (int i = 0; i < A.Length; i++)
            if (char.IsDigit(A[i]) == false)
            {
                return false;
            }
            else
            {
                f = true;
            }
        if (f == true)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }
    public char[,] mas;
    int str = 3;
    int stb = 3;
	public XO()
    {
        mas = new char[str,stb];
    }
    public void Zap()
    {
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                mas[i, j] = '*';
            }
        }
    }
    public void GameOne()
    {
        bool per = true;
        Print();
        while (per == true)
        {
            string pr = "h";
            int i, j;

        re2: while (Prov(pr) == false || Convert.ToInt32(pr) > str || Convert.ToInt32(pr) < 1)
            {
                Console.WriteLine("Enter number X i:");
                pr=Console.ReadLine();

            }
            i = Convert.ToInt32(pr);
            pr = "s";
            while (Prov(pr) == false || Convert.ToInt32(pr) > stb || Convert.ToInt32(pr) < 1)
            {
                Console.WriteLine("Enter number X j: ");
                pr = Console.ReadLine();
            }
            j = Convert.ToInt32(pr);
            pr = "s";
            if (mas[i - 1,j - 1] == '0' || mas[i - 1,j - 1] == 'X')
            {
                goto re2;
            }
            mas[i - 1,j - 1] = 'X';
            Console.Clear();
            Print();
            if (Proverka() == 1)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (Proverka0str() == 1)
            {
                Console.WriteLine("\n\tWon 0!" );
                per = false;
                break;
            }

            if (ProverkaXstb() == true)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (Proverka0stb() == true)
            {
                Console.WriteLine("\n\tWon 0!");
                per = false;
                break;
            }
            if (ProverkaXDiag() == true)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (Proverka0Diag() == true)
            {
                Console.WriteLine("\n\tWon 0!");
                per = false;
                break;
            }
            if (Proverka0Diag2() == true)
            {
                Console.WriteLine("\n\tWon 0!" );
                per = false;
                break;
            }
            if (ProverkaXDiag2() == true)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (ProverkaFull() == 0)
            {
                Console.WriteLine("Tie");
                per = false;
                break;
            }
        re1: while (Prov(pr) == false || Convert.ToInt32(pr) > str || Convert.ToInt32(pr) < 1)
            {
                Console.WriteLine("Enter number 0 i: " );
                pr = Console.ReadLine();

            }
            i = Convert.ToInt32(pr);
            pr = "s";
            while (Prov(pr) == false || Convert.ToInt32(pr) > stb || Convert.ToInt32(pr) < 1)
            {
                Console.WriteLine("Enter number 0 j: " );
                pr = Console.ReadLine();
            }
            j = Convert.ToInt32(pr);
            pr = "s";
            if (mas[i - 1,j - 1] == '0' || mas[i - 1,j - 1] == 'X')
            {
                goto re1;
            }
            mas[i - 1,j - 1] = '0';
            Console.Clear();
            Print();
            if (ProverkaXstb() == true)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (Proverka0stb() == true)
            {
                Console.WriteLine("\n\tWon 0!");
                per = false;
                break;
            }
            if (Proverka() == 1)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (Proverka0str() == 1)
            {
                Console.WriteLine("\n\tWon 0!");
                per = false;
                break;
            }
            if (ProverkaXDiag() == true)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (Proverka0Diag() == true)
            {
                Console.WriteLine("\n\tWon 0!"); 
                per = false;
                break;
            }
            if (Proverka0Diag2() == true)
            {
                Console.WriteLine("\n\tWon 0!");
                per = false;
                break;
            }
            if (ProverkaXDiag2() == true)
            {
                Console.WriteLine("\n\tWon X!");
                per = false;
                break;
            }
            if (ProverkaFull() == 0)
            {
                Console.WriteLine("Tie");
                per = false;
                break;
            }
        }
    }

    public void GameBot()
    {
        bool per = true;
        while (per == true)
        {
            //this_thread::sleep_for(chrono::milliseconds(1000));
            int i, j;
        re2: i = random.Next(1, 4);
            j = random.Next(1, 4);
            if (mas[i - 1,j - 1] == '0' || mas[i - 1,j - 1] == 'X')
            {
                goto re2;
            }
            mas[i - 1,j - 1] = 'X';
            Console.Clear();
            Print();

            if (Proverka() == 1)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0str() == 1)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }

            if (ProverkaXstb() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0stb() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0Diag() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (Proverka0Diag2() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag2() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (ProverkaFull() == 0)
            {
                Console.WriteLine("\tTie!\n");
                per = false;
                break;
            }
            //this_thread::sleep_for(chrono::milliseconds(1000));
        re1: i = random.Next(1, 4);
            j = random.Next(1, 4);
            if (mas[i - 1,j - 1] == '0' || mas[i - 1,j - 1] == 'X')
            {
                goto re1;
            }
            mas[i - 1,j - 1] = '0';
            Console.Clear();
            Print();

            if (ProverkaXstb() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0stb() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (Proverka() == 1)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0str() == 1)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0Diag() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (Proverka0Diag2() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag2() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (ProverkaFull() == 0)
            {
                Console.WriteLine("\tTie!\n");
                per = false;
                break;
            }
        }
    }
    public void PlayerVSbot()
    {
        bool per = true;
        while (per == true)
        {
            //this_thread::sleep_for(chrono::milliseconds(1000));
            int i, j;
        re2: i = random.Next(1, 4);
            j = random.Next(1, 4);
            if (mas[i - 1,j - 1] == '0' || mas[i - 1,j - 1] == 'X')
            {
                goto re2;
            }
            mas[i - 1,j - 1] = 'X';
            Console.Clear();
            Print();

            if (Proverka() == 1)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;

                break;
            }
            if (Proverka0str() == 1)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }

            if (ProverkaXstb() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0stb() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0Diag() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (Proverka0Diag2() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag2() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (ProverkaFull() == 0)
            {
                Console.WriteLine("\tTie!\n");
                per = false;
                break;
            }
            //this_thread::sleep_for(chrono::milliseconds(1000));
            string pr = "h";

        re1: while (Prov(pr) == false || Convert.ToInt32(pr) > str || Convert.ToInt32(pr) < 1)
            {
                Console.WriteLine("\tEnter number 0 i:");
                pr=Console.ReadLine();

            }
            i = Convert.ToInt32(pr);
            pr = "s";
            while (Prov(pr) == false || Convert.ToInt32(pr) > stb || Convert.ToInt32(pr) < 1)
            {
                Console.WriteLine("\tEnter number 0 j:");
                pr=Console.ReadLine();
            }
            j = Convert.ToInt32(pr);
            pr = "s";
            if (mas[i - 1,j - 1] == '0' || mas[i - 1,j - 1] == 'X')
            {
                goto re1;
            }
            mas[i - 1,j - 1] = '0';
            Console.Clear();
            Print();

            if (ProverkaXstb() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0stb() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (Proverka() == 1)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0str() == 1)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (Proverka0Diag() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (Proverka0Diag2() == true)
            {
                Console.WriteLine("\tWon 0!\n");
                per = false;
                break;
            }
            if (ProverkaXDiag2() == true)
            {
                Console.WriteLine("\tWon X!\n");
                per = false;
                break;
            }
            if (ProverkaFull() == 0)
            {
                Console.WriteLine("\tTie!\n");
                per = false;
                break;
            }
        }
    }
    public int ProverkaFull()
    {
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                if (mas[i,j] != 'X' && mas[i,j] != '0')
                {
                    return 1;
                }
            }
        }
        return 0;
    }

    public int Proverka()
    {
        bool b = false;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                if (mas[i,j] != 'X')
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
                if (j == stb - 1)
                {
                    if ((mas[i,j] == 'X' && b == false))
                    {
                        return 1;
                    }
                }
            }
        }
        return 0;
    }

    public int Proverka0str()
    {
        bool b = false;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                if (mas[i,j] != '0')
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
                if (j == stb - 1)
                {
                    if ((mas[i,j] == '0' && b == false))
                    {
                        return 1;
                    }
                }
            }
        }
        return 0;
    }

    public bool ProverkaXstb()
    {
        bool b = false;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                if ((mas[j,i] != 'X'))
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
                if (j == stb - 1)
                {
                    if ((mas[str - 1,i] == 'X' && b == false))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public bool Proverka0stb()
    {
        bool b = false;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                if ((mas[j,i] != '0'))
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
                if (j == stb - 1)
                {
                    if ((mas[str - 1,i] == '0' && b == false))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public bool ProverkaXDiag()
    {
        bool b = false;
        for (int i = 0; i < str; i++)
        {
            if (mas[i,i] != 'X')
            {
                b = true;
                break;
            }
            else
            {
                b = false;
            }
            if (i == str - 1)
            {
                if ((mas[i,i] == 'X' && b == false))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool Proverka0Diag()
    {
        bool b = false;
        for (int i = 0; i < str; i++)
        {
            if (mas[i,i] != '0')
            {
                b = true;
                break;
            }
            else
            {
                b = false;
            }
            if (i == str - 1)
            {
                if ((mas[i,i] == '0' && b == false))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool Proverka0Diag2()
    {
        bool b = true;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                if (i + j == str - 1)
                {
                    if (mas[i,j] != '0')
                    {
                        i = str - 1;
                        b = true;
                        break;
                    }
                    else
                    {
                        b = false;
                    }
                    if (b == false && i == str - 1)
                    {
                        return true;

                    }
                }
            }
        }
        return false;
    }
    public bool ProverkaXDiag2()
    {
        bool b = true;
        for (int i = 0; i < str; i++)
        {
            for (int j = 0; j < stb; j++)
            {
                if (i + j == str - 1)
                {
                    if (mas[i,j] != 'X')
                    {
                        i = str - 1;
                        b = true;
                        break;
                    }
                    else
                    {
                        b = false;
                    }
                    if (b == false && i == str - 1)
                    {
                        return true;

                    }
                }
            }
        }
        return false;
    }
    public void Print()
    {
        Console.WriteLine("\t\t" + "j\t" + "j\t" + "j\t");
        Console.WriteLine("\t\t" + 1 + "\t" + 2 + "\t" + 3 + "\n");
        for (int i = 0; i < str; i++)
        {
            Console.Write("i = " + i + 1 + "->>\t"); 
            for (int j = 0; j < stb; j++)
            {
                Console.Write(mas[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
};