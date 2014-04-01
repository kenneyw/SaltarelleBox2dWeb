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
	/// This holds the mass data computed for a shape.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	public class B2MassData
	{
		/// <summary>
		/// The mass of the shape, usually in kilograms.
		/// </summary>
		public float Mass;

		/// <summary>
		/// The position of the shape's centroid relative to the shape's origin.
		/// </summary>
		public B2Vec2 Center;

		/// <summary>
		/// The rotational inertia of the shape.
		/// </summary>
		[PreserveName]
		public float I;
	}

	///// <summary>
	///// Returns code from TestSegment
	///// </summary>
	//public enum SegmentCollide
	//{
	//	StartInsideCollide = -1,
	//	MissCollide = 0,
	//	HitCollide = 1
	//}

	/// <summary>
	/// A shape is used for collision detection. You can create a shape however you like.
	/// Shapes used for simulation in World are created automatically when a Fixture is created.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public abstract class B2Shape
	{
		public const int e_unknownShape = -1;
		public const int e_circleShape = 0;
		public const int e_polygonShape = 1;
		public const int e_edgeShape = 2;
		public const int e_shapeTypeCount = 3;

		public const int e_hitCollide = 1;
		public const int e_missCollide = 0;
		public const int e_startsInsideCollide = -1;

		#region Fields


		#endregion Fields

		protected B2Shape() { }

		public abstract B2Shape Copy();

		public abstract void Set(B2Shape other);

		public abstract new int GetType();


		/// <summary>
		/// Test a point for containment in this shape. This only works for convex shapes.
		/// </summary>
		/// <param name="xf">The shape world transform.</param>
		/// <param name="p">A point in world coordinates.</param>
		/// <returns></returns>
		public abstract bool TestPoint(B2Transform xf, B2Vec2 p);

		/// <summary>
		// Real-time Collision Detection.
		/// </summary>
		public abstract bool RayCast(out B2RayCastOutput output, B2RayCastInput input, B2Transform xf);
	
		/// <summary>
		/// Given a transform, compute the associated axis aligned bounding box for this shape.
		/// </summary>
		/// <param name="aabb">Returns the axis aligned box.</param>
		/// <param name="xf">The world transform of the shape.</param>
		public abstract void ComputeAABB(out B2AABB aabb, B2Transform xf);

		/// <summary>
		/// Compute the mass properties of this shape using its dimensions and density.
		/// The inertia tensor is computed about the local origin, not the centroid.
		/// </summary>
		/// <param name="massData">Returns the mass data for this shape</param>
		public abstract void ComputeMass(out B2MassData massData, float density);

		/// <summary>
		/// Compute the volume and centroid of this shape intersected with a half plane.
		/// </summary>
		/// <param name="normal">Normal the surface normal.</param>
		/// <param name="offset">Offset the surface offset along normal.</param>
		/// <param name="xf">The shape transform.</param>
		/// <param name="c">Returns the centroid.</param>
		/// <returns>The total volume less than offset along normal.</returns>
		public abstract float ComputeSubmergedArea(B2Vec2 normal, float offset, B2Transform xf, out B2Vec2 c);

		/// <summary>
		/// Test for overlap.
		/// </summary>
		public static bool TestOverlap(B2Shape shape1, B2Transform xf1, B2Shape shape2, B2Transform xf2 )
		{
			return false;
		}

	}
}


