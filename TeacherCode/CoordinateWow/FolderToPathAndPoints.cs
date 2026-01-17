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
    public class FolderToPathAndPoints
    {
        public List<WowPointsPathFile> m_pathOfPoints = new List<WowPointsPathFile>();
        public List<WowXpPointFile> m_groupOfXpPoints = new List<WowXpPointFile>();

        public FolderToPathAndPoints(string absolutePath)
        {
            string[] wowPathFile;
            string[] wowPointFile;
            WowPathAndPointsFileUtility.GetFilesFromFolder(absolutePath,
                out wowPathFile,
                out wowPointFile);
            foreach (string pathFile in wowPathFile)
            {
                m_pathOfPoints.Add(new WowPointsPathFile(pathFile));
            }
            foreach (string pathFile in wowPointFile)
            {
                m_groupOfXpPoints.Add(new WowXpPointFile(pathFile));
            }
        }

        public void GetWowXpPointsFromExactAlias(string alias,
            out List<WowXpPointFile> xpPoints)
        {
            xpPoints = new List<WowXpPointFile>();
            foreach (WowXpPointFile path in m_groupOfXpPoints)
            {
                if (path.m_fileNameAlias == alias)
                {
                    xpPoints.Add(path);
                }
            }
        }
        public void GetWowPathPointsFromExactAlias(string alias,
            out List<WowPointsPathFile> path)
        {
            path = new List<WowPointsPathFile>();
            foreach (WowPointsPathFile pathFile in m_pathOfPoints)
            {
                if (pathFile.m_fileNameAlias == alias)
                {
                    path.Add(pathFile);
                }
            }
        }

        public void GetAlias(out List<string> alias)
        {
            alias = new List<string>();
            foreach (WowPointsPathFile path in m_pathOfPoints)
            {
                alias.Add(path.m_fileNameAlias);
            }
            foreach (WowXpPointFile path in m_groupOfXpPoints)
            {
                alias.Add(path.m_fileNameAlias);
            }

        }
    }



}
