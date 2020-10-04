using System;
using Microsoft.EntityFrameworkCore;

namespace FAQ.Models
{
    public class QuestionContext : DbContext
    {
        public QuestionContext(DbContextOptions<QuestionContext> options)
        
            :base(options) { }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    QuestionId = 1,
                    Ask = "What's the framework/language combination for creating web apps?",
                    Answer = "ReactJS with Typescript",
                    CategoryId = "G",
                    TopicId = "C"
                },
                new Question
                {
                    QuestionId = 2,
                    Ask = "Why is ASP.NET Core MVC so hard?",
                    Answer = "Because it's your last semester before graduation!",
                    CategoryId = "G",
                    TopicId = "S"
                },
                new Question
                {
                    QuestionId = 3,
                    Ask = "What's the best CSS framework and why?",
                    Answer = "SASS. Modular, functional, no semicolons or braces!",
                    CategoryId = "O",
                    TopicId = "C"
                },
                new Question
                {
                    QuestionId = 4,
                    Ask = "Why is Diablo 3 so addictive?",
                    Answer = "The sound a legendary makes when it drops releases catastrophic amounts of dopamimne.",
                    CategoryId = "G",
                    TopicId = "L"
                },
                new Question
                {
                    QuestionId = 5,
                    Ask = "What is the greatest piece of 20th century art?",
                    Answer = "Stanley Kubrick's 1968 masterpiece '2001: A Space Odyssey'",
                    CategoryId = "O",
                    TopicId = "L"
                },
                new Question
                {
                    QuestionId = 6,
                    Ask = "Who is the greatest professor at Tri-C?",
                    Answer = "Ace Gayhart, obviously. Who else could compare?",
                    CategoryId = "O",
                    TopicId = "S"
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = "O",
                    CategoryName = "Opinion"
                },
                new Category
                {
                    CategoryId = "G",
                    CategoryName = "General"
                }
            );

            modelBuilder.Entity<Topic>().HasData(
                new Topic
                {
                    TopicId = "C",
                    TopicName = "Code"
                },
                new Topic
                {
                    TopicId = "L",
                    TopicName = "Leisure"
                },
                new Topic
                {
                    TopicId = "S",
                    TopicName = "School"
                }
            );
        }
        
    }
}