using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Unosquare.FFME.Sample
{
    class EmotionItem
    {
        private Emotion _emotion;
        public Emotion emotion
        {
            get
            {
                return _emotion;
            }
            set
            {
                switch (value)
                {
                    case Emotion.ANGER:
                        emotionImage = (VisualBrush)resourceDictionary["EmotionAngerIcon"];
                        break;
                    case Emotion.CONTEMPT:
                        emotionImage = (VisualBrush)resourceDictionary["EmotionAngerIcon"];
                        break;
                    case Emotion.DISGUST:
                        emotionImage = (VisualBrush)resourceDictionary["EmotionAngerIcon"];
                        break;
                    case Emotion.FEAR:
                        emotionImage = (VisualBrush)resourceDictionary["EmotionAngerIcon"];
                        break;
                    case Emotion.HAPPINESS:
                        emotionImage = (VisualBrush)resourceDictionary["EmotionHapinessIcon"];
                        break;
                    case Emotion.SADNESS:
                        emotionImage = (VisualBrush)resourceDictionary["EmotionSadnessIcon"];
                        break;
                    case Emotion.SURPRISE:
                        emotionImage = (VisualBrush)resourceDictionary["EmotionSurpriseIcon"];
                        break;
                }

                _emotion = value;
            }
        }

        public VisualBrush emotionImage { get; set; }
        private ResourceDictionary resourceDictionary;

        public TimeSpan start
        {
            get; set;
        }

        public TimeSpan end
        {
            get; set;
        }

        public EmotionItem(ResourceDictionary resourceDictionary) { this.resourceDictionary = resourceDictionary; }

        public EmotionItem(Emotion emotion, TimeSpan start, TimeSpan end, ResourceDictionary resourceDictionary)
        {
            this.resourceDictionary = resourceDictionary;
            this.emotion = emotion;
            this.start   = start;
            this.end     = end;
        }

        public String getEmotionName()
        {
            return _emotion.ToString();
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
