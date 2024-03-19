using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A path in a [`Route`] to the payment recipient. Must always be at least length one.
 * If no [`Path::blinded_tail`] is present, then [`Path::hops`] length may be up to 19.
 */
public class Path : CommonBase {
	internal Path(object _dummy, long ptr) : base(ptr) { }
	~Path() {
		if (ptr != 0) { Bindings.PathFree(ptr); }
	}

	/**
	 * The list of unblinded hops in this [`Path`]. Must be at least length one.
	 */
	public RouteHop[] get_hops() {
		long ret = Bindings.PathGetHops(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_10_len = InternalUtils.GetArrayLength(ret);
		RouteHop[] ret_conv_10_arr = new RouteHop[ret_conv_10_len];
		for (int k = 0; k < ret_conv_10_len; k++) {
			long ret_conv_10 = InternalUtils.GetU64ArrayElem(ret, k);
			org.ldk.structs.RouteHop ret_conv_10_hu_conv = null; if (ret_conv_10 < 0 || ret_conv_10 > 4096) { ret_conv_10_hu_conv = new org.ldk.structs.RouteHop(null, ret_conv_10); }
			if (ret_conv_10_hu_conv != null) { ret_conv_10_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_10_arr[k] = ret_conv_10_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_10_arr;
	}

	/**
	 * The list of unblinded hops in this [`Path`]. Must be at least length one.
	 */
	public void set_hops(RouteHop[] val) {
		Bindings.PathSetHops(this.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(val, val_conv_10 => val_conv_10 == null ? 0 : val_conv_10.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		foreach (RouteHop val_conv_10 in val) { if (this != null) { this.ptrs_to.AddLast(val_conv_10); }; };
	}

	/**
	 * The blinded path at which this path terminates, if we're sending to one, and its metadata.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public BlindedTail get_blinded_tail() {
		long ret = Bindings.PathGetBlindedTail(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedTail ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedTail(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The blinded path at which this path terminates, if we're sending to one, and its metadata.
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_blinded_tail(org.ldk.structs.BlindedTail val) {
		Bindings.PathSetBlindedTail(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new Path given each field
	 * 
	 * Note that blinded_tail_arg (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public static Path of(RouteHop[] hops_arg, org.ldk.structs.BlindedTail blinded_tail_arg) {
		long ret = Bindings.PathNew(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(hops_arg, hops_arg_conv_10 => hops_arg_conv_10 == null ? 0 : hops_arg_conv_10.ptr)), blinded_tail_arg == null ? 0 : blinded_tail_arg.ptr);
		GC.KeepAlive(hops_arg);
		GC.KeepAlive(blinded_tail_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Path ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Path(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (RouteHop hops_arg_conv_10 in hops_arg) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(hops_arg_conv_10); }; };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(blinded_tail_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.PathClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Path
	 */
	public Path clone() {
		long ret = Bindings.PathClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Path ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Path(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the Path.
	 */
	public long hash() {
		long ret = Bindings.PathHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two Paths contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.Path b) {
		bool ret = Bindings.PathEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Path)) return false;
		return this.eq((Path)o);
	}
	/**
	 * Gets the fees for a given path, excluding any excess paid to the recipient.
	 */
	public long fee_msat() {
		long ret = Bindings.PathFeeMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Gets the total amount paid on this [`Path`], excluding the fees.
	 */
	public long final_value_msat() {
		long ret = Bindings.PathFinalValueMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Gets the final hop's CLTV expiry delta.
	 */
	public Option_u32Z final_cltv_expiry_delta() {
		long ret = Bindings.PathFinalCltvExpiryDelta(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u32Z ret_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
