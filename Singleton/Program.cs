// See https://aka.ms/new-console-template for more information

using Singleton;

Parallel.Invoke(
    PrintTeacherDetails,
    PrintStudentDetails
);
// Console.ReadLine();

static void PrintTeacherDetails()
{
    var fromTeacher = Mgr04.GetInstance;
    fromTeacher.PrintDetails("From Teacher");
}
static void PrintStudentDetails()
{
    var fromStudent = Mgr04.GetInstance;
    fromStudent.PrintDetails("From Student");
}

// Mgr01 - not thread safe, so output is 
// Counter Value 1
// Counter Value 2
// From Teacher
// From Student

// Mgr02 thread safe by adding lock
// Mgr03 eager loading, CLR takes care of object initialization and thread-safety