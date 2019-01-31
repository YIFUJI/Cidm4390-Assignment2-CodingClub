sing System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CodingClub.Models
{
    public class DataSeed
    {
        public static void Seed(IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetRequiredService<AppDbContext>();

            db.Database.EnsureCreated();

            if (!db.Projects.Any() && !db.Clients.Any() && !db.Members.Any() && !db.ProjectPersons.Any())
            {
                var projects = new List<Project>
                {
                    new Project
                    {
                        ProjectName = "123"
                        
                    }
                }
            }
        }
    }
}
