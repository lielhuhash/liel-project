namespace liel_project.Model
{
    public class employer
    {
        public int IdE { get; set; }
        public string NameE { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public ICollection<job> Jobs { get; set; }

    }
}
