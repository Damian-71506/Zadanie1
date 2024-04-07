using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void obliczButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dzielnaBox.Text) || string.IsNullOrWhiteSpace(dzielnikBox.Text))
                {
                    MessageBox.Show("Pola nie mogą być puste.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    String infoMessage = "Pola nie mogą być puste.";
                    EventLog.WriteEntry("Application", infoMessage, EventLogEntryType.Information);
                    return;

                }
                double dzielna = double.Parse(dzielnaBox.Text);
                double dzielnik = double.Parse(dzielnikBox.Text);

                if (dzielnik == 0 || dzielna == 0)
                {
                    MessageBox.Show("Nie możesz dzielić przez 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    String infoMessage = "Nie możesz dzielić przez 0.";
                    EventLog.WriteEntry("Application", infoMessage, EventLogEntryType.Information);
                    return;
                }

                double wynik = dzielna / dzielnik;
                resultBox.Text = wynik.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Nieprawidłowy format. Proszę podać liczbę.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EventLog.WriteEntry("Application", "Wystąpił błąd: " + ex.Message, EventLogEntryType.Error);

            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Wprowadzona wartość jest za duża.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EventLog.WriteEntry("Application", "Wystąpił błąd: " + ex.Message, EventLogEntryType.Error);

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Application", "Wystąpił błąd: " + ex.Message, EventLogEntryType.Error);
            }
            
        }
    }
}
