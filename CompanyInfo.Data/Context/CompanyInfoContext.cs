

namespace CompanyInfo.Data.Context
{
    public class CompanyInfoContext : DbContext
    {
        public CompanyInfoContext(DbContextOptions<CompanyInfoContext> options) : base(options) { }

        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Departament> Departaments=> Set<Departament>();
        public DbSet<DepartamentsName> DepartamentsNames => Set<DepartamentsName>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Job> Jobs => Set<Job>();
        public DbSet<Position> Positions => Set<Position>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
            {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Position>().HasKey(p => new { p.EmployeeId, p.JobId });
            SeedData(modelBuilder);
            }

        private void SeedData(ModelBuilder builder)
        {
            var companies = new List<Company> {
                        new Company { Id = 1, CompanyName = "Company1", OrganisationNumber = "08-123456", MainOffice = "Stockholm" },
                        new Company { Id = 2, CompanyName = "Company2", OrganisationNumber = "01-123456", MainOffice = "Oslo"},
                        new Company { Id = 3, CompanyName = "Company3", OrganisationNumber = "12-456789", MainOffice = "Helsinki"},
                        new Company { Id = 4, CompanyName = "Company4", OrganisationNumber = "31-123456", MainOffice = "Köpenhamn"}
            };
            var departamentsNames = new List<DepartamentsName> {
                new DepartamentsName { Id = 1, DepartamentName = "Administration"},
                new DepartamentsName { Id = 2, DepartamentName = "Marketing"},
                new DepartamentsName { Id = 3, DepartamentName = "HR"},
                new DepartamentsName { Id = 4, DepartamentName = "Accounting"},
                new DepartamentsName { Id = 5, DepartamentName = "IT"},
                new DepartamentsName { Id = 6, DepartamentName = "Legal"},
                new DepartamentsName { Id = 7, DepartamentName = "Production"},
                new DepartamentsName { Id = 8, DepartamentName = "Engineering"}
              };
            var departaments = new List<Departament> {
                               new Departament{ Id = 1, CompanyID = 1, DepartamentNameID = 1},
                               new Departament{ Id = 2, CompanyID = 1, DepartamentNameID = 2},
                               new Departament{ Id = 3, CompanyID = 1, DepartamentNameID = 3},
                               new Departament{ Id = 4, CompanyID = 1, DepartamentNameID = 4},
                               new Departament{ Id = 5, CompanyID = 1, DepartamentNameID = 5},
                               new Departament{ Id = 6, CompanyID = 1, DepartamentNameID = 6},
                               new Departament{ Id = 7, CompanyID = 1, DepartamentNameID = 7},
                               new Departament{ Id = 8, CompanyID = 1, DepartamentNameID = 8},
                               new Departament{ Id = 9,  CompanyID = 2, DepartamentNameID = 1},
                               new Departament{ Id = 10, CompanyID = 2, DepartamentNameID = 2},
                               new Departament{ Id = 11, CompanyID = 2, DepartamentNameID = 3},
                               new Departament{ Id = 12, CompanyID = 2, DepartamentNameID = 4},
                               new Departament{ Id = 13, CompanyID = 2, DepartamentNameID = 5},
                               new Departament{ Id = 14, CompanyID = 2, DepartamentNameID = 6},
                               new Departament{ Id = 15, CompanyID = 2, DepartamentNameID = 7},
                               new Departament{ Id = 16, CompanyID = 2, DepartamentNameID = 8},
                               new Departament{ Id = 17, CompanyID = 3, DepartamentNameID = 1},
                               new Departament{ Id = 18, CompanyID = 3, DepartamentNameID = 2},
                               new Departament{ Id = 19, CompanyID = 3, DepartamentNameID = 3},
                               new Departament{ Id = 20, CompanyID = 3, DepartamentNameID = 4},
                               new Departament{ Id = 21, CompanyID = 3, DepartamentNameID = 5},
                               new Departament{ Id = 22, CompanyID = 3, DepartamentNameID = 6},
                               new Departament{ Id = 23, CompanyID = 3, DepartamentNameID = 7},
                               new Departament{ Id = 24, CompanyID = 3, DepartamentNameID = 8},
                               new Departament{ Id = 25, CompanyID = 4, DepartamentNameID = 1},
                               new Departament{ Id = 26, CompanyID = 4, DepartamentNameID = 2},
                               new Departament{ Id = 27, CompanyID = 4, DepartamentNameID = 3},
                               new Departament{ Id = 28, CompanyID = 4, DepartamentNameID = 4},
                               new Departament{ Id = 29, CompanyID = 4, DepartamentNameID = 5},
                               new Departament{ Id = 30, CompanyID = 4, DepartamentNameID = 6},
                               new Departament{ Id = 31, CompanyID = 4, DepartamentNameID = 7},
                               new Departament{ Id = 32, CompanyID = 4, DepartamentNameID = 8}
            };
            var jobs = new List<Job>() {
                    new Job{ Id = 1, JobName = "Accountant", JobDescription = "Money Handler"},
                    new Job{ Id = 2, JobName = "HR Manager", JobDescription = "I love Humans"},
                    new Job{ Id = 3, JobName = "C# Developer", JobDescription = "Company geek"},
                    new Job{ Id = 4, JobName = "Sales Representative", JobDescription = "Can sell anything"},
                    new Job{ Id = 5, JobName = "Product manager", JobDescription = "the little boss"},
                    new Job{ Id = 6, JobName = "Lawyer", JobDescription = "Keeps trouble away"},
                    new Job{ Id = 7, JobName = "Maintenance personnel", JobDescription = "Everything needs to be clean"},
                    new Job{ Id = 8, JobName = "Network Engeneer", JobDescription = "http"},
                    new Job{ Id = 9, JobName = "IT Specialist", JobDescription = "TechSupport"},
                    new Job{ Id = 10, JobName = "Intership Personnel", JobDescription = "work in progress"},
                    new Job{ Id = 11,JobName = "CEO",JobDescription = "the high chief"},
                    new Job{ Id = 12, JobName = "Product Engeneer", JobDescription = "Another geek"}
            };
            var employees = new List<Employee>() {
               new Employee { Id = 1, FirstName = "FName1", LastName = "LName1", DepartamentId = 1, Salary = 95000, UnionMember = false },
               new Employee { Id = 2, FirstName = "FName2", LastName = "LName2", DepartamentId = 2, Salary = 40000, UnionMember = true },
               new Employee { Id = 3, FirstName = "FName3", LastName = "LName3", DepartamentId = 3, Salary = 50000, UnionMember = true },
               new Employee { Id = 4, FirstName = "FName4", LastName = "LName4", DepartamentId = 4, Salary = 50000, UnionMember = true },
               new Employee { Id = 5, FirstName = "FName5", LastName = "LName5", DepartamentId = 6, Salary = 70000, UnionMember = false },
               new Employee { Id = 6, FirstName = "FName6", LastName = "LName6", DepartamentId = 7, Salary = 70000, UnionMember = false },
               new Employee { Id = 7, FirstName = "FName7", LastName = "LName7", DepartamentId = 7, Salary = 45000, UnionMember = false },
               new Employee { Id = 8, FirstName = "FName8", LastName = "LName8", DepartamentId = 8, Salary = 44000, UnionMember = true },
               new Employee { Id = 9, FirstName = "FName9", LastName = "LName9", DepartamentId = 1, Salary = 25000, UnionMember = true },
               new Employee { Id = 10, FirstName = "FName10", LastName = "LName10", DepartamentId = 5, Salary = 45000, UnionMember = false },
               new Employee { Id = 11, FirstName = "FName11", LastName = "LName11", DepartamentId = 5, Salary = 35000, UnionMember = true },
               new Employee { Id = 12, FirstName = "FName12", LastName = "LName12", DepartamentId = 2, Salary = 35000, UnionMember = false },
               new Employee { Id = 13, FirstName = "FName13", LastName = "LName13", DepartamentId = 2, Salary = 30000, UnionMember = true },
               new Employee { Id = 14, FirstName = "FName14", LastName = "LName14", DepartamentId = 5, Salary = 0, UnionMember = false },
               new Employee { Id = 15, FirstName = "FName15", LastName = "LName15", DepartamentId = 21, Salary = 35000, UnionMember = false },
               new Employee { Id = 16, FirstName = "FName16", LastName = "LName16", DepartamentId = 13, Salary = 45000, UnionMember = true },
               new Employee { Id = 17, FirstName = "FName17", LastName = "LName17", DepartamentId = 9, Salary = 45000, UnionMember = false },
               new Employee { Id = 18, FirstName = "FName18", LastName = "LName18", DepartamentId = 11, Salary = 35000, UnionMember = false },
               new Employee { Id = 19, FirstName = "FName19", LastName = "LName19", DepartamentId = 10, Salary = 35000, UnionMember = true },
               new Employee { Id = 20, FirstName = "FName20", LastName = "LName20", DepartamentId = 13, Salary = 45000, UnionMember = true },
               new Employee { Id = 21, FirstName = "FName21", LastName = "LName21", DepartamentId = 14, Salary = 35000, UnionMember = false },
               new Employee { Id = 22, FirstName = "FName22", LastName = "LName22", DepartamentId = 17, Salary = 25000, UnionMember = true},
               new Employee { Id = 23, FirstName = "FName23", LastName = "LName23", DepartamentId = 25, Salary = 25000, UnionMember = false }
            };
            var positions = new List<Position> { 
                        new Position {EmployeeId = 1, JobId = 11 },
                        new Position {EmployeeId = 2, JobId = 4},
                        new Position {EmployeeId = 3, JobId = 2},
                        new Position {EmployeeId = 4, JobId = 1},
                        new Position {EmployeeId = 5, JobId = 6},
                        new Position {EmployeeId = 6, JobId = 12},
                        new Position {EmployeeId = 7, JobId = 9},
                        new Position {EmployeeId = 8, JobId = 12},
                        new Position {EmployeeId = 9, JobId = 8},
                        new Position {EmployeeId = 10, JobId = 3},
                        new Position {EmployeeId = 11, JobId = 3},
                        new Position {EmployeeId = 12, JobId = 4},
                        new Position {EmployeeId = 13, JobId = 10},
                        new Position {EmployeeId = 14, JobId = 10},
                        new Position {EmployeeId = 15, JobId = 9},
                        new Position {EmployeeId = 16, JobId = 9},
                        new Position {EmployeeId = 17, JobId = 11},
                        new Position {EmployeeId = 18, JobId = 2},
                        new Position {EmployeeId = 19, JobId = 4},
                        new Position {EmployeeId = 20, JobId = 3},
                        new Position {EmployeeId = 21, JobId = 6},
                        new Position {EmployeeId = 22, JobId = 7},
                        new Position {EmployeeId = 23, JobId = 7}
            };
            builder.Entity<Company>().HasData(companies);
            builder.Entity<Departament>().HasData(departaments);
            builder.Entity<DepartamentsName>().HasData(departamentsNames);
            builder.Entity<Employee>().HasData(employees);
            builder.Entity<Job>().HasData(jobs);
            builder.Entity<Position>().HasData(positions);
        }
    
    }
}
