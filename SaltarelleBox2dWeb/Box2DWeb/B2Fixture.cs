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
	/// This holds contact filtering data.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2FilterData
	{
		/// <summary>
		/// The collision category bits. Normally you would just set one bit.
		/// </summary>
		public ushort categoryBits;

		/// <summary>
		/// The collision mask bits. This states the categories that this
		/// shape would accept for collision.
		/// </summary>
		public ushort maskBits;

		/// <summary>
		/// Collision groups allow a certain group of objects to never collide (negative)
		/// or always collide (positive). Zero means no collision group. Non-zero group
		/// filtering always wins against the mask bits.
		/// </summary>
		public short groupIndex;
	}

	/// <summary>
	/// A fixture definition is used to create a fixture. This class defines an
	/// abstract fixture definition. You can reuse fixture definitions safely.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2FixtureDef
	{
		/// <summary>
		/// The constructor sets the default fixture definition values.
		/// </summary>	
		public B2FixtureDef()
		{
		}

		/// <summary>
		/// Holds the shape type for down-casting.
		/// </summary>
		public B2Shape shape;

		/// <summary>
		/// Use this to store application specific fixture data.
		/// </summary>
		public object userData;

		/// <summary>
		/// The friction coefficient, usually in the range [0,1].
		/// </summary>
		public float friction;

		/// <summary>
		/// The restitution (elasticity) usually in the range [0,1].
		/// </summary>
		public float restitution;

		/// <summary>
		/// The density, usually in kg/m^2.
		/// </summary>
		public float density;

		/// <summary>
		/// A sensor shape collects contact information but never generates a collision response.
		/// </summary>
		public bool isSensor;

		/// <summary>
		/// Contact filtering data.
		/// </summary>
		public B2FilterData filter;
	}

	/// <summary>
	/// A fixture is used to attach a shape to a body for collision detection. A fixture
	/// inherits its transform from its parent. Fixtures hold additional non-geometric data
	/// such as friction, collision filters, etc.
	/// Fixtures are created via Body.CreateFixture.
	/// @warning you cannot reuse fixtures.
	/// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2Fixture
	{
		/// <summary>
		/// Get the type of this shape. You can use this to down cast to the concrete shape.
		/// </summary>
		public new short GetType()
		{
			return 0;
		}

		/// <summary>
		/// Get the child shape. You can modify the child shape, however you should not change the
		/// number of vertices because this will crash some collision caching mechanisms.
		/// </summary>
		public B2Shape GetShape()
		{
			return null;
		}

		/// <summary>
		/// Is this fixture a sensor (non-solid)?
		/// </summary>
		public void SetSensor()
		{
		}

		/// <summary>
		/// Is this fixture a sensor (non-solid)?
		/// </summary>
		public bool IsSensor()
		{
			return false;
		}

		/// <summary>
		/// Contact filtering data. You must call b2World::Refilter to correct
		/// existing contacts/non-contacts.
		/// </summary>
		public void SetFilterData(B2FilterData filterData)
		{
		}

		/// <summary>
		/// Contact filtering data. You must call b2World::Refilter to correct
		/// existing contacts/non-contacts.
		/// </summary>
		public B2FilterData GetFilterData()
		{
			return null;
		}

		/// <summary>
		/// Get the parent body of this fixture. This is NULL if the fixture is not attached.
		/// </summary>
		public B2Body GetBody()
		{
			return null;
		}

		/// <summary>
		/// Get the next fixture in the parent body's fixture list.
		/// </summary>
		public B2Fixture GetNext()
		{
			return null;
		}

		/// <summary>
		/// User data that was assigned in the fixture definition. Use this to
		/// store your application specific data.
		/// </summary>
		public object GetUserData()
		{
			return null;
		}

		/// <summary>
		/// User data that was assigned in the fixture definition. Use this to
		/// store your application specific data.
		/// </summary>
		public void SetUserData(object o)
		{
		}

		/// <summary>
		/// Test a point for containment in this fixture. This only works for convex shapes.
		/// </summary>
		public bool TestPoint(B2Vec2 p)
		{
			return false;
		}

		/// <summary>
		// Real-time Collision Detection.
		/// </summary>
		public bool RayCast(B2RayCastOutput output, B2RayCastInput input)
		{
			return false;
		}

		/// <summary>
		/// Get the mass properties of this fixture
		/// </summary>
		public B2MassData GetMassData()
		{
			return null;
		}

		/// <summary>
		/// Set the density property of this fixture
		/// </summary>
		public void SetDensity(float density)
		{
		}

		/// <summary>
		/// Get the density property of this fixture
		/// </summary>
		public float GetDensity()
		{
			return 0;
		}

		/// <summary>
		/// Set the Friction coefficient, usually in the range [0,1] property of this fixture
		/// </summary>
		public void SetFriction(float friction)
		{
		}

		/// <summary>
		/// Get the Friction coefficient, usually in the range [0,1] property of this fixture
		/// </summary>
		public float GetFriction()
		{
			return 0;
		}

		/// <summary>
		/// Set the Restitution (elasticity) usually in the range [0,1] property of this fixture
		/// </summary>
		public void SetRestitution(float restitution)
		{
		}

		/// <summary>
		/// Get the Restitution (elasticity) usually in the range [0,1] property of this fixture
		/// </summary>
		public float GetRestitution()
		{
			return 0;
		}

		/// <summary>
		/// Get the AABB of this fixture.
		/// </summary>
		public B2AABB GetAABB()
		{
			return null;
		}

		public B2Fixture()
		{
		}

		public void Create(B2Body body, B2Transform xf, B2FixtureDef def)
		{
		}

		public void Destroy()
		{
		}

		// TODO:
		//internal bool Synchronize(BroadPhase broadPhase, XForm transform1, XForm transform2)
		//{
		//}

		// TODO:
		//internal void RefilterProxy(BroadPhase broadPhase, XForm transform)
		//{
		//}

	}
}


