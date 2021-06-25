using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //     Application.Run(new Form1());
            //to runForm2 -
            //       Application.Run(new Form2());

            // to runForm3 -
           // Application.Run(new Form3());

            // to runForm4 -
            Application.Run(new Form4());
        }
    }
}

//what are windows application?
//are programs that depend upon windows operating system
//ex-calculator

//what are windows form?
//is used to UI
//is uses events based approach



//form is a class
//form1 is a derived class
//button1 is a class
//checkbox is a class
//every class contains members like variables, methods, events

//event- event is an method which will be called when action is performed by tool
//how to generate event- double click on button/form
//double click on events in Form1.cs[Design]->property->thunder symbol->load


//path-toolbox->button1->properties->thunder symbol click->event get generated(write code in that)

//different types of controls/tools

//windows application can have any number of forms
//right click on application in solution explorer->select add new->windows form


//MessageBox
//message box is a static class
//containe Show method
//show method is used to display alert box
//show() contains 4 parameters
//TEXT,CAPTIONS, BUTTONS,ICON



//NOTE-every time u change the form always change the last line of program.cs i.e.       Application.Run(new Form3());