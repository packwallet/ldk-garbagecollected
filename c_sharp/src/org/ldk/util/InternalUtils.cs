using System;
using System.Text;
using org.ldk.util;
using org.ldk.impl;

internal class InternalUtils {
	public static T[] CheckArrLen<T>(T[] arr, int length) {
		if (arr != null && arr.Length != length) {
			throw new ArgumentException("Array must be of fixed size " + length + " but was of length " + arr.Length);
		}
		return arr;
	}

	public static byte[] ConvUInt5Array(UInt5[] u5s) {
		if (u5s == null) return null;
		byte[] res = new byte[u5s.Length];
		for (int i = 0; i < u5s.Length; i++) {
			res[i] = u5s[i].getVal();
		}
		return res;
	}

	public static T[] MapArray<F, T>(F[] arr, Func<F, T> f) {
		if (arr == null) return null;
		T[] ret = new T[arr.Length];
		for (int i = 0; i < arr.Length; i++) ret[i] = f(arr[i]);
		return ret;
	}

	public static string DecodeString(long strptr) {
		byte[] bytes = DecodeUint8Array(strptr);
		return Encoding.UTF8.GetString(bytes);
	}

	public static long EncodeString(string s) {
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		return EncodeUint8Array(bytes);
	}


	public static int GetArrayLength(long arrptr) {
		long len;
		unsafe {
			long* arrlen = (long*) arrptr;
			len = *arrlen;
		}
		if (len > 0xffffffffL) {
			throw new ArgumentException("Array length was out of bounds");
		}
		return (int)len;
	}


	public static long GetU64ArrayElem(long arrptr, int idx) {
		unsafe {
			long* arr = (long*) (arrptr + 8);
			return arr[idx];
		}
	}
	public static int GetU32ArrayElem(long arrptr, int idx) {
		unsafe {
			int* arr = (int*) (arrptr + 8);
			return arr[idx];
		}
	}
	public static short GetU16ArrayElem(long arrptr, int idx) {
		unsafe {
			short* arr = (short*) (arrptr + 8);
			return arr[idx];
		}
	}
	public static byte GetU8ArrayElem(long arrptr, int idx) {
		unsafe {
			byte* arr = (byte*) (arrptr + 8);
			return arr[idx];
		}
	}


	public static long EncodeUint8Array(byte[] arr) {
		long buf = Bindings.AllocateBuffer(arr.Length + 8);
		unsafe { *((long*)buf) = (long)arr.Length; }
		for (int i = 0; i < arr.Length; i++) {
			unsafe {
				((byte*)(buf + 8))[i] = arr[i];
			}
		}
		return buf;
	}
	public static long EncodeUint16Array(short[] arr) {
		long buf = Bindings.AllocateBuffer(arr.Length * 2 + 8);
		unsafe { *((long*)buf) = (long)arr.Length; }
		for (int i = 0; i < arr.Length; i++) {
			unsafe {
				((short*)(buf + 8))[i] = arr[i];
			}
		}
		return buf;
	}
	public static long EncodeUint32Array(int[] arr) {
		long buf = Bindings.AllocateBuffer(arr.Length * 4 + 8);
		unsafe { *((long*)buf) = (long)arr.Length; }
		for (int i = 0; i < arr.Length; i++) {
			unsafe {
				((int*)(buf + 8))[i] = arr[i];
			}
		}
		return buf;
	}
	public static long EncodeUint64Array(long[] arr) {
		long buf = Bindings.AllocateBuffer(arr.Length * 8 + 8);
		unsafe { *((long*)buf) = (long)arr.Length; }
		for (int i = 0; i < arr.Length; i++) {
			unsafe {
				((long*)(buf + 8))[i] = arr[i];
			}
		}
		return buf;
	}


	public static byte[] DecodeUint8Array(long arrptr) {
		int len = GetArrayLength(arrptr);
		byte[] res = new byte[len];
		for (int i = 0; i < len; i++)
			res[i] = GetU8ArrayElem(arrptr, i);
		Bindings.FreeBuffer(arrptr);
		return res;
	}
	public static short[] DecodeUint16Array(long arrptr) {
		int len = GetArrayLength(arrptr);
		short[] res = new short[len];
		for (int i = 0; i < len; i++)
			res[i] = GetU16ArrayElem(arrptr, i);
		Bindings.FreeBuffer(arrptr);
		return res;
	}
	public static long[] DecodeUint64Array(long arrptr) {
		int len = GetArrayLength(arrptr);
		long[] res = new long[len];
		for (int i = 0; i < len; i++)
			res[i] = GetU64ArrayElem(arrptr, i);
		Bindings.FreeBuffer(arrptr);
		return res;
	}
}
