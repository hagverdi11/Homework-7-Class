using System;

namespace Class_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[6];
            //numbers[1] = 3;
            //numbers[2] = 5;
            //numbers[5] = 10;

            //Array.Resize(ref numbers, 15);

            //numbers[8] = 10;
            //numbers[13] = 46;

            //foreach (var items in numbers)
            //{
            //    Console.WriteLine(items);

            //}

            //int[] nums = { 5, 8, 12, 16, 3, 1 };
            //Array.Sort(nums);

            //foreach (var item in nums) 

            //Console.WriteLine(item);
            //Console.WriteLine(nums.Rank);

            //string name3 = "Fabio";
            //string surname3 = "Cannavaro";
            //int age3 = 26;


            //string name1 = "Ezequiel";
            //string surname1 = "Garay";
            //int age1 = 55;

            //string name2 = "Anthony";
            //string surname2 = "Hopkins";
            //int age2 = 85;

            //Console.WriteLine(name2 + " " + surname2 + " " + "age" + age2);


            //var obj1 = new
            //{
            //    name = "Okan",
            //    surname = "Buruk",
            //    age = "40"
            //};

            //var obj2 = new
            //{
            //    name = "Fatih",
            //    surname = "Terim",
            //    age = 70
            //};

            //Console.WriteLine(obj1.name + " " + obj1.surname);
            Student st1 = new Student("aaaa");
            st1.name = "Gennaro";
            st1.surname = "Gattuso";
            st1.age = 25;
            st1.adress = "San Siro";


            //Student st2 = new Student("Paolo", 25);
            //st2.name = "Kakha";
            //st2.surname = "Kaladze";
            //st2.age = 55;
            //st2.adress = "Georgia";

            //Console.WriteLine(st2.FullName());
            //Console.WriteLine(st2.FullData());
                
                
          
        }
    }

    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string adress;




        public string FullName()
        {
            return name + " " + surname;
        }

        //public Student()
        //{

        //}



        //public Student(string studentName, int studentAge)
        //{
        //    name = studentName;
        //    age = studentAge;
        //    Console.WriteLine(name + age);

        //}

        public Student()
        {
            Console.WriteLine("Empty");
        }


        public Student(int age):this ()
        {
            Console.WriteLine(25);
        }

        public Student(string name):this(23)
        {
            Console.WriteLine("Ignazio Abate");
        }


















        //public string FullData()
        //{
        //    return name + " " + surname + " " + age + " " + adress;
        //}

        






    }





    



}
