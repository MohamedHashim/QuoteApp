using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp
{
  public  class DataSource
    {
        public int ID { get; set; }
        public String  Text { get; set; }
      public DataSource (int _Id ,string _Text)
        {
            this.ID = _Id;
            this.Text = _Text;
        }
    }
    public class DataPlace
    {
        public List<DataSource> d = new List<DataSource>();
        public void Main()
        {
            d.Add(new DataSource(0,"Advice"));
        }
        public void quotes()
        {
            d.Add(new DataSource(0, "The harder you work, the harder it is to surrender."));
            d.Add(new DataSource(1, "To climb steep hills requires slow pace at first."));
            d.Add(new DataSource(2, "Be positive, patient and persistent."));
            d.Add(new DataSource(3, "It takes the same amount of energy to worry as it does to be positive. Use your energy to believe."));
            d.Add(new DataSource(4, "The person who says it cannot be done should not interrupt the person doing it."));
            d.Add(new DataSource(5, "When one bases his life on principle, 99 percent of his decisions are already made."));
            d.Add(new DataSource(6, "Our Love is infinite within the Universe as it flows between our souls."));
            d.Add(new DataSource(7, "I am always doing that which I cannot do, in order that I may learn how to do it."));
            d.Add(new DataSource(8, "Ignore those that make you fearful and sad, that degrade you back towards disease and death."));
            d.Add(new DataSource(9, "Now and then it's good to pause in our pursuit of happiness and just be happy."));
            d.Add(new DataSource(10, "The only people with whom you should try to get even are those who have helped you."));
            d.Add(new DataSource(11, "There is no beginning and there is no end to time. There is only your perception of time. "));
            d.Add(new DataSource(12, "It's how you deal with failure that determines how you achieve success."));
            d.Add(new DataSource(13, "Many problems in life are because we either act without thinking, or think without acting."));
            d.Add(new DataSource(14, "Most people would rather be certain they're miserable, than risk being happy."));
            d.Add(new DataSource(15, "It does not matter how slowly you go as long as you do not stop."));
            d.Add(new DataSource(16, "Nobody's a natural. You work hard to get good and then work to get better."));
            d.Add(new DataSource(17, "Goals are not only absolutely necessary to motivate us. They are essential to really keep us alive."));
            d.Add(new DataSource(18, "Life's a party, dress like it."));
            d.Add(new DataSource(19, "The only person you are destined to become is the person you decide to be."));
            d.Add(new DataSource(20, "Your love is like a secret that's been passed around."));
            d.Add(new DataSource(21, "You can't stop the waves, but you can learn how to surf. "));
            d.Add(new DataSource(22, "Accept that your life is going on beyond your usual understanding."));
            d.Add(new DataSource(23, "We shall have no better conditions in the future if we are satisfied with all those which we have at present."));
            d.Add(new DataSource(24, "To know what you do no know is the best. To pretend to know when you do not know is disease."));
            d.Add(new DataSource(25, "Excellence is not a skill. It is an attitude."));
            d.Add(new DataSource(26, "Change your thoughts and you change your world."));
            d.Add(new DataSource(27, "People rarely succeed unless they have fun in what they are doing."));
            d.Add(new DataSource(28, "Success does not consist in never making mistakes but in never making the same one a second time."));
            d.Add(new DataSource(29, "Most people would rather be certain they're miserable, than risk being happy."));
            d.Add(new DataSource(30, "Take a risk take an experience."));
            d.Add(new DataSource(31, "I  don't know what my future holds, but I do know who holds my future."));
            d.Add(new DataSource(32, "Difficult doesn't mean impossible. It simply means that you have to work hard."));
            d.Add(new DataSource(33, "If you see no reason for giving thanks, the fault lies in yourself. "));
            d.Add(new DataSource(34, "Choose being kind over being right and you'll be right every time."));
            d.Add(new DataSource(35, "If you think you are so enlightened go and spend a week with your parents."));
            d.Add(new DataSource(36, "If you go to work on your plan, your plan will go to work on you."));
            d.Add(new DataSource(37, "You have to be absolutely dedicated to the work, you have to give everything of yourself."));
            d.Add(new DataSource(38, "Open your arms to change, but don't let go of your values."));
            d.Add(new DataSource(39, "Train your mind and heart to see the good in everything. There is always something to be grateful for."));
            d.Add(new DataSource(40, "People rarely succeed unless they have fun in what they are doing."));
            d.Add(new DataSource(41, "Only those who dare to fail greatly can ever achieve greatly."));
            d.Add(new DataSource(42, "Life will give you a second chance. It's called 'tomorrow'."));
            d.Add(new DataSource(43, "Patience is not the ability to wait, but how you act while you're waiting."));
            d.Add(new DataSource(44, "You will never find time for anything. If you want the time, you must make it."));
            d.Add(new DataSource(45, "Your mistakes in life do not define you."));
            d.Add(new DataSource(46, "Believe you can do something and you're halfway there."));
            d.Add(new DataSource(47, "Forgive yourself for your faults and your mistakes and move on."));
            d.Add(new DataSource(48, "Nobody remembers the person that gave up."));
            d.Add(new DataSource(49, "The truth is the truth regardless of who believes it."));
            d.Add(new DataSource(50, "Everything has beauty, but not everyone can see it."));
            
        }
    }
}
