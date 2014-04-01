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
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2TimeStep
	{
		public float dt; // time step
		public float inv_dt; // inverse time step (0 if dt == 0).
		public float dtRatio;	// dt * inv_dt0
		public int velocityIterations;
		public int positionIterations;
		public bool warmStarting;
	}

	/// <summary>
	/// The world class manages all physics entities, dynamic simulation,
	/// and asynchronous queries.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2World
	{
        /// <summary>
        /// Construct a world object.
        /// </summary>
        /// <param name="gravity">The world gravity vector.</param>
        /// <param name="doSleep">Improve performance by not simulating inactive bodies.</param>
		public B2World(B2Vec2 gravity, bool doSleep)
        {
		}

		///// <summary>
		///// Register a destruction listener.
		///// </summary>
		///// <param name="listener"></param>
		//public void SetDestructionListener(DestructionListener listener)
		//{
		//}

		///// <summary>
		///// Register a broad-phase boundary listener.
		///// </summary>
		///// <param name="listener"></param>
		//public void SetBoundaryListener(BoundaryListener listener)
		//{
		//}

		///// <summary>
		///// Register a contact filter to provide specific control over collision.
		///// Otherwise the default filter is used (b2_defaultFilter).
		///// </summary>
		///// <param name="filter"></param>
		//public void SetContactFilter(ContactFilter filter)
		//{
		//}

		///// <summary>
		///// Register a contact event listener
		///// </summary>
		///// <param name="listener"></param>
		//public void SetContactListener(ContactListener listener)
		//{
		//}

		///// <summary>
		///// Register a routine for debug drawing. The debug draw functions are called
		///// inside the World.Step method, so make sure your renderer is ready to
		///// consume draw commands when you call Step().
		///// </summary>
		///// <param name="debugDraw"></param>
		//public void SetDebugDraw(DebugDraw debugDraw)
		//{
		//}

		/// <summary>
		/// Create a rigid body given a definition. No reference to the definition
		/// is retained.
		/// @warning This function is locked during callbacks.
		/// </summary>
		/// <param name="def"></param>
		/// <returns></returns>
		public B2Body CreateBody(B2BodyDef def)
		{
			return null;
		}

		/// <summary>
		/// Destroy a rigid body given a definition. No reference to the definition
		/// is retained. This function is locked during callbacks.
		/// @warning This automatically deletes all associated shapes and joints.
		/// @warning This function is locked during callbacks.
		/// </summary>
		/// <param name="b"></param>
		public void DestroyBody(B2Body b)
		{
		}

		///// <summary>
		///// Create a joint to constrain bodies together. No reference to the definition
		///// is retained. This may cause the connected bodies to cease colliding.
		///// @warning This function is locked during callbacks.
		///// </summary>
		///// <param name="def"></param>
		///// <returns></returns>
		//public Joint CreateJoint(JointDef def)
		//{
		//	return null;
		//}

		///// <summary>
		///// Destroy a joint. This may cause the connected bodies to begin colliding.
		///// @warning This function is locked during callbacks.
		///// </summary>
		///// <param name="j"></param>
		//public void DestroyJoint(Joint j)
		//{
		//}

		//public Controllers.Controller AddController(Controllers.Controller def)
		//{
		//	return null;
		//}

		//public void RemoveController(Controllers.Controller controller)
		//{
		//}

		/// <summary>
		/// The world provides a single static ground body with no collision shapes.
		/// You can use this to simplify the creation of joints and static shapes.
		/// </summary>
		/// <returns></returns>
		public B2Body GetGroundBody()
		{
			return null;
		}

		/// <summary>
		/// Get the world body list. With the returned body, use Body.GetNext to get
		/// the next body in the world list. A null body indicates the end of the list.
		/// </summary>
		/// <returns>The head of the world body list.</returns>
		public B2Body GetBodyList()
		{
			return null;
		}

		///// <summary>
		///// Get the world joint list. With the returned joint, use Joint.GetNext to get
		///// the next joint in the world list. A null joint indicates the end of the list.
		///// </summary>
		///// <returns>The head of the world joint list.</returns>
		//public Joint GetJointList()
		//{
		//	return null;
		//}

		//public Controllers.Controller GetControllerList()
		//{
		//	return null;
		//}

		/// <summary>
		/// Enable/disable warm starting. For testing.
		/// </summary>		
		public void SetWarmStarting(bool flag)
		{
		}

		/// <summary>
		/// Enable/disable continuous physics. For testing.
		/// </summary>		
		public void SetContinuousPhysics(bool flag)
		{
		}

		/// <summary>
		/// Perform validation of internal data structures.
		/// </summary>
		public void Validate()
		{
		}

		/// <summary>
		/// Get the number of broad-phase proxies.
		/// </summary>
		public int GetProxyCount()
		{
			return 0;
		}

		/// <summary>
		/// Get the number of broad-phase pairs.
		/// </summary>
		/// <returns></returns>
		public int GetPairCount()
		{
			return 0;
		}

		/// <summary>
		/// Get the number of bodies.
		/// </summary>
		/// <returns></returns>
		public int GetBodyCount()
		{
			return 0;
		}

		/// <summary>
		/// Get the number joints.
		/// </summary>
		/// <returns></returns>
		public int GetJointCount()
		{
			return 0;
		}

		/// <summary>
		/// Get the number of contacts (each may have 0 or more contact points).
		/// </summary>
		/// <returns></returns>
		public int GetContactCount()
		{
			return 0;
		}

		/// <summary>
		/// Take a time step. This performs collision detection, integration,
		/// and constraint solution.
		/// </summary>
		/// <param name="dt">The amount of time to simulate, this should not vary.</param>
		/// <param name="velocityIterations">For the velocity constraint solver.</param>
		/// <param name="positionIteration">For the positionconstraint solver.</param>
		public void Step(float dt, int velocityIterations, int positionIteration)
		{
		}

		public void ClearForces()
		{
		}


		/// Query the world for all shapes that potentially overlap the
		/// provided AABB. You provide a shape pointer buffer of specified
		/// size. The number of shapes found is returned.
		/// @param aabb the query box.
		/// @return the number of shapes found in aabb.
		public int QueryAABB(Action callback, B2AABB aabb)
		{
			return 0;
		}

		/// Query the world for all shapes that potentially overlap the
		/// provided shape.
		public int QueryShape(Action callback, B2Shape shape, B2Transform xform)
		{
			return 0;
		}

		/// Query the world for all shapes that potentially overlap the
		/// provided point.
		public int QueryPoint(Action callback, B2Vec2 point)
		{
			return 0;
		}

		/// <summary>
		/// Query the world for all shapes that intersect a given segment. You provide a shap
		/// pointer buffer of specified size. The number of shapes found is returned, and the buffer
		/// is filled in order of intersection.
		/// </summary>
		public int Raycast(Action callback, B2Vec2 point1, B2Vec2 point2)
		{
			return 0;
		}

		/// <summary>
		/// Performs a raycast as with Raycast, finding the first intersecting shape.
		/// </summary>
		/// <returns>Returns the colliding shape shape, or null if not found.</returns>
		public B2Fixture RaycastOne(B2Vec2 point1, B2Vec2 point2)
		{
			return null;
		}

		public bool InRange(B2AABB aabb)
		{
			return false;
		}
	}
	
}


