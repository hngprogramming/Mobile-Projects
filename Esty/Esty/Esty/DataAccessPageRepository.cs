using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Esty
{
    class DataAccessPageRepository : ContentPage
    {
        public DataAccessPageRepository()
        {
            var label = new Label { Text = "Database Created Using SQLite.NET\n" };

            label.Text += " Using an Advanced Repository\n\n";

            App.Repository.DeleteAllPeriods(); // clear out the table to start fresh

            var Period = new Period { Name = "Every Day", Hour = "This is the first Period" };
            App.Repository.SavePeriod(Period);

            var id = 1;
            Period = App.Repository.GetPeriod(id);
            label.Text += Period.Name + " Period at ID " + id.ToString() + "\n\n";

            App.Repository.DeletePeriod(id);
            label.Text += "Deleted Period at ID " + id.ToString() + "\n\n";

            Period = new Period { Name = "First", Hour = "This is the first Period" };
            App.Repository.SavePeriod(Period);
            Period = new Period { Name = "Second", Hour = "This is the second Period" };
            App.Repository.SavePeriod(Period);
            Period = new Period { Name = "Third", Hour = "This is the furd Period" };
            App.Repository.SavePeriod(Period);

            var Periods = App.Repository.GetPeriods();
            foreach (var i in Periods)
            {
                label.Text += i.Name + ": " + i.Hour + "\n";
            }

            label.Text += "\n Oops, I meant: ";

            Period.Hour = "This is the third Period";
            App.Repository.SavePeriod(Period);

            id = 4;
            Period = App.Repository.GetPeriod(id);
            label.Text += Period.Name + ": " + Period.Hour + "\n";

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            Content = new StackLayout
            {
                Children = {
                    label
                }
            };
        }
    }
}
