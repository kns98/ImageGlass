﻿/*
ImageGlass Project - Image viewer for Windows
Copyright (C) 2010 - 2022 DUONG DIEU PHAP
Project homepage: https://imageglass.org

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System.Globalization;

namespace ImageGlass.Base;


/// <summary>
/// Constants list of the app
/// </summary>
public static class Constants
{
    public const string UPDATE_CHANNEL = "beta";
    public const int MENU_ICON_HEIGHT = 22;
    public const int VIEWER_GRID_SIZE = 8;
    public const int TOOLBAR_ICON_HEIGHT = 22;
    public const int THUMBNAIL_HEIGHT = 70;
    public const string FILE_MACRO = "<file>";
    public const string CONFIG_CMD_PREFIX = "-";
    public const string DATETIME_FORMAT = "yyyy/MM/dd HH:mm:ss";
    public const string DATE_FORMAT = "yyyy/MM/dd";

    /// <summary>
    /// First launch version constant.
    /// If the value read from config file is less than this value,
    /// the First-Launch Configs screen will be launched.
    /// </summary>
    public const int FIRST_LAUNCH_VERSION = 9;

    /// <summary>
    /// The URI Scheme to register web-to-app linking
    /// </summary>
    public const string URI_SCHEME = "imageglass";

    /// <summary>
    /// The default theme pack
    /// </summary>
    public const string DEFAULT_THEME = "Kobe";

    /// <summary>
    /// Gets built-in image formats
    /// </summary>
    public const string IMAGE_FORMATS = "*.avif;*.b64;*.bmp;*.cur;*.cut;*.dds;*.dib;*.emf;*.exif;*.gif;*.heic;*.heif;*.ico;*.jfif;*.jp2;*.jpe;*.jpeg;*.jpg;*.jxl;*.pbm;*.pcx;*.pgm;*.png;*.ppm;*.psb;*.svg;*.tif;*.tiff;*.webp;*.wmf;*.wpg;*.xbm;*.xpm;*.exr;*.hdr;*.psd;*.tga;*.3fr;*.ari;*.arw;*.bay;*.crw;*.cr2;*.cr3;*.cap;*.dcs;*.dcr;*.dng;*.drf;*.eip;*.erf;*.fff;*.gpr;*.iiq;*.k25;*.kdc;*.mdc;*.mef;*.mos;*.mrw;*.nef;*.nrw;*.obm;*.orf;*.pef;*.ptx;*.pxn;*.qoi;*.r3d;*.raf;*.raw;*.rwl;*.rw2;*.rwz;*.sr2;*.srf;*.srw;*.viff;*.vx;*.x3f";

    /// <summary>
    /// Number format to use for save/restore ImageGlass settings
    /// </summary>
    public static NumberFormatInfo NumberFormat => new()
    {
        NegativeSign = "-",
    };

    /// <summary>
    /// Gets the default set of keycombo actions
    /// </summary>
    public static Dictionary<KeyCombos, AssignableActions> DefaultKeycomboActions => new()
    {
        { KeyCombos.LeftRight, AssignableActions.PrevNextImage },
        { KeyCombos.PageUpDown, AssignableActions.PrevNextImage },
        { KeyCombos.SpaceBack, AssignableActions.PauseSlideshow },
        { KeyCombos.UpDown, AssignableActions.PauseSlideshow }
    };

}