using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringDemo
{
    public class MainViewModel 
    {
        #region Properties
        public ObservableCollection<TaskInfo> Items { get; set; }

        #endregion

        #region Constructor
        public MainViewModel()
        {
            AddItemDetails();
        }
        #endregion

        #region Methods
        public void AddItemDetails()
        {
            Items = new ObservableCollection<TaskInfo>();
            var random = new Random();

            for (int i = 0; i < Features.Count(); i++)
            {
                var details = new TaskInfo()
                {
                    Title = Features[i],
                    Description = DescriptionList[i],
                    Tag = Tags[random.Next(0, 4)],
                };
                Items.Add(details);
            }

        }
        #endregion

        #region Field

        string[] Tags = new string[]
        {
            "Feature Implementation",
            "Bug Fixing",
            "Testing",
            "Design",
            "Post Processing"
        };

        string[] Features = new string[]
        {
            "Drag and drop",
            "Swiping",
            "Pull To Refresh",
            "Selection in row header",
            "Multiple selection color",
            "Animating the selected row",
            "Long press event",

        };

        string[] DescriptionList = new string[] {
            "Rearrange the columns by dragging and dropping them",
            "Enables the users to swipe",
            "Pull To Refresh action refreshes the grid",
            "Apply selection using row header",
            "Apply different selection colors for different rows",
            "Add an animation upon selecting a row",
            "Users can listen to LongPresses in the listview",

        };
        #endregion
    }
}
