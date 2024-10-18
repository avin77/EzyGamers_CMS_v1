using UnityEngine;
namespace ezygamers.cmsv1
{
    [System.Serializable]
    public class AnswerContent
    {
        public Object content;  // Using UnityEngine.Object to accept any Unity object
        public string answerType;  // String to specify the type ("Image" or "Text")

        public AnswerContent(Object content, string type)
        {
            this.content = content;
            this.answerType = type;
        }

        // Helper method to get content as specific type
        public T GetContent<T>() where T : Object
        {
            return content as T;
        }
    }
}