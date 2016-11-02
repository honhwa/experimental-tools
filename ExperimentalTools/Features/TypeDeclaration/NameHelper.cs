﻿using System.IO;

namespace ExperimentalTools.Features.TypeDeclaration
{
    internal static class NameHelper
    {
        public static string RemoveExtension(string documentName) => Path.GetFileNameWithoutExtension(documentName);

        public static string AddExtension(string documentName) => $"{documentName}.cs";
    }
}
