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
	/// A circle shape.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2CircleShape : B2Shape
	{
		public B2CircleShape()
		{
		}

		public B2CircleShape(float radius)
		{
		}

		public override B2Shape Copy()
		{
			return null;
		}

		public override void Set(B2Shape other)
		{
		}

		public override int GetType()
		{
			return 0;
		}

		public override bool TestPoint(B2Transform xf, B2Vec2 p)
		{
			return false;
		}

		public override bool RayCast(out B2RayCastOutput output, B2RayCastInput input, B2Transform xf)
		{
			output = new B2RayCastOutput();
			return false;
		}

		public override void ComputeAABB(out B2AABB aabb, B2Transform xf)
		{
			aabb = new B2AABB();
		}

		public override void ComputeMass(out B2MassData massData, float density)
		{
			massData = new B2MassData();
		}

		public override float ComputeSubmergedArea(B2Vec2 normal, float offset, B2Transform xf, out B2Vec2 c)
		{
			c = new B2Vec2(0,0);
			return 0;
		}

		public B2Vec2 GetLocalPosition()
		{
			return null;
		}

		public void SetLocalPosition(B2Vec2 p)
		{
		}

		public float GetRadius()
		{
			return 0;
		}

		public void SetRadius(float r)
		{
		}

	}
}


