using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A channel descriptor for a hop along a payment path.
 * 
 * While this generally comes from BOLT 11's `r` field, this struct includes more fields than are
 * available in BOLT 11. Thus, encoding and decoding this via `lightning-invoice` is lossy, as
 * fields not supported in BOLT 11 will be stripped.
 */
public class RouteHintHop : CommonBase {
	internal RouteHintHop(object _dummy, long ptr) : base(ptr) { }
	~RouteHintHop() {
		if (ptr != 0) { Bindings.RouteHintHopFree(ptr); }
	}

	/**
	 * The node_id of the non-target end of the route
	 */
	public byte[] get_src_node_id() {
		long ret = Bindings.RouteHintHopGetSrcNodeId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The node_id of the non-target end of the route
	 */
	public void set_src_node_id(byte[] val) {
		Bindings.RouteHintHopSetSrcNodeId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The short_channel_id of this channel
	 */
	public long get_short_channel_id() {
		long ret = Bindings.RouteHintHopGetShortChannelId(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The short_channel_id of this channel
	 */
	public void set_short_channel_id(long val) {
		Bindings.RouteHintHopSetShortChannelId(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The fees which must be paid to use this channel
	 */
	public RoutingFees get_fees() {
		long ret = Bindings.RouteHintHopGetFees(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RoutingFees ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RoutingFees(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The fees which must be paid to use this channel
	 */
	public void set_fees(org.ldk.structs.RoutingFees val) {
		Bindings.RouteHintHopSetFees(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The difference in CLTV values between this node and the next node.
	 */
	public short get_cltv_expiry_delta() {
		short ret = Bindings.RouteHintHopGetCltvExpiryDelta(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The difference in CLTV values between this node and the next node.
	 */
	public void set_cltv_expiry_delta(short val) {
		Bindings.RouteHintHopSetCltvExpiryDelta(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum value, in msat, which must be relayed to the next hop.
	 */
	public Option_u64Z get_htlc_minimum_msat() {
		long ret = Bindings.RouteHintHopGetHtlcMinimumMsat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The minimum value, in msat, which must be relayed to the next hop.
	 */
	public void set_htlc_minimum_msat(org.ldk.structs.Option_u64Z val) {
		Bindings.RouteHintHopSetHtlcMinimumMsat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The maximum value in msat available for routing with a single HTLC.
	 */
	public Option_u64Z get_htlc_maximum_msat() {
		long ret = Bindings.RouteHintHopGetHtlcMaximumMsat(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The maximum value in msat available for routing with a single HTLC.
	 */
	public void set_htlc_maximum_msat(org.ldk.structs.Option_u64Z val) {
		Bindings.RouteHintHopSetHtlcMaximumMsat(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new RouteHintHop given each field
	 */
	public static RouteHintHop of(byte[] src_node_id_arg, long short_channel_id_arg, org.ldk.structs.RoutingFees fees_arg, short cltv_expiry_delta_arg, org.ldk.structs.Option_u64Z htlc_minimum_msat_arg, org.ldk.structs.Option_u64Z htlc_maximum_msat_arg) {
		long ret = Bindings.RouteHintHopNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(src_node_id_arg, 33)), short_channel_id_arg, fees_arg == null ? 0 : fees_arg.ptr, cltv_expiry_delta_arg, htlc_minimum_msat_arg.ptr, htlc_maximum_msat_arg.ptr);
		GC.KeepAlive(src_node_id_arg);
		GC.KeepAlive(short_channel_id_arg);
		GC.KeepAlive(fees_arg);
		GC.KeepAlive(cltv_expiry_delta_arg);
		GC.KeepAlive(htlc_minimum_msat_arg);
		GC.KeepAlive(htlc_maximum_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteHintHop ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteHintHop(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(fees_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(htlc_minimum_msat_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(htlc_maximum_msat_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.RouteHintHopClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the RouteHintHop
	 */
	public RouteHintHop clone() {
		long ret = Bindings.RouteHintHopClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RouteHintHop ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RouteHintHop(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the RouteHintHop.
	 */
	public long hash() {
		long ret = Bindings.RouteHintHopHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two RouteHintHops contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.RouteHintHop b) {
		bool ret = Bindings.RouteHintHopEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is RouteHintHop)) return false;
		return this.eq((RouteHintHop)o);
	}
	/**
	 * Serialize the RouteHintHop object into a byte array which can be read by RouteHintHop_read
	 */
	public byte[] write() {
		long ret = Bindings.RouteHintHopWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a RouteHintHop from a byte array, created by RouteHintHop_write
	 */
	public static Result_RouteHintHopDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.RouteHintHopRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RouteHintHopDecodeErrorZ ret_hu_conv = Result_RouteHintHopDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
