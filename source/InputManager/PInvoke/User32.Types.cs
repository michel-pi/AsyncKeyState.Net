﻿using System;
using System.Runtime.InteropServices;

namespace InputManager.PInvoke
{
	[Flags]
	internal enum NativeKeyboardEventFlags : uint
	{
		Down = 0,
		ExtendedKey = 0x1,
		Up = 0x2,
		Scancode = 0x0008,
		Unicode = 0x0004
	}

	[Flags]
	internal enum NativeMouseEventFlags : uint
	{
		None = 0,
		Move = 0x0001,
		LeftDown = 0x0002,
		LeftUp = 0x0004,
		RightDown = 0x0008,
		RightUp = 0x0010,
		MiddleDown = 0x0020,
		MiddleUp = 0x0040,
		XDown = 0x0080,
		XUp = 0x0100,
		Wheel = 0x0800,
		HorizontalWheel = 0x01000,
		MoveNoCoalesce = 0x2000,
		VirtualDesk = 0x4000,
		Absolute = 0x8000
	}

	internal enum NativeInputType : uint
	{
		Mouse = 0,
		Keyboard = 0x1,
		Hardware = 0x2
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct NativeMouseInput
	{
		public static readonly int Size = Marshal.SizeOf<NativeMouseInput>();

		public int X;
		public int Y;

		public uint MouseData;
		public NativeMouseEventFlags Flags;
		public uint Time;

		public IntPtr ExtraInfo;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct NativeKeyboardInput
	{
		public static readonly int Size = Marshal.SizeOf<NativeKeyboardInput>();

		public ushort Key;
		public ushort Scancode;

		public NativeKeyboardEventFlags Flags;
		public uint Time;

		public IntPtr ExtraInfo;
	}

	[StructLayout(LayoutKind.Explicit)]
	internal struct NativeInputEvent
	{
		public static readonly int Size = Marshal.SizeOf<NativeInputEvent>();

		[FieldOffset(0)] public NativeInputType Type;

		[FieldOffset(4)] public NativeMouseInput MouseInput;
		[FieldOffset(4)] public NativeKeyboardInput KeyboardInput;
	}

	internal enum WindowMessage : uint
	{
		Null = 0x0000,
		Create = 0x0001,
		Destroy = 0x0002,
		Move = 0x0003,
		Size = 0x0005,
		Activate = 0x0006,
		Setfocus = 0x0007,
		Killfocus = 0x0008,
		Enable = 0x000A,
		Setredraw = 0x000B,
		Settext = 0x000C,
		Gettext = 0x000D,
		Gettextlength = 0x000E,
		Paint = 0x000F,
		Close = 0x0010,
		Queryendsession = 0x0011,
		Quit = 0x0012,
		Queryopen = 0x0013,
		EraseBackground = 0x0014,
		Syscolorchange = 0x0015,
		Endsession = 0x0016,
		Showwindow = 0x0018,
		Wininichange = 0x001A,
		Settingchange = Wininichange,
		Devmodechange = 0x001B,
		Activateapp = 0x001C,
		Fontchange = 0x001D,
		Timechange = 0x001E,
		Cancelmode = 0x001F,
		Setcursor = 0x0020,
		Mouseactivate = 0x0021,
		Childactivate = 0x0022,
		Queuesync = 0x0023,
		Getminmaxinfo = 0x0024,
		Painticon = 0x0026,
		Iconerasebkgnd = 0x0027,
		Nextdlgctl = 0x0028,
		Spoolerstatus = 0x002A,
		Drawitem = 0x002B,
		Measureitem = 0x002C,
		Deleteitem = 0x002D,
		Vkeytoitem = 0x002E,
		Chartoitem = 0x002F,
		Setfont = 0x0030,
		Getfont = 0x0031,
		Sethotkey = 0x0032,
		Gethotkey = 0x0033,
		Querydragicon = 0x0037,
		Compareitem = 0x0039,
		Getobject = 0x003D,
		Compacting = 0x0041,
		Commnotify = 0x0044,
		Windowposchanging = 0x0046,
		Windowposchanged = 0x0047,
		Power = 0x0048,
		Copydata = 0x004A,
		Canceljournal = 0x004B,
		Notify = 0x004E,
		Inputlangchangerequest = 0x0050,
		Inputlangchange = 0x0051,
		Tcard = 0x0052,
		Help = 0x0053,
		Userchanged = 0x0054,
		Notifyformat = 0x0055,
		Contextmenu = 0x007B,
		Stylechanging = 0x007C,
		Stylechanged = 0x007D,
		Displaychange = 0x007E,
		Geticon = 0x007F,
		Seticon = 0x0080,
		Nccreate = 0x0081,
		Ncdestroy = 0x0082,
		Nccalcsize = 0x0083,
		Nchittest = 0x0084,
		NcPaint = 0x0085,
		Ncactivate = 0x0086,
		Getdlgcode = 0x0087,
		Syncpaint = 0x0088,
		Ncmousemove = 0x00A0,
		Nclbuttondown = 0x00A1,
		Nclbuttonup = 0x00A2,
		Nclbuttondblclk = 0x00A3,
		Ncrbuttondown = 0x00A4,
		Ncrbuttonup = 0x00A5,
		Ncrbuttondblclk = 0x00A6,
		Ncmbuttondown = 0x00A7,
		Ncmbuttonup = 0x00A8,
		Ncmbuttondblclk = 0x00A9,
		Ncxbuttondown = 0x00AB,
		Ncxbuttonup = 0x00AC,
		Ncxbuttondblclk = 0x00AD,
		InputDeviceChange = 0x00FE,
		Input = 0x00FF,
		Keyfirst = 0x0100,
		Keydown = 0x0100,
		Keyup = 0x0101,
		Char = 0x0102,
		Deadchar = 0x0103,
		Syskeydown = 0x0104,
		Syskeyup = 0x0105,
		Syschar = 0x0106,
		Sysdeadchar = 0x0107,
		Unichar = 0x0109,
		Keylast = 0x0109,
		ImeStartcomposition = 0x010D,
		ImeEndcomposition = 0x010E,
		ImeComposition = 0x010F,
		ImeKeylast = 0x010F,
		Initdialog = 0x0110,
		Command = 0x0111,
		Syscommand = 0x0112,
		Timer = 0x0113,
		Hscroll = 0x0114,
		Vscroll = 0x0115,
		Initmenu = 0x0116,
		Initmenupopup = 0x0117,
		Menuselect = 0x011F,
		Menuchar = 0x0120,
		Enteridle = 0x0121,
		Menurbuttonup = 0x0122,
		Menudrag = 0x0123,
		Menugetobject = 0x0124,
		Uninitmenupopup = 0x0125,
		Menucommand = 0x0126,
		Changeuistate = 0x0127,
		Updateuistate = 0x0128,
		Queryuistate = 0x0129,
		Ctlcolormsgbox = 0x0132,
		Ctlcoloredit = 0x0133,
		Ctlcolorlistbox = 0x0134,
		Ctlcolorbtn = 0x0135,
		Ctlcolordlg = 0x0136,
		Ctlcolorscrollbar = 0x0137,
		Ctlcolorstatic = 0x0138,
		Gethmenu = 0x01E1,
		Mousefirst = 0x0200,
		Mousemove = 0x0200,
		Lbuttondown = 0x0201,
		Lbuttonup = 0x0202,
		Lbuttondblclk = 0x0203,
		Rbuttondown = 0x0204,
		Rbuttonup = 0x0205,
		Rbuttondblclk = 0x0206,
		Mbuttondown = 0x0207,
		Mbuttonup = 0x0208,
		Mbuttondblclk = 0x0209,
		Mousewheel = 0x020A,
		Xbuttondown = 0x020B,
		Xbuttonup = 0x020C,
		Xbuttondblclk = 0x020D,
		Mousehwheel = 0x020E,
		Parentnotify = 0x0210,
		Entermenuloop = 0x0211,
		Exitmenuloop = 0x0212,
		Nextmenu = 0x0213,
		Sizing = 0x0214,
		Capturechanged = 0x0215,
		Moving = 0x0216,
		Powerbroadcast = 0x0218,
		Devicechange = 0x0219,
		Mdicreate = 0x0220,
		Mdidestroy = 0x0221,
		Mdiactivate = 0x0222,
		Mdirestore = 0x0223,
		Mdinext = 0x0224,
		Mdimaximize = 0x0225,
		Mditile = 0x0226,
		Mdicascade = 0x0227,
		Mdiiconarrange = 0x0228,
		Mdigetactive = 0x0229,
		Mdisetmenu = 0x0230,
		Entersizemove = 0x0231,
		Exitsizemove = 0x0232,
		Dropfiles = 0x0233,
		Mdirefreshmenu = 0x0234,
		ImeSetcontext = 0x0281,
		ImeNotify = 0x0282,
		ImeControl = 0x0283,
		ImeCompositionfull = 0x0284,
		ImeSelect = 0x0285,
		ImeChar = 0x0286,
		ImeRequest = 0x0288,
		ImeKeydown = 0x0290,
		ImeKeyup = 0x0291,
		Ncmousehover = 0x02A0,
		Mousehover = 0x02A1,
		Ncmouseleave = 0x02A2,
		Mouseleave = 0x02A3,
		WtssessionChange = 0x02B1,
		TabletFirst = 0x02c0,
		TabletLast = 0x02df,
		DpiChanged = 0x02E0,
		Cut = 0x0300,
		Copy = 0x0301,
		Paste = 0x0302,
		Clear = 0x0303,
		Undo = 0x0304,
		Renderformat = 0x0305,
		Renderallformats = 0x0306,
		Destroyclipboard = 0x0307,
		Drawclipboard = 0x0308,
		Paintclipboard = 0x0309,
		Vscrollclipboard = 0x030A,
		Sizeclipboard = 0x030B,
		Askcbformatname = 0x030C,
		Changecbchain = 0x030D,
		Hscrollclipboard = 0x030E,
		Querynewpalette = 0x030F,
		Paletteischanging = 0x0310,
		Palettechanged = 0x0311,
		Hotkey = 0x0312,
		Print = 0x0317,
		Printclient = 0x0318,
		Appcommand = 0x0319,
		Themechanged = 0x031A,
		Clipboardupdate = 0x031D,
		DwmCompositionChanged = 0x031E,
		Dwmncrenderingchanged = 0x031F,
		Dwmcolorizationcolorchanged = 0x0320,
		Dwmwindowmaximizedchange = 0x0321,
		Gettitlebarinfoex = 0x033F,
		Handheldfirst = 0x0358,
		Handheldlast = 0x035F,
		Afxfirst = 0x0360,
		Afxlast = 0x037F,
		Penwinfirst = 0x0380,
		Penwinlast = 0x038F,
		User = 0x0400,
		Reflect = User + 0x1C00,
		App = 0x8000
	}
}
