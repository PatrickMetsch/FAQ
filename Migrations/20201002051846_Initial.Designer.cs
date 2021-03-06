﻿// <auto-generated />
using FAQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQ.Migrations
{
    [DbContext(typeof(QuestionContext))]
    [Migration("20201002051846_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("FAQ.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "O",
                            CategoryName = "Opinion"
                        },
                        new
                        {
                            CategoryId = "G",
                            CategoryName = "General"
                        });
                });

            modelBuilder.Entity("FAQ.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Answer")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ask")
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TopicId")
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TopicId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            Answer = "ReactJS with Typescript",
                            Ask = "What's the framework/language combination for creating web apps?",
                            CategoryId = "G",
                            TopicId = "C"
                        },
                        new
                        {
                            QuestionId = 2,
                            Answer = "Because it's your last semester before graduation!",
                            Ask = "Why is ASP.NET Core MVC so hard?",
                            CategoryId = "G",
                            TopicId = "S"
                        },
                        new
                        {
                            QuestionId = 3,
                            Answer = "SASS. Modular, functional, no semicolons or braces!",
                            Ask = "What's the best CSS framework and why?",
                            CategoryId = "O",
                            TopicId = "C"
                        },
                        new
                        {
                            QuestionId = 4,
                            Answer = "The sound a legendary makes when it drops releases catastrophic amounts of dopamimne.",
                            Ask = "Why is Diablo 3 so addictive?",
                            CategoryId = "G",
                            TopicId = "L"
                        },
                        new
                        {
                            QuestionId = 5,
                            Answer = "Stanley Kubrick's 1968 masterpiece '2001: A Space Odyssey'",
                            Ask = "What is the greatest piece of 20th century art?",
                            CategoryId = "O",
                            TopicId = "L"
                        },
                        new
                        {
                            QuestionId = 6,
                            Answer = "Ace Gayhart, obviously. Who else could compare?",
                            Ask = "Who is the greatest professor at Tri-C?",
                            CategoryId = "O",
                            TopicId = "S"
                        });
                });

            modelBuilder.Entity("FAQ.Models.Topic", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TopicName")
                        .HasColumnType("TEXT");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = "C",
                            TopicName = "Code"
                        },
                        new
                        {
                            TopicId = "L",
                            TopicName = "Leisure"
                        },
                        new
                        {
                            TopicId = "S",
                            TopicName = "School"
                        });
                });

            modelBuilder.Entity("FAQ.Models.Question", b =>
                {
                    b.HasOne("FAQ.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("FAQ.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");
                });
#pragma warning restore 612, 618
        }
    }
}
