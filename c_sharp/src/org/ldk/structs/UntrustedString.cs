using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Struct to `Display` fields in a safe way using `PrintableString`
 */
public class UntrustedString : CommonBase {
	internal UntrustedString(object _dummy, long ptr) : base(ptr) { }
	~UntrustedString() {
		if (ptr != 0) { Bindings.UntrustedStringFree(ptr); }
	}

	public string get_a() {
		long ret = Bindings.UntrustedStringGetA(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.DecodeString(ret);
		return ret_conv;
	}

	public void set_a(string val) {
		Bindings.UntrustedStringSetA(this.ptr, InternalUtils.EncodeString(val));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new UntrustedString given each field
	 */
	public static UntrustedString of(string a_arg) {
		long ret = Bindings.UntrustedStringNew(InternalUtils.EncodeString(a_arg));
		GC.KeepAlive(a_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UntrustedString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UntrustedString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.UntrustedStringClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UntrustedString
	 */
	public UntrustedString clone() {
		long ret = Bindings.UntrustedStringClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UntrustedString ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UntrustedString(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two UntrustedStrings contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UntrustedString b) {
		bool ret = Bindings.UntrustedStringEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UntrustedString)) return false;
		return this.eq((UntrustedString)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the UntrustedString.
	 */
	public long hash() {
		long ret = Bindings.UntrustedStringHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Serialize the UntrustedString object into a byte array which can be read by UntrustedString_read
	 */
	public byte[] write() {
		long ret = Bindings.UntrustedStringWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a UntrustedString from a byte array, created by UntrustedString_write
	 */
	public static Result_UntrustedStringDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.UntrustedStringRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UntrustedStringDecodeErrorZ ret_hu_conv = Result_UntrustedStringDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
