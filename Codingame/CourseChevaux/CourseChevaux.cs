using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Retour
{

    int Point1;
    int Point2;
    int Distance;

    public Retour(int p1, int p2, int d)
    {
        this.Point1 = p1;
        this.Point2 = p2;
        this.Distance = d;
    }

    public int getPoint1 { get => Point1; set => Point1 = value; }
    public int getPoint2 { get => Point2; set => Point2 = value; }
    public int getDistance { get => Distance; set => Distance = value; }

}

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class CourseChevaux
{
    // Méthode naïve de recherche de la plus petite distance
    // entre deux points d'un nuage de points
    // Entrée :
    //            data : liste de points
    static Retour ShortestDistanceNaive(int[] puissance)
    {
        // Initialisation
        Retour retour = new Retour(0, 0, 0);
        int distanceTmp = 0;

        // Recherche
        for (int i = 0; i < puissance.Length; i++)
        {
            for (int j = i + 1; j < puissance.Length; j++)
            {
                distanceTmp = Math.Abs(puissance[i] - puissance[j]);
                if ((i == 0 && j == 1) || distanceTmp < retour.getDistance)
                {
                    retour.getPoint1 = puissance[i];
                    retour.getPoint2 = puissance[j];
                    retour.getDistance = distanceTmp;
                }
            }
        }

        return retour;
    }

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] liste_pi = new int[N];
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            liste_pi[i] = pi;
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Retour retour = ShortestDistanceNaive(liste_pi);

        Console.WriteLine(retour.getDistance);
        Console.ReadLine();

    }
}