﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oneiros.API.Infrastructure;

#nullable disable

namespace Oneiros.API.Migrations
{
    [DbContext(typeof(OneirosContext))]
    [Migration("20230618152433_npc-name-added")]
    partial class npcnameadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Oneiros.Domain.Model.Campaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CampaignCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CampaignId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CampaignCharacters");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BackGroundId")
                        .HasColumnType("int");

                    b.Property<string>("BackStory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BackGroundId");

                    b.HasIndex("RaceId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Short")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.BackGround", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BackGrounds");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.NonPlayer.Build", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PresetId")
                        .HasColumnType("int");

                    b.Property<int>("Tier")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PresetId");

                    b.ToTable("Builds");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.NonPlayer.Preset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Presets");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.Player.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Generic.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AbilityId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterAbilities");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AbilityId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("FeatureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("FeatureId");

                    b.ToTable("CharacterFeatures");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CharacterLanguages");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<bool>("Proficiency")
                        .HasColumnType("bit");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SkillId");

                    b.ToTable("CharacterSkills");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("TagId");

                    b.ToTable("CharacterTags");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.NonPlayerBuild", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuildId")
                        .HasColumnType("int");

                    b.Property<int>("NonPlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildId");

                    b.HasIndex("NonPlayerId");

                    b.ToTable("NonPlayerBuilds");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AbilityId")
                        .HasColumnType("int");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("PresetId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("PresetId");

                    b.ToTable("PresetAbilities");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<int>("PresetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("FeatureId");

                    b.HasIndex("PresetId");

                    b.ToTable("PresetFeatures");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetLanguage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int?>("NonPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PresetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("NonPlayerId");

                    b.ToTable("PresetLanguages");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PresetId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PresetId");

                    b.HasIndex("SkillId");

                    b.ToTable("PresetSkills");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.RaceAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AbilityId")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int>("ScoreModifier")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AbilityId");

                    b.HasIndex("RaceId");

                    b.ToTable("RaceAbilities");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.RaceFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("RaceId");

                    b.ToTable("RaceFeatures");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.NonPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("NPCs");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("ClasseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ClasseId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CampaignCharacter", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Campaign", "Campaign")
                        .WithMany()
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Campaign");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Character", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.BackGround", "BackGround")
                        .WithMany()
                        .HasForeignKey("BackGroundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BackGround");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.NonPlayer.Build", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.NonPlayer.Preset", "Preset")
                        .WithMany()
                        .HasForeignKey("PresetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preset");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterAbility", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Ability", "Ability")
                        .WithMany()
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany("Abilities")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ability");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterFeature", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany("Features")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId");

                    b.Navigation("Character");

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterLanguage", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany("Languages")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterSkill", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany("Skills")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.CharacterTag", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.Generic.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.NonPlayerBuild", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.NonPlayer.Build", "Build")
                        .WithMany()
                        .HasForeignKey("BuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.NonPlayer", "NonPlayer")
                        .WithMany("Builds")
                        .HasForeignKey("NonPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Build");

                    b.Navigation("NonPlayer");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetAbility", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId");

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.NonPlayer.Preset", "Preset")
                        .WithMany("Abilities")
                        .HasForeignKey("PresetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Preset");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetFeature", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId");

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.NonPlayer.Preset", null)
                        .WithMany("Features")
                        .HasForeignKey("PresetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetLanguage", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId");

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.NonPlayer", null)
                        .WithMany("Languages")
                        .HasForeignKey("NonPlayerId");

                    b.Navigation("Character");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.PresetSkill", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.NonPlayer.Preset", "Preset")
                        .WithMany("Skills")
                        .HasForeignKey("PresetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preset");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.RaceAbility", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Ability", "Ability")
                        .WithMany()
                        .HasForeignKey("AbilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Race", "Race")
                        .WithMany("AbilityModifiers")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ability");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Links.RaceFeature", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.NonPlayer", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Player", b =>
                {
                    b.HasOne("Oneiros.Domain.Model.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oneiros.Domain.Model.CharacterModel.Player.Classe", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseId");

                    b.Navigation("Character");

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.Character", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("Features");

                    b.Navigation("Languages");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.NonPlayer.Preset", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("Features");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.CharacterModel.Race", b =>
                {
                    b.Navigation("AbilityModifiers");
                });

            modelBuilder.Entity("Oneiros.Domain.Model.NonPlayer", b =>
                {
                    b.Navigation("Builds");

                    b.Navigation("Languages");
                });
#pragma warning restore 612, 618
        }
    }
}
