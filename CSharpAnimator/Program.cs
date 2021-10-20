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
        static string Version = "1.1.0~official"; // <== moderze zmień official na modded jeśli zmodyfikowałeś kod. Dzięki! | modder change offcial to modded if you modified code. Thanks!
        
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
            Console.SetWindowSize(140, 40);
            Fresh();
            testanim();        
        }
        static void Refresh()
        {
            
            int a = 0;
            while (true)
            {

                for (int c = 0; c < 1199; c++)
                {
                    a = c;
                    GoRefresh(c);
                }
            }
            


          



        }
        static public void FileWrite(bool menus)
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
            if(menus == true)
            {
                Menu(1);
            }
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
            Console.WriteLine("Stworzone przez drenewoo (Wojciech Wójtowicz)" + "\n" + "CSharp Animator " + Version + "  Klatka:" + v +"\n" + "\n");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MENU                                                                                                           ");
            Console.BackgroundColor = ConsoleColor.Black;
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
                    if (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
                    {
                        
                        Console.Write(frame[b, a, v]);
                    }
                    else
                    {
                        Menu(v);
                    }
                    //FileWrite(b, a, v, k);
                    savenow = true;
                    }
                    Console.Write("\n");

                }
                 Thread.Sleep(100);
                 Console.Clear();
           



        }
        static void Menu(int k)
        {
            
            int x = 5;
             
            
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Stworzone przez drenewoo (Wojciech Wójtowicz)" + "\n" + "CSharp Animator " + Version + "  Klatka:" + k +"\n" + "\n");
                Console.BackgroundColor = ConsoleColor.Blue;
            
            
                if (x == 5)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                
                Console.WriteLine("MENU                                                                                                           ");
                if (x == 6)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                
                Console.WriteLine("Restart animacji     ");
                if (x == 7)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                
                Console.WriteLine("Zapisz animację      ");
                if (x == 8)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
               
                Console.WriteLine("Wyjdź do kreatora    ");
                if (x == 9)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                
                Console.WriteLine("Wyjdż z aplikacji    ");
                Console.CursorVisible = true;
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                

                if (cki.Key == ConsoleKey.UpArrow)
                {
                    if (x > 4)
                    {
                        x = x - 1;
                    }
                    Console.SetCursorPosition(0, x);
                }
                if (cki.Key == ConsoleKey.DownArrow)
                {
                    if (x < 8)
                    {
                        x = x + 1;
                    }
                    Console.SetCursorPosition(0, x);
                }
                if (cki.Key == ConsoleKey.LeftArrow)
                {
                    if (x == 4)
                    {
                        Refresh();
                    }
                    else if (x == 5)
                    {
                        k = 1;
                        Refresh();
                    }
                    else if (x == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                       
                        save = true;
                        Console.WriteLine("Ścieżka pliku txt (jeśli go nie ma to się utworzy, dodaj .txt na końcu ścieżki):");
                        sciezka = Console.ReadLine();
                        FileWrite(true);
                    }
                    else if (x == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1000);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        testanim();
                    }
                    else if (x == 8)




                        
                    {
                        Environment.Exit(0);
                    }
                }
            }
                Console.BackgroundColor = ConsoleColor.Black;
                
            
            
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
        static int f = 1;
        static int x = 0;
        static int y = 8;
        static bool menua = false;
        static int colore = 1;
        static void testanim()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Aby uzyskać informacje, napisz info lub jeśli wiesz, co zrobić to zrób co chcesz");
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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;      
            Console.WriteLine("\n" + "odtwórz|zapisz|info|tryb tekstowy|" + "kolor:"+colore+"  |"+"                                                                              ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 7);


            
            Console.CursorVisible = true;
            reload();
            
            Console.SetCursorPosition(x, y);
            while (true)
            {
                
                ConsoleKeyInfo ckii;
                ckii = Console.ReadKey(true);
                if (ckii.Key == ConsoleKey.Escape )
                {

                    int xm = 0;
                    Console.SetCursorPosition(0, 3);
                    while(true)
                    {
                        ConsoleKeyInfo ckm;
                        ckm = Console.ReadKey(true);
                        if (ckm.Key == ConsoleKey.RightArrow)
                        {
                            if (xm == 0) { xm = xm + 8; }
                            Thread.Sleep(100);
                            if (xm == 8) { xm = xm + 8; }
                            Thread.Sleep(100);
                            if (xm == 16) { xm = xm + 8; }
                            Console.SetCursorPosition(xm, 3);

                        }
                        if (ckm.Key == ConsoleKey.LeftArrow)
                        {
                            if (xm == 8) { xm = xm - 8; }
                            Thread.Sleep(100);
                            if (xm == 16) { xm = xm - 8; }
                            Thread.Sleep(100);
                            if (xm == 24) { xm = xm - 8; }
                            Console.SetCursorPosition(xm, 3);
                        }
                        if (ckm.Key == ConsoleKey.B)
                        {
                            if (xm >= 0 && xm <= 6)
                            {
                                Refresh();
                                
                            }
                            else if (xm >= 8 && xm <= 14)
                            {
                                Console.Clear();
                                save = true;
                                Console.WriteLine("Ścieżka pliku txt (jeśli go nie ma to się utworzy, dodaj .txt na końcu ścieżki):");
                                sciezka = Console.ReadLine();
                                
                                FileWrite(false);
                            }
                            else if (xm == 24)
                            {
                                
                            }
                            else if (xm >= 16 && xm <=20)
                            {
                                Console.Clear();
                                Console.WriteLine("\n" + "Witamy w CSharp Animator. Tutaj masz podstawowe informacje. " + "\n" + "\n" + "dostępne kolory:" + "\n");

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
                                Console.WriteLine("Sterowanie w edytorze: poruszanie się - strzałki, rysuj - B, zmaż - N, zmiana klatki - z/x, zmiana koloru - c/v; Menu górne - esc, sterowanie - strzałki, zatwierdź - b, wyjdź z menu górnego - esc | Odtwarzacz: wejście do menu górnego - esc, sterowanie - strzałki, zatwierdź - b");
                                Console.WriteLine("Tryb tekstowy - tryb kompatybilności, tutaj wkleja się kod animacji Ctrl+V");
                                Console.WriteLine("\n" + "Twórca: Wojciech Wójtowicz / drenewoo | Wersja programu: " + Version + "\n");
                                Console.WriteLine("" + "\n");  //<== tutaj wpisz swój nick jeśli zmodyfikowałeś kod. Dziękuje! | write here your nick if you modified code. Thank you! 
                                Console.WriteLine("Kliknij enter, jeśli chcesz wrócić");
                                Console.ReadLine();
                                Console.Clear();
                                testanim();
                            }
                        }
                        if(ckm.Key == ConsoleKey.Escape)
                        {
                            Console.SetCursorPosition(x, y);
                           
                        }

                    }
                }
                if (ckii.Key == ConsoleKey.B)
                {
                    data(x, y - 7, f, colore, false);
                    
                    reload();
                }
                if (ckii.Key == ConsoleKey.UpArrow)
                {
                    if(y > 7)
                    {
                        y = y - 1;
                        
                        Console.SetCursorPosition(x, y);
                        
                    }
                }
                if (ckii.Key == ConsoleKey.DownArrow)
                {
                    if (y < 36)
                    {
                        y = y + 1;
                        
                        Console.SetCursorPosition(x, y);
                       
                    }
                }
                if (ckii.Key == ConsoleKey.LeftArrow)
                {
                    if (x > 0)
                    {
                        x = x - 1;

                        Console.SetCursorPosition(x, y);

                    }
                }
                if (ckii.Key == ConsoleKey.RightArrow)
                {
                    if (x < 69)
                    {
                        x = x + 1;

                        Console.SetCursorPosition(x, y);

                    }
                }
                if (ckii.Key == ConsoleKey.Z)
                {
                    if (f < 1199)
                        f = f + 1;
                    reload();
                }
                if (ckii.Key == ConsoleKey.X)
                {
                    if (f > 1)
                        f = f - 1;
                    reload();
                }
                if (ckii.Key == ConsoleKey.C)
                {
                    if(colore < 15)
                    {
                        colore = colore + 1;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(40,3);
                        Console.Write(colore + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(x, y);
                    }
                }
                if (ckii.Key == ConsoleKey.V)
                {
                    if(colore > 1)
                    {
                        colore = colore - 1;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(40, 3);
                        Console.Write(colore + " ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(x, y);

                    }
                }
                if(ckii.Key == ConsoleKey.N)
                {
                    data(x, y - 7, f, 0, false);

                    reload();
                }
            }
        }
        static void reload()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 7);
            for (int a = 0; a < 30; a++)
            {
                for (int b = 0; b < 70; b++)
                {
                    if (color[b, a, f] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        if (save == true && savenow == true)
                        {
                            //k = 1;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        if (save == true && savenow == true && savenow == true)
                        {
                            //k = 2;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if (save == true && savenow == true)
                        {
                            //k = 3;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        if (save == true && savenow == true)
                        {
                            //k = 4;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        if (save == true && savenow == true)
                        {
                            //k = 5;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        if (save == true && savenow == true)
                        {
                            //k = 6;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (save == true && savenow == true)
                        {
                            //k = 7;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (save == true && savenow == true)
                        {
                            //k = 8;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        if (save == true && savenow == true)
                        {
                            //k = 9;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (save == true && savenow == true)
                        {
                            //k = 10;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 11)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (save == true && savenow == true)
                        {
                            //k = 11;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (save == true && savenow == true)
                        {
                            //k = 12;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 13)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        if (save == true && savenow == true)
                        {
                            //k = 13;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 14)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (save == true && savenow == true)
                        {
                            //k = 14;
                            //savenow = false;
                        }
                    }
                    else if (color[b, a, f] == 15)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        if (save == true && savenow == true)
                        {
                            //k = 15;
                            //savenow = false;
                        }
                    }
                    else if(frame[b,a,f] == ".")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                             
                            
                            Console.ForegroundColor = ConsoleColor.Black;
                        
                    }
                    
                    Console.Write(frame[b, a, f]);
                    
                }
                Console.Write("\n");
            }
            Console.CursorVisible = true;
        }
        static void textmode()
        {
            int x = 0;
            int y = 0;
            int c = 0;
            int q = 0; 
            
            string w = Console.ReadLine().ToLower();
            if (w == "w")
            {
                testanim();
            }
            else
            {
                x = Int32.Parse(Console.ReadLine());
                y = Int32.Parse(Console.ReadLine());
                c = Int32.Parse(Console.ReadLine());
                q = Int32.Parse(Console.ReadLine());
            }
            data(x, y, q, c, true);
        }
        static void data(int x, int y, int w, int c, bool tm)
        {
            if (c == 0)
            {
                frame[x, y, w] = ".";
                color[x, y, w] = 15;
            }
            else
            {
                frame[x, y, w] = "#";
                color[x, y, w] = c;
            }
            if (tm == true)
            {
                textmode();
            }
            else
            {
                testanim();
            }
        }
    }
}
