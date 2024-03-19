using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a f64 or not
 */
public class Option_f64Z : CommonBase {
	protected Option_f64Z(object _dummy, long ptr) : base(ptr) { }
	~Option_f64Z() {
		if (ptr != 0) { Bindings.COptionF64ZFree(ptr); }
	}

	internal static Option_f64Z constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKCOptionF64ZTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Option_f64Z_Some(ptr);
			case 1: return new Option_f64Z_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_f64Z of type Some */
	public class Option_f64Z_Some : Option_f64Z {
		public double some;
		internal Option_f64Z_Some(long ptr) : base(null, ptr) {
			this.some = Bindings.LDKCOptionF64ZSomeGetSome(ptr);
		}
	}
	/** A Option_f64Z of type None */
	public class Option_f64Z_None : Option_f64Z {
		internal Option_f64Z_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_f64Z containing a f64
	 */
	public static Option_f64Z some(double o) {
		long ret = Bindings.COptionF64ZSome(o);
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_f64Z ret_hu_conv = org.ldk.structs.Option_f64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_f64Z containing nothing
	 */
	public static Option_f64Z none() {
		long ret = Bindings.COptionF64ZNone();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_f64Z ret_hu_conv = org.ldk.structs.Option_f64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.COptionF64ZClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_f64Z which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_f64Z clone() {
		long ret = Bindings.COptionF64ZClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_f64Z ret_hu_conv = org.ldk.structs.Option_f64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
