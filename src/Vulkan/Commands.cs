using System;

namespace Vulkan
{
	internal static partial class Commands
	{
		public static Result EnumerateInstanceLayerProperties (out UInt32 PropertyCount, out LayerProperties Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new LayerProperties ();
					return Interop.NativeMethods.vkEnumerateInstanceLayerProperties (ptrPropertyCount, Properties.m);
				}
			}
		}

		public static Result EnumerateInstanceExtensionProperties (string pLayerName, out UInt32 PropertyCount, out ExtensionProperties Properties)
		{
			unsafe {
				fixed (UInt32* ptrPropertyCount = &PropertyCount) {
					Properties = new ExtensionProperties ();
					return Interop.NativeMethods.vkEnumerateInstanceExtensionProperties (pLayerName, ptrPropertyCount, Properties.m);
				}
			}
		}
	}
}
