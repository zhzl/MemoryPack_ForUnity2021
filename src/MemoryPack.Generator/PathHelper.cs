namespace MemoryPack.Generator
{
    public static class PathHelper
    {
        /// <summary>
        /// 代码生成路径
        /// </summary>
        public static string GeneratedPath(string sourceFilePath)
        {
            string generatedPath = Path.GetDirectoryName(sourceFilePath);
            generatedPath = Path.Combine(generatedPath, "MemPack_Gen");
            if (!Directory.Exists(generatedPath))
            {
                Directory.CreateDirectory(generatedPath);
            }
            return generatedPath;
        }

        /// <summary>
        /// 获取包含Packages和ProjectSettings同级目录的Assets路径
        /// </summary>
        /// <param name="filePath">文件完整路径</param>
        /// <returns>Assets目录路径（未找到则返回null）</returns>
        public static string GetAssetDirectory(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return null;

            string currentDir = Path.GetDirectoryName(filePath);

            while (currentDir != null)
            {
                // 检查当前目录是否同时包含Assets、Packages、ProjectSettings三个子目录
                string assetsDir = Path.Combine(currentDir, "Assets");
                string packagesDir = Path.Combine(currentDir, "Packages");
                string projectSettingsDir = Path.Combine(currentDir, "ProjectSettings");

                if (Directory.Exists(assetsDir) &&
                    Directory.Exists(packagesDir) &&
                    Directory.Exists(projectSettingsDir))
                {
                    return assetsDir;
                }

                currentDir = Path.GetDirectoryName(currentDir);
            }

            return null;
        }
    }
}
