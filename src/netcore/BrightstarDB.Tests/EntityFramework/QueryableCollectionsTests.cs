﻿using System;
using System.Linq;
using BrightstarDB.EntityFramework;
using Xunit;

namespace BrightstarDB.Tests.EntityFramework
{
    
    public class QueryableCollectionsTests
    {
        private const string ConnectionString = "type=embedded;StoresDirectory=c:\\brightstar;";

        private readonly MyEntityContext _context;
        private readonly IDepartment _dept;

        public QueryableCollectionsTests()
        {
            var connectionString = ConnectionString + "StoreName=SimpleCollectionFilter_" + DateTime.UtcNow.Ticks;
            _context = new MyEntityContext(connectionString);
            var gardening = _context.Skills.Create();
            gardening.Name = "Gardening";
            var painting = _context.Skills.Create();
            painting.Name = "Painting";
            var carpentry = _context.Skills.Create();
            carpentry.Name = "Carpentry";

            _dept = _context.Departments.Create();
            _dept.Name = "Department99";
            var andy = _context.Persons.Create();
            andy.Name = "Andy";
            andy.Skills.Add(gardening);
            andy.Skills.Add(painting);
            andy.Skills.Add(carpentry);

            var arnold = _context.Persons.Create();
            arnold.Name = "Arnold";
            arnold.Skills.Add(painting);

            var bert = _context.Persons.Create();
            bert.Name = "Bert";
            _dept.Persons.Add(andy);
            _dept.Persons.Add(bert);
            _context.SaveChanges();
        }
        
        [Fact]
        public void TestSimpleCollectionFilter()
        {
            

            // If we look for all people whose name starts with A (using context as starting point), we get two results
            var queryResult = _context.Persons.Where(p => p.Name.StartsWith("A")).ToList();
            Assert.Equal(2, queryResult.Count);

            // If we look for people in dept99 whose name starts with A (using dept as starting point), we should only get one result
            queryResult = _dept.Persons.AsQueryable().Where(p => p.Name.StartsWith("A")).ToList();
            Assert.NotNull(queryResult);
            Assert.Equal(1, queryResult.Count);
            Assert.Equal("Andy", queryResult.First().Name);
            var andy = queryResult.First();

            var skills = andy.Skills.Where(s => !s.Name.EndsWith("ing")).ToList();
            Assert.Equal(1, skills.Count);
            Assert.Equal("Carpentry", skills.First().Name);

            var popularSkills = andy.Skills.Where(s => s.SkilledPeople.Count > 1).ToList();
            Assert.Equal(1, popularSkills.Count);
            Assert.Equal("Painting", popularSkills.First().Name);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}