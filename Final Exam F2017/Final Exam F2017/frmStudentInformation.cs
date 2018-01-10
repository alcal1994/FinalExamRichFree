using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam_F2017
{
    
   
    public frmStudentInformation()
    {
        InitializeComponent();
    }


    public void fillStudents()
    {
        int count = 0;
        string individual;

        // Read the file and display it line by line.  
        System.IO.StreamReader file =
            new System.IO.StreamReader(@"c:\students.txt");
        while ((individual = file.ReadLine()) != null)
        {
            System.Console.WriteLine(individual);
            count++;
        }

        file.Close();
        System.Console.WriteLine("Now students are available to access", count);
        // Suspend the screen.  
        System.Console.ReadLine();

        

    }

    private void HandleChange(StudentsList students)
    {
   
    }



    public partial class frmStudentInformation : Form
    {
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int marks;
            if(marks>=60)

        }
    }

}
}
