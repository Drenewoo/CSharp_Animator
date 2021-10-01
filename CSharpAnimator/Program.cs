using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CSharpAnimator
{
    class Program
    {
        static string Version = "1.0.2.1~official"; // <== moderze zmień official na modded jeśli zmodyfikowałeś kod. Dzięki! | modder change offcial to modded if you modified code. Thanks!
        
        static int k = 0;
        
        static string sciezka = " ";
        static bool save = false;
        static bool savenow = true;
        static string[,,] frame = new string[70, 30, 1200];
        static bool Clear = true;
        static int[,,] color = new int[70,30,1200];
        static int clinfo = 0;
       
        static void Main(string[] args)
        {
            Console.Title = "CSharp Animator "+Version;
            Console.SetWindowSize(130, 45);
            Fresh();
            testanim();        
        }
        static void Refresh()
        {
            while (true)
            {
                for (int c = 0; c < 1199; c++)
                {

                    GoRefresh(c);
                }
            }
        }
        static public void FileWrite()
        {
            for (int v = 0; v < 1199; v++)
            {

                for (int a = 0; a < 30; a++)
                {
                    for (int b = 0; b < 70; b++)
                    {

                        if (frame[b, a, v] == "#")
                        {
                            if (color[b, a, v] == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                if (save == true && savenow == true)
                                {
                                    k = 1;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                if (save == true && savenow == true && savenow == true)
                                {
                                    k = 2;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                if (save == true && savenow == true)
                                {
                                    k = 3;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                if (save == true && savenow == true)
                                {
                                    k = 4;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                if (save == true && savenow == true)
                                {
                                    k = 5;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 6)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                if (save == true && savenow == true)
                                {
                                    k = 6;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                                if (save == true && savenow == true)
                                {
                                    k = 7;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 8)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                if (save == true && savenow == true)
                                {
                                    k = 8;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 9)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                if (save == true && savenow == true)
                                {
                                    k = 9;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 10)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                if (save == true && savenow == true)
                                {
                                    k = 10;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 11)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                if (save == true && savenow == true)
                                {
                                    k = 11;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 12)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (save == true && savenow == true)
                                {
                                    k = 12;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 13)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                if (save == true && savenow == true)
                                {
                                    k = 13;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 14)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                if (save == true && savenow == true)
                                {
                                    k = 14;
                                    //savenow = false;
                                }
                            }
                            else if (color[b, a, v] == 15)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                if (save == true && savenow == true)
                                {
                                    k = 15;
                                    //savenow = false;
                                }
                            }
                            TextWriter tw = new StreamWriter(@sciezka, true);
                            tw.WriteLine(v);
                            tw.WriteLine(b);
                            tw.WriteLine(a);
                            tw.WriteLine(k);
                            tw.Close();

                        }
                    }
                }
                
            }
            TextWriter twr = new StreamWriter(@sciezka, true);
            
            twr.WriteLine("w");
            twr.Close();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Zapisano! Chcesz obejrzeć swoją animację? (tak/nie)");
            string s = Console.ReadLine();
            if (s.ToLower() == "tak")
            {
                Refresh();
            }
            else if (s.ToLower() == "nie")
            {
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(1);
            }
        }
        static void GoRefresh(int v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Stworzone przez drenewoo (Wojciech Wójtowicz)" + "\n" + "CSharp Animator " + Version + "  Klatka:" + v);
            Console.Write("\n");
            for (int a = 0; a < 30; a++)
                {
                    for (int b = 0; b < 70; b++)
                    {
                    
                    Console.CursorVisible = false;
                        if (color[b,a,v] == 1)
                        {
                          Console.ForegroundColor = ConsoleColor.DarkBlue;
                          if (save == true && savenow == true)
                          {
                            //k = 1;
                           //savenow = false;
                          }
                        }
                        else if (color[b, a, v] == 2 )
                        {
                          Console.ForegroundColor = ConsoleColor.DarkGreen;
                        if (save == true && savenow == true && savenow == true)
                        {
                            //k = 2;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 3 )
                        {
                          Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if (save == true && savenow == true)
                        {
                            //k = 3;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 4 )
                        {
                          Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (save == true && savenow == true)
                        {
                            //k = 4;
                           //savenow = false;
                        }
                        }
                        else if(color[b,a,v] == 5 )
                        {
                          Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        if (save == true && savenow == true)
                        {
                            //k = 5;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 6 )
                        {
                          Console.ForegroundColor = ConsoleColor.DarkYellow;
                        if (save == true && savenow == true)
                        {
                            //k = 6;
                           //savenow = false;
                        }
                        }
                        else if(color[b,a,v] == 7 )
                        {
                          Console.ForegroundColor = ConsoleColor.Gray;
                        if (save == true && savenow == true)
                        {
                            //k = 7;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 8 )
                        {
                          Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (save == true && savenow == true)
                        {
                            //k = 8;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 9 )
                        {
                          Console.ForegroundColor = ConsoleColor.Blue;
                        if (save == true && savenow == true)
                        {
                            //k = 9;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] ==10 )
                        {
                          Console.ForegroundColor = ConsoleColor.Green;
                        if (save == true && savenow == true)
                        {
                            //k = 10;
                           //savenow = false;
                        }
                        }
                        else if(color[b,a,v] == 11)
                        {
                          Console.ForegroundColor = ConsoleColor.Cyan;
                        if (save == true && savenow == true)
                        {
                            //k = 11;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 12)
                        {
                          Console.ForegroundColor = ConsoleColor.Red;
                        if (save == true && savenow == true)
                        {
                            //k = 12;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 13)
                        {
                          Console.ForegroundColor = ConsoleColor.Magenta;
                        if (save == true && savenow == true)
                        {
                            //k = 13;
                           //savenow = false;
                        }
                        }
                        else if(color[b,a,v] == 14)
                        {
                          Console.ForegroundColor = ConsoleColor.Yellow;
                        if (save == true && savenow == true)
                        {
                            //k = 14;
                           //savenow = false;
                        }
                        }
                        else if (color[b, a, v] == 15)
                        {
                          Console.ForegroundColor = ConsoleColor.White;
                        if (save == true && savenow == true)
                        {
                            //k = 15;
                           //savenow = false;
                        }
                        }
                        else
                        {
                        Console.ForegroundColor = ConsoleColor.Black;
                        }
                        
                    Console.Write(frame[b, a, v]);
                    //FileWrite(b, a, v, k);
                    savenow = true;
                    }
                Console.Write("\n");

            }
            Thread.Sleep(100);
            Console.Clear();



        }
        static void Fresh()
        {
            for (int c = 0; c < 1199; c++)
            {
                for (int a = 0; a < 30; a++)
                {
                    for (int b = 0; b < 70; b++)
                    {
                        frame[b, a, c] = ".";
                    }
                }
            }
        }
        static void testanim()
        {
            Console.WriteLine("Aby uzyskać informacje, napisz info lub jeśli wiesz, co zrobić, zrób to, co chcesz");
            Console.Write("x może obsługiwać 0-69, y może obsługiwać 0-29, a ramki od 1 do 1199, dostępne kolory:" + " ");
            for (; clinfo != 16; clinfo++)
            {
                
                if (clinfo == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(clinfo+" ");

                }
                else if (clinfo == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 8)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 11)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 13)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 14)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(clinfo+" ");
                }
                else if (clinfo == 15)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(clinfo+"\n");
                    
                }
            }
            clinfo = 0;
            Console.Write("klatka:");
            string w = Console.ReadLine();



            if (w == "w")
            {
                Refresh();
            }
            else if (w == "info")
            {
                Console.WriteLine("\n"+ "Witamy w CSharp Animator. Tutaj masz podstawowe informacje. " + "\n" + "\n" + "x może obsłużyć 0-69, y może obsłużyć 0-29 i klatki od 1 do 1199." + "\n" + "\n" + "dostępne kolory:" + "\n");
                
                for (; clinfo != 16; clinfo++)
                {

                    if (clinfo == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(clinfo);

                    }
                    else if (clinfo == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 13)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 14)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(clinfo);
                    }
                    else if (clinfo == 15)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(clinfo);
                        
                    }
                }
                clinfo = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n"+ "Przykładowy piksel powinien wyglądać tak:" + "\n" + "\n" + "1" + "\n" + "0" + "\n" + "0" + "\n" + "15" + "\n" + "\n" + "spowoduje to utworzenie jednego piksela w lewym górnym rogu, który jest biały w klatce 1.");
                Console.WriteLine("\n" + "Kody ramek: info - informacje | w - zakończ tworzenie, odtwórz animację | ws nazwa_pliku_txt - zakończ tworzenie, zapisz do pliku txt");
                Console.WriteLine("\n" + "Twórca: Wojciech Wójtowicz / drenewoo | Wersja programu: " + Version + "\n");
                Console.WriteLine("" + "\n");  //<== tutaj wpisz swój nick jeśli zmodyfikowałeś kod. Dziękuje! | write here your nick if you modified code. Thank you! 
                Console.WriteLine("Kliknij enter, jeśli chcesz wrócić");
                Console.ReadLine();
                testanim();
            }
            else if(w == "ws")
            {
                save = true;
                Console.WriteLine("Ścieżka pliku txt (jeśli go nie ma to się utworzy, dodaj .txt na końcu ścieżki):");
                sciezka = Console.ReadLine();

                FileWrite();
            }
            else
            {
                try
                {
                    Console.Write("poz. x:");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.Write("poz. y:");
                    int y = Int32.Parse(Console.ReadLine());
                    Console.Write("kolor:");
                    int c = Int32.Parse(Console.ReadLine());
                    Console.Write("klatka:");
                    int q = Int32.Parse(w);


                    data(x, y, q, c);
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Miły magik uratował cię, ponieważ coś źle wpisałeś lub komputer się pomylił" + "\n" + "                           #                    " + "\n" + "                    ##############" + "\n" + "              ##########################" + "\n" + "        ######################################" + "\n" + "          #                            #" + "\n" + "          #     0     /       0        #" + "\n" + "          #          /_               #" + "\n" + "             #         |__/        #" + "\n" + "                #                 #" + "\n" + "                   ########");
                    Console.WriteLine("Nie musisz przepisywać całej rzeczy, po prostu ostatnią rzecz, którą źle wpisałeś, a teraz zrób to");
                    testanim();
                }
            }           
        }
        
        static void data(int x, int y, int w, int c)
        {
            frame[x, y, w] = "#" ;
            color[x,y,w] = c;
            testanim();
        }
    }
}
