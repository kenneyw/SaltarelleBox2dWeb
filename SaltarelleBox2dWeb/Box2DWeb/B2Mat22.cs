﻿/*
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
	/// A 2-by-2 matrix. 
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2Mat22
	{
		public B2Vec2 col1, col2;

		/// <summary>
		/// Construct
		/// </summary>
		public B2Mat22()
		{
		}

		/// <summary>
		/// Construct this matrix using an angle. 
		/// This matrix becomes an orthonormal rotation matrix.
		/// </summary>
		public static B2Vec2 FromAngle (float angle)
		{
			return null;
		}

		/// <summary>
		/// Construct this matrix using columns.
		/// </summary>
		public static B2Mat22 FromVV(B2Vec2 c1, B2Vec2 c2)
		{
			return null;
		}

		/// <summary>
		/// Initialize this matrix using an angle.
		/// This matrix becomes an orthonormal rotation matrix.
		/// </summary>
		public void Set(float angle)
		{
		}

		/// <summary>
		/// Initialize this matrix using columns.
		/// </summary>
		public void SetVV(B2Vec2 c1, B2Vec2 c2)
		{
		}

		/// <summary>
		/// Copy this matrix.
		/// </summary>
		public B2Mat22 Copy()
		{
			return null;
		}

		/// <summary>
		/// Set to this matrix.
		/// </summary>
		public void SetM(B2Mat22 m)
		{
		}

		/// <summary>
		/// Add this matrix.
		/// </summary>
		public void Add(B2Mat22 m)
		{
		}

		/// <summary>
		/// Set this matrix to identity.
		/// </summary>
		public void SetIdentity()
		{
		}

		/// <summary>
		/// Set this matrix to all zeros.
		/// </summary>
		public void SetZero()
		{
		}

		/// <summary>
		/// Extract the angle from this matrix (assumed to be a rotation matrix).
		/// </summary>
		public float GetAngle()
		{
			return 0;
		}

		/// <summary>
		/// Compute the inverse of this matrix, such that inv(A) * A = identity.
		/// </summary>
		public B2Mat22 GetInverse(ref B2Mat22 mIn)
		{
			return null;
		}

		/// <summary>
		/// Solve A * x = b, where b is a column vector. This is more efficient
		/// than computing the inverse in one-shot cases.
		/// </summary>
		public B2Vec2 Solve(ref B2Mat22 mIn, float bX, float bY)
		{
			return null;
		}
	}
}


