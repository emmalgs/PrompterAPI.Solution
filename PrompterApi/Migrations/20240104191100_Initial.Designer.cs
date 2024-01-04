﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrompterApi.Models;

#nullable disable

namespace PrompterApi.Migrations
{
    [DbContext(typeof(PrompterApiContext))]
    [Migration("20240104191100_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PrompterApi.Models.Prompt", b =>
                {
                    b.Property<int>("PromptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PromptText")
                        .HasColumnType("longtext");

                    b.HasKey("PromptId");

                    b.ToTable("Prompts");

                    b.HasData(
                        new
                        {
                            PromptId = 1,
                            PromptText = "What is your favorite color?"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
