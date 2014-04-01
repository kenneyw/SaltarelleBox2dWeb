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
	// Structures and functions used for computing contact points, distance
	// queries, and TOI queries.

	//[Imported]
	//[IgnoreNamespace]
	// [PreserveMemberCase]
	//public partial class Collision
	//{
	//	public static readonly byte NullFeature = Common.Math.UCHAR_MAX;

	//	/// <summary>
	//	/// Compute the point states given two manifolds. The states pertain to the transition from manifold1
	//	/// to manifold2. So state1 is either persist or remove while state2 is either add or persist.
	//	/// </summary>
	//	public static void GetPointStates(PointState[/*b2_maxManifoldPoints*/] state1, PointState[/*b2_maxManifoldPoints*/] state2,
	//				  Manifold manifold1, Manifold manifold2)
	//	{
	//		for (int i = 0; i < Common.Settings.MaxManifoldPoints; ++i)
	//		{
	//			state1[i] = PointState.NullState;
	//			state2[i] = PointState.NullState;
	//		}

	//		// Detect persists and removes.
	//		for (int i = 0; i < manifold1.PointCount; ++i)
	//		{
	//			ContactID id = manifold1.Points[i].ID;

	//			state1[i] = PointState.RemoveState;

	//			for (int j = 0; j < manifold2.PointCount; ++j)
	//			{
	//				if (manifold2.Points[j].ID.Key == id.Key)
	//				{
	//					state1[i] = PointState.PersistState;
	//					break;
	//				}
	//			}
	//		}

	//		// Detect persists and adds.
	//		for (int i = 0; i < manifold2.PointCount; ++i)
	//		{
	//			ContactID id = manifold2.Points[i].ID;

	//			state2[i] = PointState.AddState;

	//			for (int j = 0; j < manifold1.PointCount; ++j)
	//			{
	//				if (manifold1.Points[j].ID.Key == id.Key)
	//				{
	//					state2[i] = PointState.PersistState;
	//					break;
	//				}
	//			}
	//		}
	//	}


	//	// Sutherland-Hodgman clipping.
	//	public static int ClipSegmentToLine(out ClipVertex[/*2*/] vOut, ClipVertex[/*2*/] vIn, Vec2 normal, float offset)
	//	{
	//		vOut = new ClipVertex[2];

	//		// Start with no output points
	//		int numOut = 0;

	//		// Calculate the distance of end points to the line
	//		float distance0 = Vec2.Dot(normal, vIn[0].V) - offset;
	//		float distance1 = Vec2.Dot(normal, vIn[1].V) - offset;

	//		// If the points are behind the plane
	//		if (distance0 <= 0.0f) vOut[numOut++] = vIn[0];
	//		if (distance1 <= 0.0f) vOut[numOut++] = vIn[1];

	//		// If the points are on different sides of the plane
	//		if (distance0 * distance1 < 0.0f)
	//		{
	//			// Find intersection point of edge and plane
	//			float interp = distance0 / (distance0 - distance1);
	//			vOut[numOut].V = vIn[0].V + interp * (vIn[1].V - vIn[0].V);
	//			if (distance0 > 0.0f)
	//			{
	//				vOut[numOut].ID = vIn[0].ID;
	//			}
	//			else
	//			{
	//				vOut[numOut].ID = vIn[1].ID;
	//			}
	//			++numOut;
	//		}

	//		return numOut;
	//	}
	//}

	///// <summary>
	///// The features that intersect to form the contact point.
	///// </summary>
	//public struct Features
	//{
	//	/// <summary>
	//	/// The edge that defines the outward contact normal.
	//	/// </summary>
	//	public Byte ReferenceEdge;

	//	/// <summary>
	//	/// The edge most anti-parallel to the reference edge.
	//	/// </summary>
	//	public Byte IncidentEdge;

	//	/// <summary>
	//	/// The vertex (0 or 1) on the incident edge that was clipped.
	//	/// </summary>
	//	public Byte IncidentVertex;

	//	/// <summary>
	//	/// A value of 1 indicates that the reference edge is on shape2.
	//	/// </summary>
	//	public Byte Flip;
	//}

	///// <summary>
	///// Contact ids to facilitate warm starting.
	///// </summary>
	//[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
	//public struct ContactID
	//{
	//	[System.Runtime.InteropServices.FieldOffset(0)]
	//	public Features Features;

	//	/// <summary>
	//	/// Used to quickly compare contact ids.
	//	/// </summary>
	//	[System.Runtime.InteropServices.FieldOffset(0)]
	//	public UInt32 Key;
	//}

	///// <summary>
	///// A manifold point is a contact point belonging to a contact
	///// manifold. It holds details related to the geometry and dynamics
	///// of the contact points.
	///// The local point usage depends on the manifold type:
	///// -Circles: the local center of circleB
	///// -FaceA: the local center of cirlceB or the clip point of polygonB
	///// -FaceB: the clip point of polygonA
	///// This structure is stored across time steps, so we keep it small.
	///// Note: the impulses are used for internal caching and may not
	///// provide reliable contact forces, especially for high speed collisions.
	///// </summary>
	//[Imported]
	//[IgnoreNamespace]
	//public class ManifoldPoint
	//{
	//	/// <summary>
	//	/// Usage depends on manifold type.
	//	/// </summary>
	//	public Vec2 LocalPoint;

	//	/// <summary>
	//	/// The non-penetration impulse.
	//	/// </summary>
	//	public float NormalImpulse;

	//	/// <summary>
	//	/// The friction impulse.
	//	/// </summary>
	//	public float TangentImpulse;

	//	/// <summary>
	//	/// Uniquely identifies a contact point between two shapes.
	//	/// </summary>
	//	public ContactID ID;

	//	public ManifoldPoint Clone()
	//	{
	//		ManifoldPoint newPoint = new ManifoldPoint();
	//		newPoint.LocalPoint = this.LocalPoint;
	//		newPoint.NormalImpulse = this.NormalImpulse;
	//		newPoint.TangentImpulse = this.TangentImpulse;
	//		newPoint.ID = this.ID;
	//		return newPoint;
	//	}
	//}

	//public enum ManifoldType
	//{
	//	Circles,
	//	FaceA,
	//	FaceB
	//}

	///// <summary>
	///// A manifold for two touching convex shapes.
	///// </summary>
	//public class Manifold
	//{
	//	/// <summary>
	//	/// The points of contact.
	//	/// </summary>
	//	public ManifoldPoint[/*Settings.MaxManifoldPoints*/] Points = new ManifoldPoint[Settings.MaxManifoldPoints];

	//	public Vec2 LocalPlaneNormal;

	//	/// <summary>
	//	/// Usage depends on manifold type.
	//	/// </summary>
	//	public Vec2 LocalPoint;

	//	public ManifoldType Type;

	//	/// <summary>
	//	/// The number of manifold points.
	//	/// </summary>
	//	public int PointCount;

	//	public Manifold()
	//	{
	//		for (int i = 0; i < Settings.MaxManifoldPoints; i++)
	//			Points[i] = new ManifoldPoint();
	//	}

	//	public Manifold Clone()
	//	{
	//		Manifold newManifold = new Manifold();
	//		newManifold.LocalPlaneNormal = this.LocalPlaneNormal;
	//		newManifold.LocalPoint = this.LocalPoint;
	//		newManifold.Type = this.Type;
	//		newManifold.PointCount = this.PointCount;
	//		int pointCount = this.Points.Length;
	//		ManifoldPoint[] tmp = new ManifoldPoint[pointCount];
	//		for (int i = 0; i < pointCount; i++)
	//		{
	//			tmp[i] = this.Points[i].Clone();
	//		}
	//		newManifold.Points = tmp;
	//		return newManifold;
	//	}
	//}

	///// <summary>
	///// A line segment.
	///// </summary>
	//[Imported]
	//[IgnoreNamespace]
	//public class Segment
	//{
	//	// Collision Detection in Interactive 3D Environments by Gino van den Bergen
	//	// From Section 3.4.1
	//	// x = mu1 * p1 + mu2 * p2
	//	// mu1 + mu2 = 1 && mu1 >= 0 && mu2 >= 0
	//	// mu1 = 1 - mu2;
	//	// x = (1 - mu2) * p1 + mu2 * p2
	//	//   = p1 + mu2 * (p2 - p1)
	//	// x = s + a * r (s := start, r := end - start)
	//	// s + a * r = p1 + mu2 * d (d := p2 - p1)
	//	// -a * r + mu2 * d = b (b := s - p1)
	//	// [-r d] * [a; mu2] = b
	//	// Cramer's rule:
	//	// denom = det[-r d]
	//	// a = det[b d] / denom
	//	// mu2 = det[-r b] / denom
	//	/// <summary>
	//	/// Ray cast against this segment with another segment.        
	//	/// </summary>
	//	public bool TestSegment(out float lambda, out Vec2 normal, Segment segment, float maxLambda)
	//	{
	//		lambda = 0f;
	//		normal = new Vec2();

	//		Vec2 s = segment.P1;
	//		Vec2 r = segment.P2 - s;
	//		Vec2 d = P2 - P1;
	//		Vec2 n = Vec2.Cross(d, 1.0f);

	//		float k_slop = 100.0f * Common.Settings.FLT_EPSILON;
	//		float denom = -Vec2.Dot(r, n);

	//		// Cull back facing collision and ignore parallel segments.
	//		if (denom > k_slop)
	//		{
	//			// Does the segment intersect the infinite line associated with this segment?
	//			Vec2 b = s - P1;
	//			float a = Vec2.Dot(b, n);

	//			if (0.0f <= a && a <= maxLambda * denom)
	//			{
	//				float mu2 = -r.X * b.Y + r.Y * b.X;

	//				// Does the segment intersect this segment?
	//				if (-k_slop * denom <= mu2 && mu2 <= denom * (1.0f + k_slop))
	//				{
	//					a /= denom;
	//					n.Normalize();
	//					lambda = a;
	//					normal = n;
	//					return true;
	//				}
	//			}
	//		}

	//		return false;
	//	}

	//	/// <summary>
	//	/// The starting point.
	//	/// </summary>
	//	public Vec2 P1;

	//	/// <summary>
	//	/// The ending point.
	//	/// </summary>
	//	public Vec2 P2;
	//}

	/// <summary>
	/// An axis aligned bounding box.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2AABB
	{
		/// <summary>
		/// The lower vertex.
		/// </summary>
		public B2Vec2 lowerBound;

		/// <summary>
		/// The upper vertex.
		/// </summary>
		public B2Vec2 upperBound;

		/// Verify that the bounds are sorted.
		public bool IsValid()
		{
			return false;
		}

		/// Get the center of the AABB.
		public B2Vec2 GetCenter()
		{
			return null;
		}

		/// Get the extents of the AABB (half-widths).
		public B2Vec2 GetExtents()
		{
			return null;
		}

		/// Does this aabb contain the provided AABB.
		public bool Contains(B2AABB b2Aabb)
		{
			return false;
		}

		/// <summary>
		// From Real-time Collision Detection
		/// </summary>
		public bool RayCast(B2RayCastOutput output, B2RayCastInput input)
		{
			return false;
		}

		public bool TestOverlap(B2AABB b)
		{
			return false;
		}

		/// Combine two AABBs into this one.
		public B2AABB Combine(B2AABB aabb1, B2AABB aabb2)
		{
			return null;
		}

	}

	///// <summary>
	///// This is used for determining the state of contact points.
	///// </summary>
	//public enum PointState
	//{
	//	/// <summary>
	//	/// Point does not exist.
	//	/// </summary>
	//	NullState,
	//	/// <summary>
	//	/// Point was added in the update.
	//	/// </summary>
	//	AddState,
	//	/// <summary>
	//	/// Point persisted across the update.
	//	/// </summary>
	//	PersistState,
	//	/// <summary>
	//	///Point was removed in the update.
	//	/// </summary>
	//	RemoveState
	//}

	///// <summary>
	///// This is used to compute the current state of a contact manifold.
	///// </summary>
	//[Imported]
	//[IgnoreNamespace]
	//public class WorldManifold
	//{
	//	/// <summary>
	//	/// World vector pointing from A to B.
	//	/// </summary>
	//	public Vec2 Normal;
	//	/// <summary>
	//	/// World contact point (point of intersection).
	//	/// </summary>
	//	public Vec2[] Points = new Vec2[Common.Settings.MaxManifoldPoints];

	//	public WorldManifold Clone()
	//	{
	//		WorldManifold newManifold = new WorldManifold();
	//		newManifold.Normal = this.Normal;
	//		this.Points.CopyTo(newManifold.Points, 0);
	//		return newManifold;
	//	}

	//	/// Evaluate the manifold with supplied transforms. This assumes
	//	/// modest motion from the original state. This does not change the
	//	/// point count, impulses, etc. The radii must come from the shapes
	//	/// that generated the manifold.
	//	public void Initialize(Manifold manifold, XForm xfA, float radiusA, XForm xfB, float radiusB)
	//	{
	//		if (manifold.PointCount == 0)
	//		{
	//			return;
	//		}

	//		switch (manifold.Type)
	//		{
	//			case ManifoldType.Circles:
	//				{
	//					Vec2 pointA = Common.Math.Mul(xfA, manifold.LocalPoint);
	//					Vec2 pointB = Common.Math.Mul(xfB, manifold.Points[0].LocalPoint);
	//					Vec2 normal = new Vec2(1.0f, 0.0f);
	//					if (Vec2.DistanceSquared(pointA, pointB) > Common.Settings.FLT_EPSILON_SQUARED)
	//					{
	//						normal = pointB - pointA;
	//						normal.Normalize();
	//					}

	//					Normal = normal;

	//					Vec2 cA = pointA + radiusA * normal;
	//					Vec2 cB = pointB - radiusB * normal;
	//					Points[0] = 0.5f * (cA + cB);
	//				}
	//				break;

	//			case ManifoldType.FaceA:
	//				{
	//					Vec2 normal = Common.Math.Mul(xfA.R, manifold.LocalPlaneNormal);
	//					Vec2 planePoint = Common.Math.Mul(xfA, manifold.LocalPoint);

	//					// Ensure normal points from A to B.
	//					Normal = normal;

	//					for (int i = 0; i < manifold.PointCount; ++i)
	//					{
	//						Vec2 clipPoint = Common.Math.Mul(xfB, manifold.Points[i].LocalPoint);
	//						Vec2 cA = clipPoint + (radiusA - Vec2.Dot(clipPoint - planePoint, normal)) * normal;
	//						Vec2 cB = clipPoint - radiusB * normal;
	//						Points[i] = 0.5f * (cA + cB);
	//					}
	//				}
	//				break;

	//			case ManifoldType.FaceB:
	//				{
	//					Vec2 normal = Common.Math.Mul(xfB.R, manifold.LocalPlaneNormal);
	//					Vec2 planePoint = Common.Math.Mul(xfB, manifold.LocalPoint);

	//					// Ensure normal points from A to B.
	//					Normal = -normal;

	//					for (int i = 0; i < manifold.PointCount; ++i)
	//					{
	//						Vec2 clipPoint = Common.Math.Mul(xfA, manifold.Points[i].LocalPoint);
	//						Vec2 cA = clipPoint - radiusA * normal;
	//						Vec2 cB = clipPoint + (radiusB - Vec2.Dot(clipPoint - planePoint, normal)) * normal;
	//						Points[i] = 0.5f * (cA + cB);
	//					}
	//				}
	//				break;
	//		}
	//	}
	//}

	///// <summary>
	///// Used for computing contact manifolds.
	///// </summary>
	//[Imported]
	//[IgnoreNamespace]
	//public class ClipVertex
	//{
	//	public B2Vec2 V;
	//	public B2ContactID ID;
	//}

	/// <summary>
	/// Ray-cast input data.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2RayCastInput
	{
		public B2Vec2 p1, p2;
		public float maxFraction;
	}

	/// <summary>
	/// Ray-cast output data.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2RayCastOutput
	{
		public B2Vec2 normal;
		public float fraction;
		public bool hit;
	}
}


