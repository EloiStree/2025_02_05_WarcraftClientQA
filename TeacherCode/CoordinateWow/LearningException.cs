// To learn Reserver Keywords in C#
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/354

// To learn Char in QWERTY keyboard and UTF8
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/557


// Keyword: identation https://github.com/EloiStree/HelloSharpForUnity3D/issues/411

// Keyword: using https://github.com/EloiStree/HelloSharpForUnity3D/issues/281
// Keyword: System  https://github.com/EloiStree/HelloSharpForUnity3D/issues/545


// Keyword: Generic https://github.com/EloiStree/HelloSharpForUnity3D/issues/84

// Keyword: Linq https://github.com/EloiStree/HelloSharpForUnity3D/issues/223
// Keyword: namespace https://github.com/EloiStree/HelloSharpForUnity3D/issues/90
namespace Eloi.Toolbox
{
    // Keyword: NotImplementedException 
    // Keyword: Exception 
    public class LearningException : System.NotImplementedException
    {


        // Keyword: @ https://github.com/EloiStree/HelloSharpForUnity3D/issues/405
        // Keyword: $ https://github.com/EloiStree/HelloSharpForUnity3D/issues/522
        // Keyword: $@ https://github.com/EloiStree/HelloSharpForUnity3D/issues/556
        public LearningException(string whatToCode, string urlToLearn) : base($@"
        You did not code it yets ;).
What to code : {whatToCode}
Learn what to code: {urlToLearn}
        ")
        {
        }
    }
}
