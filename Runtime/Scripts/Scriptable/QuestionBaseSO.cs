using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ezygamers.cmsv1
{
 [CreateAssetMenu(fileName ="Question Base",menuName ="Create QuestionBase")]
    public class QuestionBaseSO:ScriptableObject
    {
        public int questionNo;
        
        [Header("Question Content")]
        public TextContent questionText; //ul
        public TextContent hindiText;  //kl
        public ImageContent questionImage; //single learning image
        public AudioContent questionAudio; //audio

        //[Header("English Option Data")]
        //public List<TextOption> englishWordsOptions = new List<TextOption>();

        //[Header("Hindi Option Data")]
        //public List<TextOption> hindiWordsOption = new List<TextOption>();
        [Header("Image Option Data")]
        public List<ImageOption> imageOptions = new List<ImageOption>(); //images for questions
        //[Header("Audio Option Data")]
        //public List<AudioOption>audioOptions=new List<AudioOption>();
       
        [Header("Correct Answer")]
        public int correctAnswerIndex; //correct image index in imageOptions List

        [Header("Content Type")]
        public ContentType contentType;
        public DifficultyLevel difficultyLevel;

    }

    public enum ContentType
    {
        Learning,
        QType1,
        QType2,
        QType3

    }
    public enum DifficultyLevel {
        Easy,
        Medium,
        Hard
    
    }

}
