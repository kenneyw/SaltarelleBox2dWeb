﻿/*
  
  Copyright (c) 2014 Kenney Wong
  Modified and adapted from:
 
  Box2DX Copyright (c) 2009 Ihar Kalasouski http://code.google.com/p/box2dx

using System;
	[PreserveMemberCase]
	public class B2BodyDef
		/// <summary>
		/// This constructor sets the body definition default values.
		/// </summary>
		public B2BodyDef()
		{
		}

		/// <summary>
		/// One of B2Body types: B2Body.b2_staticBody, B2Body.b2_kinematicBody B2Body.b2_dynamicBody
		/// </summary>
		public short type;

		/// <summary>
		public B2MassData b2MassData;
	[PreserveMemberCase]
	public class B2Body

		/// <summary>
		/// One of B2Body types: B2Body.b2_staticBody, B2Body.b2_kinematicBody B2Body.b2_dynamicBody
		/// </summary>
		public new short GetType()
		{
			return 0;
		}

		/// <summary>

		public bool IsActive()
		{
			return false;
		}

		public bool IsSleepingAllowed()