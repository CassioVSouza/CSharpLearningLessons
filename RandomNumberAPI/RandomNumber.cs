using System;

namespace RandomNumberAPI
{
    public class RandomNumber
    {
        public void RandomList(Random random)
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel {FirstName = "Tim"},
                new PersonModel {FirstName = "Jum"},
                new PersonModel {FirstName = "Kim"},
                new PersonModel {FirstName = "Leon"},
            };

            var sortedPeople = people.OrderBy(x => random.Next());

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
            randomNumber(random);
        }

        private static void randomNumber(Random random)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(2, 5));
                Console.WriteLine(random.NextDouble() * 10);
            }
        }

        private class PersonModel
        {
            public string FirstName { get; set; }
        }
    }
            
}
