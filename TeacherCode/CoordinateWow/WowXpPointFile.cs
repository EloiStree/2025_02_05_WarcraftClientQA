// To learn Reserver Keywords in C#
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/354

// To learn Char in QWERTY keyboard and UTF8
// https://github.com/EloiStree/HelloSharpForUnity3D/issues/557


// Keyword: identation https://github.com/EloiStree/HelloSharpForUnity3D/issues/411

// Keyword: using https://github.com/EloiStree/HelloSharpForUnity3D/issues/281
// Keyword: System  https://github.com/EloiStree/HelloSharpForUnity3D/issues/545


// Keyword: Generic https://github.com/EloiStree/HelloSharpForUnity3D/issues/84

// Keyword: Linq https://github.com/EloiStree/HelloSharpForUnity3D/issues/223
using ClientQA.TeacherCode.CoordinateWow;

// Keyword: namespace https://github.com/EloiStree/HelloSharpForUnity3D/issues/90
namespace Eloi.Toolbox
{
    public class WowXpPointFile {

        public string m_fileNameAlias;
        public string m_fileNameExtension;
        public string m_fileFullPath;
        public WowWorldPosition[] m_positions = new WowWorldPosition[] { };
        public WowXpPointFile(string absolutePath)
        {
            m_fileFullPath = absolutePath;
            m_fileNameAlias = System.IO.Path.GetFileNameWithoutExtension(absolutePath);
            m_fileNameExtension = System.IO.Path.GetExtension(absolutePath);
            WowWorldPositionUtility.LoadFromFileWorldPoints(absolutePath,
                out List<WowWorldPosition> positions);
            m_positions = positions.ToArray();
        }
    }
}
