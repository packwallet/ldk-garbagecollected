using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Private routing information
 * 
 * # Invariants
 * The encoded route has to be <1024 5bit characters long (<=639 bytes or <=12 hops)
 */
public class PrivateRoute : CommonBase {
	internal PrivateRoute(object _dummy, long ptr) : base(ptr) { }
	~PrivateRoute() {
		if (ptr != 0) { Bindings.PrivateRouteFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.PrivateRouteClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PrivateRoute
	 */
	public PrivateRoute clone() {
		long ret = Bindings.PrivateRouteClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PrivateRoute ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PrivateRoute(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the PrivateRoute.
	 */
	public long hash() {
		long ret = Bindings.PrivateRouteHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two PrivateRoutes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.PrivateRoute b) {
		bool ret = Bindings.PrivateRouteEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is PrivateRoute)) return false;
		return this.eq((PrivateRoute)o);
	}
	/**
	 * Creates a new (partial) route from a list of hops
	 */
	public static Result_PrivateRouteCreationErrorZ of(org.ldk.structs.RouteHint hops) {
		long ret = Bindings.PrivateRouteNew(hops == null ? 0 : hops.ptr);
		GC.KeepAlive(hops);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PrivateRouteCreationErrorZ ret_hu_conv = Result_PrivateRouteCreationErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(hops); };
		return ret_hu_conv;
	}

	/**
	 * Returns the underlying list of hops
	 */
	public RouteHint into_inner() {
		long ret = Bindings.PrivateRouteIntoInner(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteHint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteHint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		if (this != null) { this.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
