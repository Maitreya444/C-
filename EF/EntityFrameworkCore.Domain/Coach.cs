using System;

namespace EntityFrameworkCore.Domain
{   
    public abstract class BaseDomainModel
    {
        public DateTime CreateDate { get; set; }
    }

    public class Coach : BaseDomainModel
    {
        public int ID { get; set; }
        public string Name { get; set; } //string is like varchar
    }

    public class Team : BaseDomainModel
    {
        public int TeamID { get; set; }
        public string? Name { get; set; } //? means it is a nullable db
    }

}

