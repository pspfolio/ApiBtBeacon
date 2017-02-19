using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BTBeaconAPI.Data;

namespace BTBeaconAPI.Data.Migrations
{
    [DbContext(typeof(BeaconContext))]
    [Migration("20170219124330_test10")]
    partial class test10
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

                    b.Property<DateTime>("RemovedDate");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Beacons");
                });
        }
    }
}
