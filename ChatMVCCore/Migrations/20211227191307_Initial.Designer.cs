﻿// <auto-generated />
using System;
using ChatMVCCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChatMVCCore.Migrations
{
    [DbContext(typeof(MessageContext))]
    [Migration("20211227191307_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChatMVCCore.Models.MessageDetailsModel", b =>
                {
                    b.Property<long>("MessageRecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MessageType")
                        .HasColumnType("int");

                    b.HasKey("MessageRecordID");

                    b.ToTable("MessageDetailsModel");
                });

            modelBuilder.Entity("ChatMVCCore.Models.MessageModel", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("MessageDetailsMessageRecordID")
                        .HasColumnType("bigint");

                    b.Property<string>("Receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecordID");

                    b.HasIndex("MessageDetailsMessageRecordID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ChatMVCCore.Models.MessageModel", b =>
                {
                    b.HasOne("ChatMVCCore.Models.MessageDetailsModel", "MessageDetails")
                        .WithMany()
                        .HasForeignKey("MessageDetailsMessageRecordID");
                });
#pragma warning restore 612, 618
        }
    }
}
