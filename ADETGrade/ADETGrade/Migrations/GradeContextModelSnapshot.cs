﻿// <auto-generated />
using ADETGrade.GradeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADETGrade.Migrations
{
    [DbContext(typeof(GradeContext))]
    partial class GradeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADETGrade.Models.ADETGrades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("FinalA1")
                        .HasColumnType("real");

                    b.Property<float>("FinalA2")
                        .HasColumnType("real");

                    b.Property<float>("FinalA3")
                        .HasColumnType("real");

                    b.Property<float>("FinalQ1")
                        .HasColumnType("real");

                    b.Property<float>("FinalQ2")
                        .HasColumnType("real");

                    b.Property<float>("FinalQ3")
                        .HasColumnType("real");

                    b.Property<float>("FinalTotal")
                        .HasColumnType("real");

                    b.Property<float>("MidTermTotal")
                        .HasColumnType("real");

                    b.Property<float>("MidtermA1")
                        .HasColumnType("real");

                    b.Property<float>("MidtermA2")
                        .HasColumnType("real");

                    b.Property<float>("MidtermA3")
                        .HasColumnType("real");

                    b.Property<float>("MidtermQ1")
                        .HasColumnType("real");

                    b.Property<float>("MidtermQ2")
                        .HasColumnType("real");

                    b.Property<float>("MidtermQ3")
                        .HasColumnType("real");

                    b.Property<float>("PreFinalA1")
                        .HasColumnType("real");

                    b.Property<float>("PreFinalA2")
                        .HasColumnType("real");

                    b.Property<float>("PreFinalA3")
                        .HasColumnType("real");

                    b.Property<float>("PreFinalQ1")
                        .HasColumnType("real");

                    b.Property<float>("PreFinalQ2")
                        .HasColumnType("real");

                    b.Property<float>("PreFinalQ3")
                        .HasColumnType("real");

                    b.Property<float>("PreFinalTotal")
                        .HasColumnType("real");

                    b.Property<float>("PrelimA1")
                        .HasColumnType("real");

                    b.Property<float>("PrelimA2")
                        .HasColumnType("real");

                    b.Property<float>("PrelimA3")
                        .HasColumnType("real");

                    b.Property<float>("PrelimQ1")
                        .HasColumnType("real");

                    b.Property<float>("PrelimQ2")
                        .HasColumnType("real");

                    b.Property<float>("PrelimQ3")
                        .HasColumnType("real");

                    b.Property<float>("PrelimTotal")
                        .HasColumnType("real");

                    b.Property<string>("StudName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearSection")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}