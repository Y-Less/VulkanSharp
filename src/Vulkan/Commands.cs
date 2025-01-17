/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Vulkan
{
	public static partial class Commands
	{
		public static UInt32 EnumerateInstanceVersion ()
		{
			Result result;
			UInt32 pApiVersion;
			unsafe {
				pApiVersion = new UInt32 ();
				result = Interop.NativeMethods.vkEnumerateInstanceVersion (&pApiVersion);
				if (result != Result.Success)
					throw new ResultException (result);

				return pApiVersion;
			}
		}

		public static LayerProperties[] EnumerateInstanceLayerProperties ()
		{
			Result result;
			unsafe {
				UInt32 pPropertyCount;
				result = Interop.NativeMethods.vkEnumerateInstanceLayerProperties (&pPropertyCount, null);
				if (result != Result.Success)
					throw new ResultException (result);
				if (pPropertyCount <= 0)
					return null;

				int size = Marshal.SizeOf (typeof (Interop.LayerProperties));
				var refpProperties = new NativeReference ((int)(size * pPropertyCount));
				var ptrpProperties = refpProperties.Handle;
				result = Interop.NativeMethods.vkEnumerateInstanceLayerProperties (&pPropertyCount, (Interop.LayerProperties*)ptrpProperties);
				if (result != Result.Success)
					throw new ResultException (result);

				if (pPropertyCount <= 0)
					return null;
				var arr = new LayerProperties [pPropertyCount];
				for (int i = 0; i < pPropertyCount; i++) {
					arr [i] = new LayerProperties (new NativePointer (refpProperties, (IntPtr)(&((Interop.LayerProperties*)ptrpProperties) [i])));
				}

				return arr;
			}
		}

		public static ExtensionProperties[] EnumerateInstanceExtensionProperties (string pLayerName = null)
		{
			Result result;
			unsafe {
				UInt32 pPropertyCount;
				result = Interop.NativeMethods.vkEnumerateInstanceExtensionProperties (pLayerName, &pPropertyCount, null);
				if (result != Result.Success)
					throw new ResultException (result);
				if (pPropertyCount <= 0)
					return null;

				int size = Marshal.SizeOf (typeof (Interop.ExtensionProperties));
				var refpProperties = new NativeReference ((int)(size * pPropertyCount));
				var ptrpProperties = refpProperties.Handle;
				result = Interop.NativeMethods.vkEnumerateInstanceExtensionProperties (pLayerName, &pPropertyCount, (Interop.ExtensionProperties*)ptrpProperties);
				if (result != Result.Success)
					throw new ResultException (result);

				if (pPropertyCount <= 0)
					return null;
				var arr = new ExtensionProperties [pPropertyCount];
				for (int i = 0; i < pPropertyCount; i++) {
					arr [i] = new ExtensionProperties (new NativePointer (refpProperties, (IntPtr)(&((Interop.ExtensionProperties*)ptrpProperties) [i])));
				}

				return arr;
			}
		}
	}
}
