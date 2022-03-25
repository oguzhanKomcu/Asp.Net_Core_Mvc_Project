namespace Hospital_System_Mvc.Project.Models.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }



        public DateTime? CreateDate { get; set; }
        public string CreatedIpAddress { get; set; }
        public string CreatedMachineName { get; set; }

        public DateTime? UpdateDate { get; set; }

        public string UpdateIpAddress { get; set; }
        public string UpdateMachineName { get; set; }

        public DateTime? DeletedDate { get; set; }

        public string DeletedIpAddress { get; set; }
        public string DeletedMachineName { get; set; }
    }
}
