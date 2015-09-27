using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using QuotesApp.Resources;

namespace QuotesApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        private ShellTileSchedule _mySchedule;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            DataPlace dp = new DataPlace();
            dp.Main();
            Application.Current.Host.Settings.EnableFrameRateCounter = false;
            
            //longlist.ItemsSource = dp.d;
            pagename.Text = "Smile :)";
            ScheduleTile();
            ShellTile tile = ShellTile.ActiveTiles.FirstOrDefault();
            if (tile != null)
            {
                FlipTileData flipTile = new FlipTileData();

                flipTile.Title = "Be happy ";
                flipTile.BackTitle = "Enjoy !";

                //Medium size Tile 336x336 px
                flipTile.BackContent = "Be happy for this moment. This moment is your life.";
                flipTile.BackgroundImage = new Uri("/Assets/life_is_happiness.jpg", UriKind.Relative);
                flipTile.BackBackgroundImage = new Uri("/Assets/Degradation-Background.jpg", UriKind.Relative);
                //Wide size Tile 691x336 px
                flipTile.WideBackgroundImage = new Uri("/Assets/hello_have_a_nice_day_1.jpg", UriKind.Relative);
                flipTile.WideBackContent = "A smile is a curve that sets everything straight :)";
                flipTile.WideBackBackgroundImage = new Uri("/Assets/Degradation-Background.jpg", UriKind.Relative);

                //Update Live Tile
                tile.Update(flipTile);
            }




            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

       
        private void ScheduleTile()
        {
            _mySchedule = new ShellTileSchedule();
            _mySchedule.Recurrence = UpdateRecurrence.Onetime;
            _mySchedule.StartTime = DateTime.Now;
            _mySchedule.RemoteImageUri = new
            Uri("http://cdn3.afterdawn.fi/news/small/windows-phone-7-series.png");
            _mySchedule.Start();
        }


        private void show(object sender, RoutedEventArgs e)
        {
            string[] strStrings = { "The harder you work, the harder it is to surrender.", "To climb steep hills requires slow pace at first.", "Be positive, patient and persistent.", "It takes the same amount of energy to worry as it does to be positive. Use your energy to believe.", "The person who says it cannot be done should not interrupt the person doing it.", "When one bases his life on principle, 99 percent of his decisions are already made.", "Our Love is infinite within the Universe as it flows between our souls.", "I am always doing that which I cannot do, in order that I may learn how to do it.", "Ignore those that make you fearful and sad, that degrade you back towards disease and death.", "Now and then it's good to pause in our pursuit of happiness and just be happy.", "The only people with whom you should try to get even are those who have helped you.", "There is no beginning and there is no end to time. There is only your perception of time. ", "It's how you deal with failure that determines how you achieve success.", "Many problems in life are because we either act without thinking, or think without acting.", "Most people would rather be certain they're miserable, than risk being happy.", "It does not matter how slowly you go as long as you do not stop.", "Nobody's a natural. You work hard to get good and then work to get better.", "Goals are not only absolutely necessary to motivate us. They are essential to really keep us alive.", "Life's a party, dress like it.", "The only person you are destined to become is the person you decide to be.", "Your love is like a secret that's been passed around.", "You can't stop the waves, but you can learn how to surf. ", "Accept that your life is going on beyond your usual understanding.", "We shall have no better conditions in the future if we are satisfied with all those which we have at present.", "To know what you do no know is the best. To pretend to know when you do not know is disease.", "Excellence is not a skill. It is an attitude.", "Change your thoughts and you change your world.", "People rarely succeed unless they have fun in what they are doing.", "Success does not consist in never making mistakes but in never making the same one a second time.", "Most people would rather be certain they're miserable, than risk being happy.", "Take a risk take an experience.", "I  don't know what my future holds, but I do know who holds my future.", "Difficult doesn't mean impossible. It simply means that you have to work hard.", "If you see no reason for giving thanks, the fault lies in yourself. ", "Choose being kind over being right and you'll be right every time.", "If you think you are so enlightened go and spend a week with your parents.", "If you go to work on your plan, your plan will go to work on you.", "You have to be absolutely dedicated to the work, you have to give everything of yourself.", "Open your arms to change, but don't let go of your values.", "Train your mind and heart to see the good in everything. There is always something to be grateful for.", "People rarely succeed unless they have fun in what they are doing.", "Only those who dare to fail greatly can ever achieve greatly.", "Life will give you a second chance. It's called 'tomorrow'.", "Patience is not the ability to wait, but how you act while you're waiting.", "You will never find time for anything. If you want the time, you must make it.", "Your mistakes in life do not define you.", "Believe you can do something and you're halfway there.", "Forgive yourself for your faults and your mistakes and move on.", "Nobody remembers the person that gave up.", "The truth is the truth regardless of who believes it.", "Everything has beauty, but not everyone can see it." };
            // Choose a random slogan
            Random RandString = new Random();
            // Display the random slogan
            pagename.Text = strStrings[RandString.Next(0, strStrings.Length)];

        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Check if ExtendedSplashscreen.xaml is on the backstack  and remove 
            if (NavigationService.BackStack.Count() == 1)
            {
                NavigationService.RemoveBackEntry();
            }
        }

    //protected override void OnNavigatedTo(NavigationEventArgs e)
    //    {
    //        string[] strStrings = { "Random string", "Qoute APP", "Randomly selected index" };
    //        // Choose a random slogan
    //        Random RandString = new Random();
    //        // Display the random slogan
    //        pagename.Text = strStrings[RandString.Next(0, strStrings.Length)];
    //// mehs hna b2a 
    //        base.OnNavigatedTo(e);
    //    }
    }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
