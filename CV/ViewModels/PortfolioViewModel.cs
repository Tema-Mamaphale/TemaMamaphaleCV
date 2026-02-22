namespace CV.ViewModels
{
    public class PortfolioViewModel
    {
        public string FullName { get; set; } = "";
        public string Title { get; set; } = "";
        public string Location { get; set; } = "";
        public string Email { get; set; } = "";
        public string LinkedInUrl { get; set; } = "";
        public string GitHubUrl { get; set; } = "";
        public string About { get; set; } = "";

        public List<string> Strengths { get; set; } = new();

        public List<string> Programming { get; set; } = new();
        public List<string> Databases { get; set; } = new();
        public List<string> Frameworks { get; set; } = new();
        public List<string> ToolsAndCloud { get; set; } = new();
        public List<string> AiSkills { get; set; } = new();

        public EducationInfo Education { get; set; } = new();
        public List<Certification> Certifications { get; set; } = new();
        public List<ProjectItem> Projects { get; set; } = new();
    }

    public class EducationInfo
    {
        public string Institution { get; set; } = "";
        public string Qualification { get; set; } = "";
        public string Specialisation { get; set; } = "";
        public string Period { get; set; } = "";
    }

    public class Certification
    {
        public string Name { get; set; } = "";
        public string Provider { get; set; } = "";
        public string Year { get; set; } = "";
        public List<string> Highlights { get; set; } = new();
    }

    public class ProjectItem
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string TechStack { get; set; } = "";
        public string GitHubRepoUrl { get; set; } = "";
        public string? LiveDemoUrl { get; set; }
    }
}
