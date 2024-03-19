using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::SecretKey or not
 */
public class Option_SecretKeyZ : CommonBase {
	protected Option_SecretKeyZ(object _dummy, long ptr) : base(ptr) { }
	~Option_SecretKeyZ() {
		if (ptr != 0) { Bindings.COptionSecretKeyZFree(ptr); }
	}

	internal static Option_SecretKeyZ constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionSecretKeyZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_SecretKeyZ_Some(ptr);
			case 1: return new Option_SecretKeyZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_SecretKeyZ of type Some */
	public class Option_SecretKeyZ_Some : Option_SecretKeyZ {
		public byte[] some;
		internal Option_SecretKeyZ_Some(long ptr) : base(null, ptr) {
			long some = Bindings.LDKCOptionSecretKeyZSomeGetSome(ptr);
			byte[] some_conv = InternalUtils.DecodeUint8Array(some);
			this.some = some_conv;
		}
	}
	/** A Option_SecretKeyZ of type None */
	public class Option_SecretKeyZ_None : Option_SecretKeyZ {
		internal Option_SecretKeyZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_SecretKeyZ containing a crate::c_types::SecretKey
	 */
	public static Option_SecretKeyZ some(byte[] o) {
		long ret = Bindings.COptionSecretKeyZSome(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(o, 32)));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_SecretKeyZ ret_hu_conv = org.ldk.structs.Option_SecretKeyZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_SecretKeyZ containing nothing
	 */
	public static Option_SecretKeyZ none() {
		long ret = Bindings.COptionSecretKeyZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_SecretKeyZ ret_hu_conv = org.ldk.structs.Option_SecretKeyZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionSecretKeyZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_SecretKeyZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_SecretKeyZ clone() {
		long ret = Bindings.COptionSecretKeyZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_SecretKeyZ ret_hu_conv = org.ldk.structs.Option_SecretKeyZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
