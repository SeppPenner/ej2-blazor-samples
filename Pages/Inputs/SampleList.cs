﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> TextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "TextBox",
                Directory = "Inputs/TextBox",
                Url = "TextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            }
        };

        public List<Sample> ColorPicker { get; set; } = new List<Sample>
        {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Inline Mode",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Inline",
                FileName = "Inline.razor"
            },
            new Sample
            {
                Name = "Custom Palettes",
                Category = "ColorPicker",
                Directory = "Inputs/ColorPicker",
                Url = "ColorPicker/Custom",
                FileName = "Custom.razor"
            }
        };

        public List<Sample> MaskedTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
            {
                Name = "Custom Mask",
                Category = "MaskedTextBox",
                Directory = "Inputs/MaskedTextBox",
                Url = "MaskedTextBox/CustomMask",
                FileName = "CustomMask.razor"
            }
        };

        public List<Sample> NumericTextBox { get; set; } = new List<Sample> {
            new Sample
            {
                Name = "Default Functionalities",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
            new Sample
            {
                Name = "Custom Format",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/CustomFormat",
                FileName = "CustomFormat.razor"
            },
            new Sample
            {
                Name = "Restrict Decimals",
                Category = "NumericTextBox",
                Directory = "Inputs/NumericTextBox",
                Url = "NumericTextBox/RestrictDecimals",
                FileName = "RestrictDecimals.razor"
            }
        };
        public List<Sample> FileUpload { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.razor"
            },
             new Sample
            {
                Name = "Chunk Upload",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/ChunkUpload",
                FileName = "ChunkUpload.razor"
            },
               new Sample
            {
                Name = "Preload Files",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/PreloadFiles",
                FileName = "PreloadFiles.razor"
            },
               new Sample
            {
                Name = "File Validation",
                Category = "FileUpload",
                Directory = "Inputs/Uploader",
                Url = "Uploader/FileValidation",
                FileName = "FileValidation.razor"
            }
        };
        public List<Sample> Slider { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Default",
                FileName = "Default.razor"
            },
            new Sample
            {
                Name = "Ticks",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Ticks",
                FileName = "Ticks.razor"
            },
            new Sample
            {
                Name = "Tooltip",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Tooltip",
                FileName = "Tooltip.razor"
            },
            new Sample
            {
                Name = "Limits",
                Category = "Slider",
                Directory = "Inputs/Slider",
                Url = "Slider/Limits",
                FileName = "Limits.razor"
            },
        };
    }

   


}
