// See https://aka.ms/new-console-template for more information

using Singleton;

Parallel.Invoke(
    PrintTeacherDetails,
    PrintStudentDetails
);
Console.ReadLine();

static void PrintTeacherDetails()
{
    var fromTeacher = Mgr02.GetInstance();
    fromTeacher.PrintDetails("From Teacher");
}
static void PrintStudentDetails()
{
    var fromStudent = Mgr02.GetInstance();
    fromStudent.PrintDetails("From Student");
}