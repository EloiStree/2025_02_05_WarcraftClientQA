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
    public class WowPathAndPointsFileUtility {
        public WowPathAndPointsFileUtility()
        {
        }

        public static void GetFilesFromFolder(string absolutePathFolder,
            out string[] wowPathFile,
            out string[] wowPointFile
            )
        {
            GetWowPathsFromFolder(absolutePathFolder,
                out wowPathFile);
            GetWowXpPointsFromFolder(absolutePathFolder,
                out wowPointFile);
        }
        public static void GetWowPathsFromFolder(string absolutePathFolder,
    out string[] wowPathFile
    )
        {
            wowPathFile = System.IO.Directory.GetFiles(absolutePathFolder, "*.wowpath", SearchOption.AllDirectories);
        }
        public static void GetWowXpPointsFromFolder(string absolutePathFolder,
            out string[] wowPointFile
            )
        {
            wowPointFile = System.IO.Directory.GetFiles(absolutePathFolder, "*.wowxpoint", SearchOption.AllDirectories);
        }


        public void GetPointsFromFile(string absolutePathFile,
            out List<WowPointsPathFile> paths,
            out List<WowXpPointFile> xpPoints)
        {
            GetFilesFromFolder(absolutePathFile,
                out string[] wowPathFile,
                out string[] wowPointFile);

            paths = new List<WowPointsPathFile>();
            xpPoints = new List<WowXpPointFile>();

            foreach (string pathFile in wowPathFile)
            {
                paths.Add(new WowPointsPathFile(pathFile));
            }
            foreach (string pathFile in wowPointFile)
            {
                xpPoints.Add(new WowXpPointFile(pathFile));
            }

        }
        public void GetPointsFromFile(string absolutePathFile,
            out List<WowXpPointFile> xpPoints)
        {
            GetFilesFromFolder(absolutePathFile,
                out string[] wowPathFile,
                out string[] wowPointFile);

            xpPoints = new List<WowXpPointFile>();

            foreach (string pathFile in wowPointFile)
            {
                xpPoints.Add(new WowXpPointFile(pathFile));
            }

        }
    }
}
