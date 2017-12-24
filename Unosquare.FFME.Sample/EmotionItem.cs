using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unosquare.FFME.Sample
{
    class EmotionItem : INotifyPropertyChanged
    {
        public Emotion emotion
        {
            get; set;
        }

        public TimeSpan start
        {
            get; set;
        }

        public TimeSpan end
        {
            get; set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

     

        public EmotionItem() { }

        public EmotionItem(Emotion emotion, TimeSpan start, TimeSpan end)
        {
            this.emotion = emotion;
            this.start   = start;
            this.end     = end;
        }

        public String getEmotionName()
        {
            return emotion.ToString();
        }
    }

    public enum Emotion
    {
        ANGER,
        CONTEMPT,
        DISGUST,
        FEAR,
        HAPPINESS,
        SADNESS,
        SURPRISE
    }
}
