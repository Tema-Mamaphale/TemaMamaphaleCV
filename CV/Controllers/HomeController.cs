using System.Diagnostics;
using CV.Models;
using Microsoft.AspNetCore.Mvc;
using CV.ViewModels;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new PortfolioViewModel
            {
                FullName = "Mamaphale Leago Tema",
                Title = "Computer Science Student • Application Development • AI-Aware Engineer",
                Location = "Johannesburg, South Africa",
                Email = "temaleago@gmail.com",
                LinkedInUrl = "https://www.linkedin.com/in/leago-tema-474570332/",
                GitHubUrl = "https://github.com/LEA-GO",

                About = "Final-year Computer Science student specialising in Application Development with strong foundations in Java, Kotlin, C#, SQL, and cloud deployment. Recently completed WeThinkCode_ Generative AI for Software Engineers, with exposure to AI-assisted development workflows and responsible AI practices. Interested in software development, application support, and modern engineering best practices.",

                Strengths = new()
                {
                    "Analytical, methodical problem-solving",
                    "High attention to detail and data accuracy",
                    "Clear technical communication",
                    "Ownership and accountability",
                    "Adaptable and quick learner"
                },

                Programming = new() { "Java", "Kotlin (learning)", "C#", "SQL", "Python (basic)" },
                Databases = new() { "SQL", "MongoDB" },
                Frameworks = new() { "ASP.NET Core MVC (fundamentals)", "Java Swing" },
                ToolsAndCloud = new() { "Git/GitHub", "Microsoft Azure (Web Apps, Azure SQL)", "Visual Studio", "IntelliJ IDEA", "VS Code" },
                AiSkills = new() { "AI-assisted development workflows", "Prompt engineering fundamentals", "Responsible AI practices" },

                Education = new EducationInfo
                {
                    Institution = "IIE MSA (Emeris – Ruimsig)",
                    Qualification = "Bachelor of Computer Science and Information Sciences",
                    Specialisation = "Application Development",
                    Period = "2024 – Present"
                },

                Certifications = new()
                {
                    new Certification
                    {
                        Name = "Generative AI for Software Engineers",
                        Provider = "WeThinkCode_",
                        Year = "2026",
                        Highlights = new()
                        {
                            "AI-assisted development workflows",
                            "Prompt engineering fundamentals",
                            "Responsible AI practices",
                            "Practical GenAI integration in engineering"
                        }
                    }
                },

                Projects = new()
                {
                    new ProjectItem
                    {
                        Name = "Cloud Development",
                        Description = "Cloud development project packaged for submission, demonstrating structured project setup and deployment-oriented thinking.",
                        TechStack = "Cloud • Git/GitHub",
                        GitHubRepoUrl = "https://github.com/LEA-GO/Cloud-Development",
                        LiveDemoUrl = null
                    }
                }
            };

            return View(vm);
        }
    }
}