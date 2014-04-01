/*
  Box2DWeb C# Wrapper for Saltarelle Compiler
  
  Copyright (c) 2014 Kenney Wong
  Modified and adapted from:
 
  Box2DX Copyright (c) 2009 Ihar Kalasouski http://code.google.com/p/box2dx
  Box2D original C++ version Copyright (c) 2006-2009 Erin Catto http://www.gphysics.com

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Html;
using System.Runtime.CompilerServices;


namespace Box2DWeb
{
	/// <summary>
	/// A transform contains translation and rotation.
	/// It is used to represent the position and orientation of rigid frames.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2Transform
	{
		public B2Vec2 position;
		public B2Mat22 R;

		/// <summary>
		/// Construct using a position vector and a rotation matrix.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="R"></param>
		public B2Transform(B2Vec2 position, B2Mat22 rotation)
		{
		}

		/// <summary>
		/// Set this based on the position vector and a rotation matrix.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="R"></param>
		public void Initialize(B2Vec2 position, B2Mat22 rotation)
		{
		}

		/// <summary>
		/// Set this to the identity transform.
		/// </summary>
		public void SetIdentity()
		{
		}

		/// <summary>
		/// Set this based on the position vector and a rotation matrix.
		/// </summary>
		public void Set(object o)
		{
		}

		/// Calculate the angle that the rotation matrix represents.
		public float GetAngle()
		{
			return 0;
		}

	}
}


