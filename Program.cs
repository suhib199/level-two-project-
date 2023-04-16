
using level_two_project_;
var studentsDetails = new Dictionary<int, Students>();
var path = @"C:\Users\user\Desktop\level two project.txt";
using (FileStream fileToRead = File.OpenRead(path))//Auto release(dispose)
{
    using var readNow = new StreamReader(fileToRead);
    string lines;
    double sumation = 0;
    double avg = 0;

    while ((lines = readNow.ReadLine()) != null)
    {
        string[] dictionaryKey = lines.Split('|');
        int number;
        if (int.TryParse(dictionaryKey[1], out number))//To skip the first line in notepad and jump straight to studnts details(start from scond line)
        {
            Courses fillingCourseDetails = new Courses(dictionaryKey[2], Convert.ToDouble(dictionaryKey[3]), dictionaryKey[4]);
            Students fillingStudentsDetails = new Students(dictionaryKey[0], Convert.ToInt32(dictionaryKey[1]));
            studentsDetails.Add(number, fillingStudentsDetails);
            studentsDetails[number].courseFullDetails.Add(fillingCourseDetails);//To fill the list at students class

            //To calculate the avg
            sumation += fillingCourseDetails.studentMark;
            avg = sumation / studentsDetails.Count;
        }



    }
    Console.WriteLine("The average of students marks = {0}", avg);
    Console.WriteLine("---------------------------------------------------------------------");




    //For top 3 marks
    var marks = new Dictionary<string, double>();
    foreach (var pointer in studentsDetails.Values)
    {
        foreach (var pointer2 in pointer.courseFullDetails)
        {
            marks.Add(pointer.studentName, pointer2.studentMark);
        }
    }
    var topThreeMarksSelection = marks.OrderByDescending(x => x.Value).Take(3);
    var topThreeStudents = topThreeMarksSelection.Select(x => x.Key);

    Console.WriteLine("The top three marks:");
    foreach (var pointer in topThreeMarksSelection)
    {
        Console.Write(pointer + " ");
    }
    Console.WriteLine("\n---------------------------------------------------------------------");




    //Maximum and minimum mark
    var marksFromDictonary = new List<double>();
    double maximumMrk = 0, minimumMrk = 0, counter = 0;
    foreach (var pointer in studentsDetails.Values)
    {
        foreach (var pointer2 in pointer.courseFullDetails)
        {
            marksFromDictonary.Add(pointer2.studentMark);
            if (counter < 1)//To avoid comparing all students marks only to the first mark in the notpadfile
            {
                maximumMrk = marksFromDictonary[0];
                minimumMrk = marksFromDictonary[0];
                counter++;
            }
            if (pointer2.studentMark > maximumMrk)
            {
                maximumMrk = pointer2.studentMark;
            }
            if (pointer2.studentMark < minimumMrk)
            {
                minimumMrk = pointer2.studentMark;
            }
        }

    }
    Console.WriteLine("The maximum mark = {0}", maximumMrk);
    Console.WriteLine("The minimum mark = {0}", minimumMrk);
    Console.WriteLine("---------------------------------------------------------------------");





    //Students marks without repeated
    Console.WriteLine("Marks without repeated");
    var marksWithoutRepeated = marksFromDictonary.Distinct();
    foreach (var pointer in marksWithoutRepeated)
    {
        Console.Write(pointer + " ");
    }
    Console.WriteLine("\n---------------------------------------------------------------------");
   
}






//Print students details
t dele = null;
dele += new t(studentsDetails[1823459].StudentInformations);
dele.Invoke();
Console.WriteLine("\n---------------------------------------------------------------------");

