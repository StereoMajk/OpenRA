#region Copyright & License Information
/*
 * Copyright 2007-2017 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version. For more
 * information, see COPYING.
 */
#endregion

using System;
using System.Collections.Generic;

namespace OpenRA.Graphics
{
	public struct ModelAnimation
	{
		public readonly IModel Model;
		public readonly Func<WVec> OffsetFunc;
		public readonly Func<IEnumerable<WRot>> RotationFunc;
		public readonly Func<bool> DisableFunc;
		public readonly Func<uint> FrameFunc;
		public readonly bool ShowShadow;

		public ModelAnimation(IModel model, Func<WVec> offset, Func<IEnumerable<WRot>> rotation, Func<bool> disable, Func<uint> frame, bool showshadow)
		{
			Model = model;
			OffsetFunc = offset;
			RotationFunc = rotation;
			DisableFunc = disable;
			FrameFunc = frame;
			ShowShadow = showshadow;
		}
	}
}