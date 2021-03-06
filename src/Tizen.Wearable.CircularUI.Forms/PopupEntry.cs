﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Tizen.Wearable.CircularUI.Forms
{
    /// <summary>
    /// The PopupEntry is a class that extends Xamarin.Forms.Entry.
    /// It makes a new layer when editing text on the entry.
    /// </summary>
    /// <since_tizen> 4 </since_tizen>
    public class PopupEntry : Entry
    {
        /// <summary>
        /// BindableProperty. Identifies color of Popup background.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty PopupBackgroundColorProperty = BindableProperty.CreateAttached(nameof(PopupBackgroundColor), typeof(Color), typeof(PopupEntry), Color.Default);

        /// <summary>
        /// BindableProperty. Identifies whether Popup is opended or not.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public static readonly BindableProperty IsPopupOpenedProperty = BindableProperty.CreateAttached(nameof(IsPopupOpened), typeof(bool), typeof(PopupEntry), false);

        /// <summary>
        /// Gets or sets a color value of Popup.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public Color PopupBackgroundColor
        {
            get => (Color)GetValue(PopupBackgroundColorProperty);
            set => SetValue(PopupBackgroundColorProperty, value);
        }

        /// <summary>
        /// Gets or sets a status of Popup's open.
        /// </summary>
        /// <since_tizen> 4 </since_tizen>
        public bool IsPopupOpened
        {
            get => (bool)GetValue(IsPopupOpenedProperty);
            set => SetValue(IsPopupOpenedProperty, value);
        }
    }
}
