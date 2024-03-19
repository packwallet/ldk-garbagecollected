using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * SHA-256 hash
 */
public class Sha256 : CommonBase {
	internal Sha256(object _dummy, long ptr) : base(ptr) { }
	~Sha256() {
		if (ptr != 0) { Bindings.Sha256Free(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.Sha256ClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Sha256
	 */
	public Sha256 clone() {
		long ret = Bindings.Sha256Clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Sha256 ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Sha256(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Sha256.
	 */
	public long hash() {
		long ret = Bindings.Sha256Hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Sha256s contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.Sha256 b) {
		bool ret = Bindings.Sha256Eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Sha256)) return false;
		return this.eq((Sha256)o);
	}
	/**
	 * Constructs a new [`Sha256`] from the given bytes, which are assumed to be the output of a
	 * single sha256 hash.
	 */
	public static Sha256 from_bytes(byte[] bytes) {
		long ret = Bindings.Sha256FromBytes(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(bytes, 32)));
		GC.KeepAlive(bytes);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Sha256 ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Sha256(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
