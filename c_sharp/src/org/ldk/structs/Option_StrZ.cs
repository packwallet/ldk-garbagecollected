using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::Str or not
 */
public class Option_StrZ : CommonBase {
	protected Option_StrZ(object _dummy, long ptr) : base(ptr) { }
	~Option_StrZ() {
		if (ptr != 0) { Bindings.COptionStrZFree(ptr); }
	}

	internal static Option_StrZ constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionStrZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_StrZ_Some(ptr);
			case 1: return new Option_StrZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_StrZ of type Some */
	public class Option_StrZ_Some : Option_StrZ {
		public string some;
		internal Option_StrZ_Some(long ptr) : base(null, ptr) {
			long some = Bindings.LDKCOptionStrZSomeGetSome(ptr);
			string some_conv = InternalUtils.DecodeString(some);
			this.some = some_conv;
		}
	}
	/** A Option_StrZ of type None */
	public class Option_StrZ_None : Option_StrZ {
		internal Option_StrZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_StrZ containing a crate::c_types::Str
	 */
	public static Option_StrZ some(string o) {
		long ret = Bindings.COptionStrZSome(InternalUtils.EncodeString(o));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_StrZ containing nothing
	 */
	public static Option_StrZ none() {
		long ret = Bindings.COptionStrZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionStrZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_StrZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_StrZ clone() {
		long ret = Bindings.COptionStrZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_StrZ ret_hu_conv = org.ldk.structs.Option_StrZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
