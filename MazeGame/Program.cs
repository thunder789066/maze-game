using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name :\t");
            string name = Console.ReadLine();

            Console.Write("Hello " + name + ", do you wish to venture into the maze?\tyes or no:\t");
            string start = Console.ReadLine().ToLower();

            if (start == "no")
            {
                Console.WriteLine("\t Game Over! Your life is suddenly lost & you never awaken again!");
            }

            else if (start == "yes")
            {
                Console.WriteLine("Welcome " + name + ".......\r\n \t .........You have mysteriously woken up in a cage. You find out that the cage is going up like an");
                Console.WriteLine("elevator. When you look around, there is nothing around you except 4 boxes in each corner of the cage.");
                Console.WriteLine("Suddenly, the elevator cage stops almost knocking you over. Then, on every side of the cage, you see screens starting");
                Console.WriteLine("to flash on. A message appears on the screen......... \r\n \t It says 'Choose a box from one of the corners and the elevator will continue to go up to the surface..........");
                Console.WriteLine("\r\n The boxes show images that reveal themselves to be weapons. The weapon choices are (1)sword, (2)double-sided axe, (3)bow & arrow, or (4)gun.");
                Console.WriteLine("Once you choose your weapon, you will enter the maze. There is no going back......");

                Console.Write("Now choose your weapon,   1   2   3   4 :\t");
                int weapon = int.Parse(Console.ReadLine());

                if (weapon == 1)
                {
                    Console.WriteLine("\r\n \t You open the box & take the sword. The boxes that contain the double-sided axe, bow & arrow, and the gun all disappear. The elevator \r\n shakes a little and continues to move up to the surface.");
                }
                else if (weapon == 2)
                {
                    Console.WriteLine("\r\n \t You open the box & take the double-sided axe. The boxes that contain the sword, bow & arrow, and them gun all disappear. The elevator \n shakes a little and continues to move up to the surface.");
                }
                else if (weapon == 3)
                {
                    Console.WriteLine("\r\n \t You open the box & take the bow & arrow. The boxes that contain the double-sided axe, sword, and the gun all disappear. The elevator \n shakes a little and continues to move up to the surface.");
                }
                else if (weapon == 4)
                {
                    Console.WriteLine("\r\n \t You open the box & take the gun. The boxes that contain the double-sided axe, bow & arrow, and the sword all disappear. The elevator \n shakes a little and continues to move up to the surface.");
                }
                Console.WriteLine("\r\n \t When the top of the cage reaches the surface, it stops. The top of the cage is opened & you climb out. Once your out of the cage, you");
                Console.WriteLine("look down & the elevator cage disppears. You look around & find out that you were placed in the middle of the maze. You are surrounded");
                Console.WriteLine("by tall walls & no ceiling.......");
                Console.WriteLine("Shall we get started?.........");
                Console.WriteLine("There are two paths you could take. One in front of you & one behind you. Which do you choose?......");

                Console.Write(" front \t or \t behind :\t");
                string path1;
                path1 = Console.ReadLine().ToLower();

                if (path1 == "front" || path1 == "behind")
                {
                    Console.WriteLine("\r\n \t You walk down the pathway until you reach two more paths. The one on the right is a tunnel that leads into the ground, but you hear strange sounds");
                    Console.WriteLine("coming from inside the tunnel. The pathway on the left has no stairs but goes upwards. Which do you choose?......");

                    Console.Write(" up \t or \t down :\t");
                    string path2 = Console.ReadLine().ToLower();

                    if (path2 == "down")
                    {
                        Console.WriteLine("\r\n \t You go down into the tunnel & reach a dead end. You turn to try to go back & see big red eyes staring at you. The thing");
                        Console.WriteLine("with the red eyes was an.......ant?");
                        Console.WriteLine("\n \t The giant ant eats you alive & you die. \n \t GAME OVER!!!!!");
                    }
                    else if (path2 == "up")
                    {
                        Console.WriteLine("\r\n \t You walk down the path chosen but before you reach the end of the pathway, a giant red-eyed ant jumps off from the top of the wall");
                        Console.WriteLine("& lands right in front of you blocking three pathways behind it. Your only options are to either fight & kill the ant or run back");
                        Console.WriteLine("to where you started. What will you do?");

                        Console.Write(" run \t or \t fight :\t");
                        string survive = Console.ReadLine().ToLower();

                        if (survive == "run")
                        {
                            Console.WriteLine("\r\n \t You turn around & run back to where you started. The giant ant chases you & jumps on you before you reach the starting point.");
                            Console.WriteLine("\n \t The giant ant eats you alive & you die. \n \t GAME OVER!!!!!");
                        }
                        else if (survive == "fight")
                        {
                            Console.WriteLine("\r\n \t With the weapon you chose earlier, you kill the ant. Hooray!!! The ant's dead & you live!!!");
                            Console.WriteLine("for now at least.......");
                            Console.WriteLine("You then hear a ticking noise coming from the ant you just killed. You see something in the giant ant take it out. You then find out");
                            Console.WriteLine("that the ticking noise was actually a device. The device has a screen showing an arrow indicating where you are in the maze & an X");
                            Console.WriteLine("further away from the arrow. Just when you think that the device might be useful & help you get out of the maze, you start to");
                            Console.WriteLine("think that it may lead you to other ants or a trap. Should you choose to keep the device or leave it behind?..........");

                            Console.Write(" keep \t or \t leave :\t");
                            string device = Console.ReadLine().ToLower();

                            if (device == "leave")
                            {
                                Console.WriteLine("\r\n \t You throw the device at the ground & turn back to the three pathways you still have yet to choose. You could go to the left, the");
                                Console.WriteLine("center, or the right. Which path do you choose?..........");

                                Console.Write(" left  \t or \t center \t or \t right : \t");
                                string path3 = Console.ReadLine().ToLower();

                                if (path3 == "left")
                                {
                                    Console.WriteLine("\r\n \t You walk down the path to the left. But before you reach the end, something lands on the ground behind. You turn around to find another");
                                    Console.WriteLine("giant ant. You take out your weapon to kill the ant, but didn't realize that more ants show up behind you.");
                                    Console.WriteLine("\r\n \t You get eaten by the ants behind you & die. GAME OVER!!!!!");
                                }
                                else if (path3 == "right")
                                {
                                    Console.WriteLine("\r\n \t You walk down the path to the right. But before you reach the end, something lands on the ground behind. You turn around to find another");
                                    Console.WriteLine("giant ant. You take out your weapon to kill the ant, but didn't realize that more ants show up behind you.");
                                    Console.WriteLine("\r\n \t You get eaten by the ants behind you & die. GAME OVER!!!!!");
                                }
                                else if (path3 == "center")
                                {
                                    Console.WriteLine("\r\n \t You walk down the path in the center. When you come the end of the path, you find an open cage & a screen next to it that");
                                    Console.WriteLine("says Congratulations!!! You finally made it out of the maze!!! Your prize is......");
                                    Console.WriteLine("\t Get in the cage, it will send you back to society.");
                                }
                            }
                            else if (device == "keep")
                            {
                                Console.WriteLine("\r\n \t You take the device & turn back to the three pathways you still have yet to choose. You could go to the left, the");
                                Console.WriteLine("center, or the right. The X on the device says to go to the center, but you still aren't sure that you should");
                                Console.WriteLine("trust it. Which path do you choose?..........");

                                Console.Write(" left  \t or \t center \t or \t right : \t");
                                string path3 = Console.ReadLine().ToLower();

                                if (path3 == "left")
                                {
                                    Console.WriteLine("\r\n \t You walk down the path to the left. But before you reach the end, something lands on the ground behind. You turn around to find another");
                                    Console.WriteLine("giant ant. You take out your weapon to kill the ant, but didn't realize that more ants show up behind you.");
                                    Console.WriteLine("\r\n \t You get eaten by the ants behind you & die. GAME OVER!!!!!");
                                }
                                else if (path3 == "right")
                                {
                                    Console.WriteLine("\r\n \t You walk down the path to the right. But before you reach the end, something lands on the ground behind. You turn around to find another");
                                    Console.WriteLine("giant ant. You take out your weapon to kill the ant, but didn't realize that more ants show up behind you.");
                                    Console.WriteLine("\r\n \t You get eaten by the ants behind you & die. GAME OVER!!!!!");
                                }
                                else if (path3 == "center")
                                {
                                    Console.WriteLine("\r\n \t You walk down the path in the center. When you come the end of the path, you find an open cage & a screen next to it that");
                                    Console.WriteLine("says Congratulations!!! You finally made it out of the maze!!! Your prize is......");
                                    Console.WriteLine("\t Get in the cage, it will send you back to society.");
                                }
                            }
                        }
                    }
                }

            }



                Console.ReadKey();
        }
    }
}
