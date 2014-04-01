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
    /// A 2D column vector.
    /// </summary>
	[Imported]
	[IgnoreNamespace]
	[PreserveMemberCase]
	public class B2Vec2
	{
		public float x, y;

        /// <summary>
        /// Construct using coordinates.
        /// </summary>
		public B2Vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Set this vector to all zeros.
        /// </summary>
        public void SetZero()
        {
	        x = 0.0f; 
			y = 0.0f;
        }

        /// <summary>
        /// Set this vector to some specified coordinates.
        /// </summary>
        public void Set(float x, float y)
        {
	        this.x = x;
			this.y = y;
        }
	}
}


