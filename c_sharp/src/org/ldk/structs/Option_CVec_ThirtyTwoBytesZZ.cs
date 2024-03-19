using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::derived::CVec_ThirtyTwoBytesZ or not
 */
public class Option_CVec_ThirtyTwoBytesZZ : CommonBase {
	protected Option_CVec_ThirtyTwoBytesZZ(object _dummy, long ptr) : base(ptr) { }
	~Option_CVec_ThirtyTwoBytesZZ() {
		if (ptr != 0) { Bindings.COptionCVecThirtyTwoBytesZZFree(ptr); }
	}

	internal static Option_CVec_ThirtyTwoBytesZZ constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionCVecThirtyTwoBytesZZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_CVec_ThirtyTwoBytesZZ_Some(ptr);
			case 1: return new Option_CVec_ThirtyTwoBytesZZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_CVec_ThirtyTwoBytesZZ of type Some */
	public class Option_CVec_ThirtyTwoBytesZZ_Some : Option_CVec_ThirtyTwoBytesZZ {
		public byte[][] some;
		internal Option_CVec_ThirtyTwoBytesZZ_Some(long ptr) : base(null, ptr) {
			long some = Bindings.LDKCOptionCVecThirtyTwoBytesZZSomeGetSome(ptr);
			int some_conv_8_len = InternalUtils.GetArrayLength(some);
			byte[][] some_conv_8_arr = new byte[some_conv_8_len][];
			for (int i = 0; i < some_conv_8_len; i++) {
				long some_conv_8 = InternalUtils.GetU64ArrayElem(some, i);
				byte[] some_conv_8_conv = InternalUtils.DecodeUint8Array(some_conv_8);
				some_conv_8_arr[i] = some_conv_8_conv;
			}
			Bindings.FreeBuffer(some);
			this.some = some_conv_8_arr;
		}
	}
	/** A Option_CVec_ThirtyTwoBytesZZ of type None */
	public class Option_CVec_ThirtyTwoBytesZZ_None : Option_CVec_ThirtyTwoBytesZZ {
		internal Option_CVec_ThirtyTwoBytesZZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_CVec_ThirtyTwoBytesZZ containing a crate::c_types::derived::CVec_ThirtyTwoBytesZ
	 */
	public static Option_CVec_ThirtyTwoBytesZZ some(byte[][] o) {
		long ret = Bindings.COptionCVecThirtyTwoBytesZZSome(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(o, o_conv_8 => InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(o_conv_8, 32)))));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ ret_hu_conv = org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_CVec_ThirtyTwoBytesZZ containing nothing
	 */
	public static Option_CVec_ThirtyTwoBytesZZ none() {
		long ret = Bindings.COptionCVecThirtyTwoBytesZZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ ret_hu_conv = org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionCVecThirtyTwoBytesZZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_CVec_ThirtyTwoBytesZZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_CVec_ThirtyTwoBytesZZ clone() {
		long ret = Bindings.COptionCVecThirtyTwoBytesZZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ ret_hu_conv = org.ldk.structs.Option_CVec_ThirtyTwoBytesZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
