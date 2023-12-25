using System;

namespace task1
{
    // Создаем класс ученик - Pupil
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil is studying");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil is reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil is writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil is relaxinп");
        }
    }

    // Создаем производный класс ExcellentPupil
    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil is not bad studying!");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil is not bad reading!");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil is so not bad writing!");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil is bad relaxing!");
        }
    }

    // Создаем производный класс GoodPupil
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil is nice studying!");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil is good reading!");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil is nice writing!");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil is very good relaxing!");
        }
    }

    // Создаем производный класс BadPupil
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil is bad studying!");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil is not normal reading!");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil is so bad writing!");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil is too good relaxing!");
        }
    }

    // Создаем класс ClassRoom
    class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

        public void AddPupil(Pupil pupil)
        {
            pupils.Add(pupil);
        }

        public void StartLesson()
        {
            Console.WriteLine("\nClass is starting a lesson. Oh no:");
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }
        }

        public void ReadingTime()
        {
            Console.WriteLine("\nIt's reading time. I'm tired:");
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }

        public void WritingTime()
        {
            Console.WriteLine("\nIt's writing time. Why:");
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }

        public void RelaxTime()
        {
            Console.WriteLine("\nIt's time to relax. Nice:");
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom();

            int totalPupils = 0;

            while (totalPupils < 2 || totalPupils > 4)
            {
                Console.Write("Enter the number of Pupils (2 to 4): ");
                totalPupils = int.Parse(Console.ReadLine());

                if (totalPupils < 2 || totalPupils > 4)
                {
                    Console.WriteLine("Not good. Try again");
                }
            }

            int excellentCount = 0;
            int goodCount = 0;
            int badCount = 0;

            for (int i = 0; i < totalPupils; i++)
            {
                Console.Write($"Enter type of pupil {i + 1} (1 for Excellent, 2 for Good, 3 for Bad): ");
                int pupilType = int.Parse(Console.ReadLine());

                switch (pupilType)
                {
                    case 1:
                        classRoom.AddPupil(new ExcellentPupil());
                        excellentCount++;
                        break;
                    case 2:
                        classRoom.AddPupil(new GoodPupil());
                        goodCount++;
                        break;
                    case 3:
                        classRoom.AddPupil(new BadPupil());
                        badCount++;
                        break;
                    default:
                        Console.WriteLine("Nice try. Let's try again:");
                        i--;
                        break;
                }
            }

            Console.WriteLine($"Excellent Pupils: {excellentCount}");
            Console.WriteLine($"Good Pupils: {goodCount}");
            Console.WriteLine($"Bad Pupils: {badCount}");

            classRoom.StartLesson();
            classRoom.ReadingTime();
            classRoom.WritingTime();
            classRoom.RelaxTime();
        }
    }
}
