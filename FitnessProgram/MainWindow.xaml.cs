using FitnessProgram.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace FitnessProgram
{
    public partial class MainWindow : Window
    {
        private List<Exercise> exercises = new List<Exercise>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddExercise_Click(object sender, RoutedEventArgs e)
        {
            // Get user input
            string name = txtName.Text;
            int duration = int.Parse(txtDuration.Text);

            IntensityLevel intensity = (IntensityLevel)cbIntensity.SelectedIndex;

            // Create new exercise and add to the list
            Exercise newExercise = new Exercise(name, duration, intensity);
            exercises.Add(newExercise);

            // Display exercises in the ListBox
            lstExercises.Items.Add(newExercise);

            // Update total duration
            UpdateTotalDuration();
        }

        private void UpdateTotalDuration()
        {
            // sum of all exercise durations
            int totalDuration = exercises.Sum(exercise => exercise.Duration);

            txtTotalDuration.Text = $"Total Duration: {totalDuration} minutes";
        }
    }

}
