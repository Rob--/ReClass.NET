﻿using System.Runtime.InteropServices;

namespace ReClassNET.Nodes
{
	class Matrix3x3Node : BaseMatrixNode
	{
		[StructLayout(LayoutKind.Explicit)]
		struct Matrix3x3Data
		{
			[FieldOffset(0)]
			public float _11;
			[FieldOffset(4)]
			public float _12;
			[FieldOffset(8)]
			public float _13;
			[FieldOffset(12)]
			public float _21;
			[FieldOffset(16)]
			public float _22;
			[FieldOffset(20)]
			public float _23;
			[FieldOffset(24)]
			public float _31;
			[FieldOffset(28)]
			public float _32;
			[FieldOffset(32)]
			public float _33;
		}

		public override int MemorySize => 9 * 4;

		public override int Draw(ViewInfo view, int x2, int y2)
		{
			return DrawMatrixType(view, x2, y2, "Matrix (3x3)", (ref int x, ref int y, int defaultX) =>
			{
				var value = view.Memory.ReadObject<Matrix3x3Data>(Offset);

				y += view.Font.Height;
				x = defaultX;
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
				x = AddText(view, x, y, view.Settings.Value, 0, $"{value._11,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 1, $"{value._12,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 2, $"{value._13,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");

				y += view.Font.Height;
				x = defaultX;
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
				x = AddText(view, x, y, view.Settings.Value, 3, $"{value._21,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 4, $"{value._22,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 5, $"{value._23,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");

				y += view.Font.Height;
				x = defaultX;
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
				x = AddText(view, x, y, view.Settings.Value, 6, $"{value._31,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 7, $"{value._32,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, ",");
				x = AddText(view, x, y, view.Settings.Value, 8, $"{value._33,14:0.000}");
				x = AddText(view, x, y, view.Settings.Name, HotSpot.NoneId, "|");
			});
		}

		public override void Update(HotSpot spot)
		{
			base.Update(spot);

			Update(spot, 9);
		}
	}
}
