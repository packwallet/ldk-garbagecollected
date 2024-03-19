using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A data structure for tracking in-flight HTLCs. May be used during pathfinding to account for
 * in-use channel liquidity.
 */
public class InFlightHtlcs : CommonBase {
	internal InFlightHtlcs(object _dummy, long ptr) : base(ptr) { }
	~InFlightHtlcs() {
		if (ptr != 0) { Bindings.InFlightHtlcsFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.InFlightHtlcsClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the InFlightHtlcs
	 */
	public InFlightHtlcs clone() {
		long ret = Bindings.InFlightHtlcsClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InFlightHtlcs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InFlightHtlcs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs an empty `InFlightHtlcs`.
	 */
	public static InFlightHtlcs of() {
		long ret = Bindings.InFlightHtlcsNew();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InFlightHtlcs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InFlightHtlcs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Takes in a path with payer's node id and adds the path's details to `InFlightHtlcs`.
	 */
	public void process_path(org.ldk.structs.Path path, byte[] payer_node_id) {
		Bindings.InFlightHtlcsProcessPath(this.ptr, path == null ? 0 : path.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payer_node_id, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(path);
		GC.KeepAlive(payer_node_id);
		if (this != null) { this.ptrs_to.AddLast(path); };
	}

	/**
	 * Adds a known HTLC given the public key of the HTLC source, target, and short channel
	 * id.
	 */
	public void add_inflight_htlc(org.ldk.structs.NodeId source, org.ldk.structs.NodeId target, long channel_scid, long used_msat) {
		Bindings.InFlightHtlcsAddInflightHtlc(this.ptr, source == null ? 0 : source.ptr, target == null ? 0 : target.ptr, channel_scid, used_msat);
		GC.KeepAlive(this);
		GC.KeepAlive(source);
		GC.KeepAlive(target);
		GC.KeepAlive(channel_scid);
		GC.KeepAlive(used_msat);
		if (this != null) { this.ptrs_to.AddLast(source); };
		if (this != null) { this.ptrs_to.AddLast(target); };
	}

	/**
	 * Returns liquidity in msat given the public key of the HTLC source, target, and short channel
	 * id.
	 */
	public Option_u64Z used_liquidity_msat(org.ldk.structs.NodeId source, org.ldk.structs.NodeId target, long channel_scid) {
		long ret = Bindings.InFlightHtlcsUsedLiquidityMsat(this.ptr, source == null ? 0 : source.ptr, target == null ? 0 : target.ptr, channel_scid);
		GC.KeepAlive(this);
		GC.KeepAlive(source);
		GC.KeepAlive(target);
		GC.KeepAlive(channel_scid);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		if (this != null) { this.ptrs_to.AddLast(source); };
		if (this != null) { this.ptrs_to.AddLast(target); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the InFlightHtlcs object into a byte array which can be read by InFlightHtlcs_read
	 */
	public byte[] write() {
		long ret = Bindings.InFlightHtlcsWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a InFlightHtlcs from a byte array, created by InFlightHtlcs_write
	 */
	public static Result_InFlightHtlcsDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.InFlightHtlcsRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InFlightHtlcsDecodeErrorZ ret_hu_conv = Result_InFlightHtlcsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
