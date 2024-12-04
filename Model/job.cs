namespace liel_project.Model
{
    public class job
    {
        public  int IdJ { get; set; }
        public string JobName { get; set; }
        public string Description { get; set; }
        public string AdvDate { get; set; }
        public ICollection<employer> Employer{ get; set; }
        public string Category { get; set; } 

    }
}
