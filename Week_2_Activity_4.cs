using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Week_2_Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        // Calculate Button Pressed:
        private void button1_Click(object sender, EventArgs e)
        {
            // Local variables
            double seconds;

            // Validate the userSecondsInput control.
            if (double.TryParse(userSecondsInput.Text, out seconds))
            {
                // Run first boolean with userInput in seconds. If correct value is entered procede to logic. If seconds less
                // than or equal to 60 run code:
                if (seconds <= 60)
                {
                // Store seconds entered divided by one to displaySeconds Variable:
                    var displaySeconds = seconds / 1;
                // Send stored data seconds to user GUI:
                    displaySecondsLabel.Text = displaySeconds.ToString();
                // Set zero to the label.
                    displayDaysLabel.Text = "0";
                // Set zero to the label.
                    displayHoursLabel.Text = "0";
                // Set zero to the label.
                    displayMinutesLabel.Text = "0";
                }
                else
                {
                    // Run second boolean check with seconds entered. Seconds is greater than or equal to 60 AND smaller than or
                    // equal to 86399. Results are TRUE and TRUE only!
                    if (seconds >= 60 && seconds <= 86399)
                    {
                    // Seconds is divided by 60 and the answer is stored in minutes.
                        var minutes = seconds / 60;
                    // Hours is divided by 3600 and the answer is dtored in hours.
                        var hours = seconds / 3600;
                    // To display the seconds entered from the user a variable was created to store the data.
                        var secondsDisplay = seconds;
                    // Send stored data hours to user GUI:
                        displayHoursLabel.Text = hours.ToString("#");
                    // Send stored data seconds to user GUI:
                        displaySecondsLabel.Text = secondsDisplay.ToString("#");
                    // Send stored data minutes to user GUI:
                        displayMinutesLabel.Text = minutes.ToString("#");
                    // Set zero to the label.
                        displayDaysLabel.Text = "0";
                    }

                    else
                    {
                        // If neither of the conditions are met, final check is initiated with seconds larger or equal to 86400.
                        if (seconds >= 86400)
                        {
                        // Seconds is divided by 60 and the answer is stored in minutes.    
                            var minutes = seconds / 60;
                        // Hours is divided by 3600 and the answer is dtored in hours.
                            var hours = seconds / 3600;
                        // To display the seconds entered from the user a variable was created to store the data.
                            var secondsDisplay = seconds;
                        // To display the days entered from the user seconds was divided by 86400.
                            var daysDisplay = seconds / 86400;
                        // Send stored data minutes to user GUI:
                            displayDaysLabel.Text = daysDisplay.ToString("#");
                        // Send stored data minutes to user GUI:
                            displayHoursLabel.Text = hours.ToString("#");
                        // Send stored data minutes to user GUI:
                            displaySecondsLabel.Text = secondsDisplay.ToString("#");
                        // Send stored data minutes to user GUI:
                            displayMinutesLabel.Text = minutes.ToString("#");
                        }
                        else
                        {
                            // Programmer Test
                            testLabel.Text = "If else If complete";
                        }
                    }

                }
            }
            else
            {
                // TryParse failed message. If user input wrong fieldtype, A friendly message is alerted.
                unsuccessfulDigitAttempt.Text = "Unsuccessful Data Input! Please Enter a Valid Number.";
            }

            

        }

        // Clear all fields and Labels
        private void clearButton_Click(object sender, EventArgs e)
        {
        // Set displayDaysLabel to empty:
            displayDaysLabel.Text = "";
        // Set displayHoursLabel to empty:
            displayHoursLabel.Text = "";
        // Set displaysecondsLabel to empty:
            displaySecondsLabel.Text = "";
        // Set displayMinutesLabel to empty:
            displayMinutesLabel.Text = "";
        // Set userSecondsInput to empty:
            userSecondsInput.Text = "";

        // Set the focus to userSecondsInput.
            userSecondsInput.Focus();

        }
        // Close the form.
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
        
    

