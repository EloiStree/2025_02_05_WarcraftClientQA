using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientQA.Keyword2Learn
{
    public static partial class KeywordToLearn_Junior_Variable
    {
        #region PRIMITIVE VARIABLE
        public static K2L k_variableInGeneral;
        public static K2L k_variablePrimitive;
        public static K2L k_variableInteger;
        public static K2L k_variableFloat;
        public static K2L k_variableFloatVsDouble;
        public static K2L k_variableIntegerVsLong;
        public static K2L k_variableByteVsShortvsIntvsLong;
        public static K2L k_variableSignedVsUnsignedVariable;
        public static K2L k_variableWordVar;
        #endregion

        #region VARIABLE PARSING
        public static K2L k_castDoubleInFloat;
        public static K2L K_castLongInInteger;
        public static K2L K_castIntegerInByteAndShort;
        #endregion

        #region VARIABLE CASTING

        #endregion
    }


    public abstract class K2L : AbstractKeywordWithExampleToLearn { }
    public abstract class AbstractKeywordWithExampleToLearn
    {

        public KeywordPoint m_learningState;
        public abstract void GetUrlToLearnMoreAboutIt();
        public abstract void GetChampionCodeExample(ChampionThread champion);
    }

    /// <summary>
    /// This class represent your current score in this workshop.
    /// - To learn: You don't know it yet
    /// - Saw: You remember sawing it.
    /// - Learning: You are learning it currently
    /// - NeedReview: You learned it a bit but you are stuck and need help.
    /// - Learned: You think you understand what it does
    /// - UsedInTheCode: You are using it a useful way in this project
    /// - Master: You can explained it to a junior without to mush doupt
    /// 
    /// If you are in my workshop, don't cheat on the enum use.
    /// - N points if you are overestimating it . 
    /// </summary>
    public enum KeywordPoint
    {
        ToLearn = -1,
        Saw=0,
        Learning = 1,
        NeedReview = 2,
        Learned = 3,
        UsedInTheCode = 4,
        Mastered = 5
    }
}

