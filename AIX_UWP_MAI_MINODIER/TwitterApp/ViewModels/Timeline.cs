using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterApp.Models;
using Windows.Storage;

namespace TwitterApp.ViewModels
{
    public class Timeline
    {
        public ObservableCollection<Tweet> TweetList { get; set; }

        public Timeline()
        {
            this.TweetList = new ObservableCollection<Tweet>();
        }

        public async void loadTimeline()
        {

            //StorageFolder localFolder = ApplicationData.Current.LocalFolder;

            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(@"ms-appx:///Data/home.json"));
            String json = await FileIO.ReadTextAsync(file);

            this.TweetList = JsonConvert.DeserializeObject<ObservableCollection<Tweet>>(json);





            /*string json = (string)localSettings.Values["json"];
            if (json != null)
            {
                this.TaskList = JsonConvert.DeserializeObject<ObservableCollection<Task>>(json);
            }*/
        }
    }
}
