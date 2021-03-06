﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeRibbonXEditor.ViewModels.Samples
{
    public class FileSampleViewModel : XmlSampleViewModel
    {
        public override string Name => System.IO.Path.GetFileNameWithoutExtension(this.Path);

        public string Path { get; set; }

        public override string ReadContents()
        {
            try
            {
                return File.ReadAllText(this.Path);
            }
            catch (IOException)
            {
            }
            catch (UnauthorizedAccessException)
            {
            }

            return null;
        }
    }
}
