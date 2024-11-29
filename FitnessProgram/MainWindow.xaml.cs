using FitnessProgram.Models;
using System.Collections.Generic;
using System.Linq;
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
            // Gebruikersinvoer ophalen
            string name = txtName.Text;
            int duration = int.Parse(txtDuration.Text);
            IntensityLevel intensity = (IntensityLevel)cbIntensity.SelectedIndex;

            if (cbExerciseType.SelectedItem is ComboBoxItem selectedItem)
            {
                string exerciseType = selectedItem.Content.ToString();
                if (exerciseType == "Cardio")
                {
                    double distance = double.Parse(txtDistance.Text);
                    double speed = double.Parse(txtSpeed.Text);
                    CardioExercise newExercise = new CardioExercise(name, duration, intensity, distance, speed);
                    exercises.Add(newExercise);
                    lstExercises.Items.Add(newExercise);
                }
                else if (exerciseType == "Strength")
                {
                    int weight = int.Parse(txtWeight.Text);
                    int reps = int.Parse(txtReps.Text);
                    StrengthExercise newExercise = new StrengthExercise(name, duration, intensity, weight, reps);
                    exercises.Add(newExercise);
                    lstExercises.Items.Add(newExercise);
                }
            }

            // Totale duur bijwerken
            UpdateTotalDuration();
        }

        private void UpdateTotalDuration()
        {
            // sum of all exercise durations
            int totalDuration = exercises.Sum(exercise => exercise.Duration);

            txtTotalDuration.Text = $"Total Duration: {totalDuration} minutes";
        }

        private void cbExerciseType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbExerciseType.SelectedItem is ComboBoxItem selectedItem)
            {
                string exerciseType = selectedItem.Content.ToString();
                if (exerciseType == "Cardio")
                {
                    lblDistance.Visibility = Visibility.Visible;
                    txtDistance.Visibility = Visibility.Visible;
                    lblSpeed.Visibility = Visibility.Visible;
                    txtSpeed.Visibility = Visibility.Visible;

                    lblWeight.Visibility = Visibility.Collapsed;
                    txtWeight.Visibility = Visibility.Collapsed;
                    lblReps.Visibility = Visibility.Collapsed;
                    txtReps.Visibility = Visibility.Collapsed;
                }
                else if (exerciseType == "Strength")
                {
                    lblDistance.Visibility = Visibility.Collapsed;
                    txtDistance.Visibility = Visibility.Collapsed;
                    lblSpeed.Visibility = Visibility.Collapsed;
                    txtSpeed.Visibility = Visibility.Collapsed;

                    lblWeight.Visibility = Visibility.Visible;
                    txtWeight.Visibility = Visibility.Visible;
                    lblReps.Visibility = Visibility.Visible;
                    txtReps.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
