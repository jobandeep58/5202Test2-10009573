/*
 10009573
 jobandeep singh 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bird
    {

        string name, species, sex, weight, bandno;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Species
        {
            get { return species; }
            set { species = value; }
        }
        public string Sex
        {
            get { return Sex; }
            set { Sex = value; }
        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Bandno
        {
            get { return bandno; }
            set { bandno = value; }
        }


        public Bird(string _name, string _species, string _sex, string _weight, string _bandno)
        {
            Name = _name;
            species = _species;
            sex = _sex;
            weight = _weight;
            bandno = _bandno;
        }
        public string Birddata()
        {
            return "birdname=" + name;
        }
        public string Birdspecies()
        {
            return "species=" + species;
        }
        public string Birdsex()
        {
            return "sex=" + sex;
        }
        public string Birdweight()
        {
            return "birdweight=" + weight;
        }
        public string Birdbandno()
        {
            return "birdbandno=" + bandno;
        }
        class Program
        {
            static void main(string[] args)
            {

            }


            class program
            {
                static void Main(string[] args)
                {

                    Console.WriteLine("bird object and default data loaded");
                    //

                    Console.WriteLine("please update bird data");

                    //data updated for users
                    Console.WriteLine("name of bird");
                    string Birdtype = Console.ReadLine();

                    Console.WriteLine("enter species");
                    string species = Console.ReadLine();

                    Console.WriteLine("enter sex");
                    string sex = Console.ReadLine();

                    Console.WriteLine("enter weight");
                    string weight = Console.ReadLine();

                    Console.WriteLine("enter bandno");
                    string bandno = Console.ReadLine();

                    Console.WriteLine("##################");

                    // show data
                    Bird first = new Bird(Birdtype, species, sex, weight, bandno);

                    Console.WriteLine(first.Birddata());

                    Console.WriteLine(first.Birdspecies());

                    Console.WriteLine(first.Birdsex());

                    Console.WriteLine(first.Birdweight());

                    Console.WriteLine(first.Birdbandno());

                    Console.WriteLine("################################");

                    Console.ReadLine();
                }

            }
        }
    }

}
    

    

