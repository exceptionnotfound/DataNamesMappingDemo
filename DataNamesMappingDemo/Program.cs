using DataNamesMappingDemo.Contracts;
using DataNamesMappingDemo.DataSets;
using DataNamesMappingDemo.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNamesMappingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var priestsDataSet = DataSetGenerator.Priests();
            DataNamesMapper<Person> mapper = new DataNamesMapper<Person>();
            List<Person> persons = mapper.Map(priestsDataSet.Tables[0]).ToList();

            var ranchersDataSet = DataSetGenerator.Ranchers();
            persons.AddRange(mapper.Map(ranchersDataSet.Tables[0]));

            foreach (var person in persons)
            {
                Console.WriteLine("First Name: " + person.FirstName + ", Last Name: " + person.LastName
                                  + ", Date of Birth: " + person.DateOfBirth.ToShortDateString()
                                  + ", Job Title: " + person.JobTitle + ", Nickname: " + person.TakenName
                                  + ", Is American: " + person.IsAmerican);
            }

            Console.ReadLine();
        }
    }
}
