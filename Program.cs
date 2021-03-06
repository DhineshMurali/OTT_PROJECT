﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace manageProf {
    class Program {
        static void Main (string[] args) {
            string str, choice, ch, sec;
            int age, sp;
            Console.WriteLine ("----WELCOME TO OTT PLATFORMS PAGE----");
            Console.WriteLine ("Enter your user-name");
            str = Console.ReadLine ();
            Console.WriteLine ("Enter your age");
            age = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ("Choose your choice of platform: \nNETFLIX(select \'1\') \nAMAZON(select \'2\')");
            int opt = Convert.ToInt32 (Console.ReadLine ());
            switch (opt) {
                case 1:
                    Netflix ott1 = new Netflix (str, age);
                    showList sh1 = new showList ();
                    manageProf names_Nf = new manageProf ();
                    names_Nf[0] = "Dhinesh--0";
                    names_Nf[1] = "Abinand--1";

                    Console.WriteLine ("user name-----> " + ott1.name);
                    Console.WriteLine ("user age-----> " + ott1.age);
                    Console.WriteLine ("choose login-page or sign-up page(IF U DON'T HAVE A ACCOUNT)");
                    choice = Console.ReadLine ();
                    if (choice == "login") {
                        ott1.login ();
                        Console.WriteLine ("The index of your account profiles:");
                        for (int i = 0; i < manageProf.size; i++) {
                            Console.WriteLine (names_Nf[i]);
                        }
                        Console.WriteLine ("Select your profile index");
                        sp = Convert.ToInt16 (Console.ReadLine ());
                    } else if (choice == "sign-up") {
                        ott1.signup ();
                        Console.WriteLine ("\n");
                        ott1.plans ();
                        Console.WriteLine ("\n");
                        ott1.paymentOptions ();
                        ott1.login ();

                    }
                    Console.WriteLine ("SELECT THE -- MOVIES SECTION OR SERIES SECTION --");
                    sec = Console.ReadLine ();
                    if (sec == "series") {
                        Console.WriteLine ("==============================");
                        sh1.shows_Nf ();
                        Console.WriteLine ("==============================");
                        Console.WriteLine ("\n");
                        Console.WriteLine ("if you want to: \nsearch any show (PRESS 1) \nfind genre and filter based on rating(PRESS 2) \nExit (PRESS 3)");
                        ch = Console.ReadLine ();
                        if (ch == "1") {
                            sh1.search_Nf_shows ();
                        } else if (ch == "2") {
                            sh1.select_Nf_genre ();
                        } else {
                            break;
                        }
                    } else if (sec == "movies") {
                        Console.WriteLine ("==============================");
                        sh1.movies_Nf ();
                        Console.WriteLine ("==============================");
                        Console.WriteLine ("\n");
                        Console.WriteLine ("if you want to: \nSearch any show (PRESS 1) \n\tSelect genre and filter based on rating(PRESS 2) \n\t\tExit (PRESS 3)");
                        ch = Console.ReadLine ();
                        if (ch == "1") {
                            sh1.search_Nf_movies ();
                        } else if (ch == "2") {
                            sh1.select_Nf_movie_genre ();
                        } else {
                            break;
                        }
                    }

                    break;
                case 2:
                    AmazonPrime ott2 = new AmazonPrime (str, age);
                    showList sh2 = new showList ();
                    manageProf names_Ap = new manageProf ();
                    names_Ap[0] = "Dhinesh--0";
                    names_Ap[1] = "Abinand--1";
                    Console.WriteLine ("user name-----> " + ott2.name);
                    Console.WriteLine ("user age-----> " + ott2.age);
                    Console.WriteLine ("choose login-page or sign-up page(IF U DON'T HAVE A ACCOUNT)");
                    choice = Console.ReadLine ();
                    if (choice == "login") {
                        ott2.login ();
                        Console.WriteLine ("The index of your account profiles:");
                        for (int i = 0; i < manageProf.size; i++) {
                            Console.WriteLine (names_Ap[i]);
                        }
                        Console.WriteLine ("Select your profile index");
                        sp = Convert.ToInt16 (Console.ReadLine ());
                    } else if (choice == "sign-up") {
                        ott2.signup ();
                        Console.WriteLine ("\n");
                        ott2.plans ();
                        Console.WriteLine ("\n");
                        ott2.paymentOptions ();
                        ott2.login ();

                    }
                    Console.WriteLine ("SELECT THE -- MOVIES SECTION OR SERIES SECTION --");
                    sec = Console.ReadLine ();
                    if (sec == "series") {
                        Console.WriteLine ("==============================");
                        sh2.shows_Ap ();
                        Console.WriteLine ("==============================");
                        Console.WriteLine ("\n");
                        Console.WriteLine ("if you want to: \nsearch any show (PRESS 1) \nfind genre and filter based on rating(PRESS 2) \nExit (PRESS 3)");
                        ch = Console.ReadLine ();
                        if (ch == "1") {
                            sh2.search_Ap_shows ();
                        } else if (ch == "2") {
                            sh2.select_Ap_genre ();
                        } else {
                            break;
                        }
                    } else if (sec == "movies") {
                        Console.WriteLine ("==============================");
                        sh2.movies_Ap ();
                        Console.WriteLine ("==============================");
                        Console.WriteLine ("\n");
                        Console.WriteLine ("if you want to: \nSearch any show (PRESS 1) \n\tSelect genre and filter based on rating(PRESS 2) \n\t\tExit (PRESS 3)");
                        ch = Console.ReadLine ();
                        if (ch == "1") {
                            sh2.search_Ap_movies ();
                        } else if (ch == "2") {
                            sh2.select_Ap_movie_genre ();
                        } else {
                            break;
                        }
                    }

                    break;

            }
            Console.WriteLine ("\n");
            Console.WriteLine ("if you are paying both press 1 else 0");
            int a = Convert.ToInt16 (Console.ReadLine ());
            if (a == 1) {
                Console.WriteLine ("Enter the price of both of your plans ");
                Console.WriteLine ("Amount Paid for Netflix");
                int net = Convert.ToInt16 (Console.ReadLine ());
                Console.WriteLine ("Amount Paid for Amazon Prime");
                int ama = Convert.ToInt16 (Console.ReadLine ());
                payment p1 = new payment (net);
                payment p2 = new payment (ama);
                payment p3 = new payment ();
                p3 = p1 + p2;
                p3.discount ();
            } else
                Console.WriteLine ("Take both subscriptions and get our Special offer");

        }

    }
}