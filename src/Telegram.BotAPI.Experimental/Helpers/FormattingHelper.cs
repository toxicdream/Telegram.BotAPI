﻿// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableMethods.FormattingOptions
{
    /// <summary>This class contains a set of useful methods for formatting the text of messages.</summary>
    public class FormattingHelper : FormattingHelper<IStyleParser>
    {
        public FormattingHelper(IStyleParser styleParser) : base(styleParser)
        {
        }
    }
}
