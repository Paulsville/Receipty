package md522565b0bb42c0104dd7cf5fec2ea429c;


public class CameraPictureCallBack
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.hardware.Camera.PictureCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPictureTaken:([BLandroid/hardware/Camera;)V:GetOnPictureTaken_arrayBLandroid_hardware_Camera_Handler:Android.Hardware.Camera/IPictureCallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Receipty.CameraPictureCallBack, Receipty", CameraPictureCallBack.class, __md_methods);
	}


	public CameraPictureCallBack ()
	{
		super ();
		if (getClass () == CameraPictureCallBack.class)
			mono.android.TypeManager.Activate ("Receipty.CameraPictureCallBack, Receipty", "", this, new java.lang.Object[] {  });
	}

	public CameraPictureCallBack (android.content.Context p0)
	{
		super ();
		if (getClass () == CameraPictureCallBack.class)
			mono.android.TypeManager.Activate ("Receipty.CameraPictureCallBack, Receipty", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onPictureTaken (byte[] p0, android.hardware.Camera p1)
	{
		n_onPictureTaken (p0, p1);
	}

	private native void n_onPictureTaken (byte[] p0, android.hardware.Camera p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
