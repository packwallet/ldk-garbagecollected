using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A list of hops along a payment path terminating with a channel to the recipient.
 */
public class RouteHint : CommonBase {
	internal RouteHint(object _dummy, long ptr) : base(ptr) { }
	~RouteHint() {
		if (ptr != 0) { Bindings.RouteHintFree(ptr); }
	}

	public RouteHintHop[] get_a() {
		long ret = Bindings.RouteHintGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_14_len = InternalUtils.GetArrayLength(ret);
		RouteHintHop[] ret_conv_14_arr = new RouteHintHop[ret_conv_14_len];
		for (int o = 0; o < ret_conv_14_len; o++) {
			long ret_conv_14 = InternalUtils.GetU64ArrayElem(ret, o);
			org.ldk.structs.RouteHintHop ret_conv_14_hu_conv = null; if (ret_conv_14 < 0 || ret_conv_14 > 4096) { ret_conv_14_hu_conv = new org.ldk.structs.RouteHintHop(null, ret_conv_14); }
			if (ret_conv_14_hu_conv != null) { ret_conv_14_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_14_arr[o] = ret_conv_14_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_14_arr;
	}

	public void set_a(RouteHintHop[] val) {
		Bindings.RouteHintSetA(this.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(val, val_conv_14 => val_conv_14 == null ? 0 : val_conv_14.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		foreach (RouteHintHop val_conv_14 in val) { if (this != null) { this.ptrs_to.AddLast(val_conv_14); }; };
	}

	/**
	 * Constructs a new RouteHint given each field
	 */
	public static RouteHint of(RouteHintHop[] a_arg) {
		long ret = Bindings.RouteHintNew(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(a_arg, a_arg_conv_14 => a_arg_conv_14 == null ? 0 : a_arg_conv_14.ptr)));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteHint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteHint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (RouteHintHop a_arg_conv_14 in a_arg) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a_arg_conv_14); }; };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.RouteHintClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the RouteHint
	 */
	public RouteHint clone() {
		long ret = Bindings.RouteHintClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteHint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteHint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the RouteHint.
	 */
	public long hash() {
		long ret = Bindings.RouteHintHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two RouteHints contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.RouteHint b) {
		bool ret = Bindings.RouteHintEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is RouteHint)) return false;
		return this.eq((RouteHint)o);
	}
	/**
	 * Serialize the RouteHint object into a byte array which can be read by RouteHint_read
	 */
	public byte[] write() {
		long ret = Bindings.RouteHintWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a RouteHint from a byte array, created by RouteHint_write
	 */
	public static Result_RouteHintDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.RouteHintRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RouteHintDecodeErrorZ ret_hu_conv = Result_RouteHintDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
