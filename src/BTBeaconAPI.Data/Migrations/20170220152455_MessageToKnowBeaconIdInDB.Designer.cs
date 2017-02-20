using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BTBeaconAPI.Data;

namespace BTBeaconAPI.Data.Migrations
{
    [DbContext(typeof(BeaconContext))]
    [Migration("20170220152455_MessageToKnowBeaconIdInDB")]
    partial class MessageToKnowBeaconIdInDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BTBeaconAPI.Data.Entities.Beacon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("Guid");

                    b.Property<string>("Name");

                    b.Property<bool>("Removed");

                    b.Property<DateTime?>("RemovedDate");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Beacons");
                });

            modelBuilder.Entity("BTBeaconAPI.Data.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BeaconId");

                    b.Property<string>("Content");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BeaconId")
                        .IsUnique();

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("BTBeaconAPI.Data.Entities.Message", b =>
                {
                    b.HasOne("BTBeaconAPI.Data.Entities.Beacon", "Beacon")
                        .WithOne("Message")
                        .HasForeignKey("BTBeaconAPI.Data.Entities.Message", "BeaconId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
