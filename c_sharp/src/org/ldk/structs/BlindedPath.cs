using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Onion messages and payments can be sent and received to blinded paths, which serve to hide the
 * identity of the recipient.
 */
public class BlindedPath : CommonBase {
	internal BlindedPath(object _dummy, long ptr) : base(ptr) { }
	~BlindedPath() {
		if (ptr != 0) { Bindings.BlindedPathFree(ptr); }
	}

	/**
	 * To send to a blinded path, the sender first finds a route to the unblinded
	 * `introduction_node_id`, which can unblind its [`encrypted_payload`] to find out the onion
	 * message or payment's next hop and forward it along.
	 * 
	 * [`encrypted_payload`]: BlindedHop::encrypted_payload
	 */
	public byte[] get_introduction_node_id() {
		long ret = Bindings.BlindedPathGetIntroductionNodeId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * To send to a blinded path, the sender first finds a route to the unblinded
	 * `introduction_node_id`, which can unblind its [`encrypted_payload`] to find out the onion
	 * message or payment's next hop and forward it along.
	 * 
	 * [`encrypted_payload`]: BlindedHop::encrypted_payload
	 */
	public void set_introduction_node_id(byte[] val) {
		Bindings.BlindedPathSetIntroductionNodeId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Used by the introduction node to decrypt its [`encrypted_payload`] to forward the onion
	 * message or payment.
	 * 
	 * [`encrypted_payload`]: BlindedHop::encrypted_payload
	 */
	public byte[] get_blinding_point() {
		long ret = Bindings.BlindedPathGetBlindingPoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Used by the introduction node to decrypt its [`encrypted_payload`] to forward the onion
	 * message or payment.
	 * 
	 * [`encrypted_payload`]: BlindedHop::encrypted_payload
	 */
	public void set_blinding_point(byte[] val) {
		Bindings.BlindedPathSetBlindingPoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The hops composing the blinded path.
	 */
	public BlindedHop[] get_blinded_hops() {
		long ret = Bindings.BlindedPathGetBlindedHops(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_12_len = InternalUtils.GetArrayLength(ret);
		BlindedHop[] ret_conv_12_arr = new BlindedHop[ret_conv_12_len];
		for (int m = 0; m < ret_conv_12_len; m++) {
			long ret_conv_12 = InternalUtils.GetU64ArrayElem(ret, m);
			org.ldk.structs.BlindedHop ret_conv_12_hu_conv = null; if (ret_conv_12 < 0 || ret_conv_12 > 4096) { ret_conv_12_hu_conv = new org.ldk.structs.BlindedHop(null, ret_conv_12); }
			if (ret_conv_12_hu_conv != null) { ret_conv_12_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_12_arr[m] = ret_conv_12_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_12_arr;
	}

	/**
	 * The hops composing the blinded path.
	 */
	public void set_blinded_hops(BlindedHop[] val) {
		Bindings.BlindedPathSetBlindedHops(this.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(val, val_conv_12 => val_conv_12 == null ? 0 : val_conv_12.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		foreach (BlindedHop val_conv_12 in val) { if (this != null) { this.ptrs_to.AddLast(val_conv_12); }; };
	}

	/**
	 * Constructs a new BlindedPath given each field
	 */
	public static BlindedPath of(byte[] introduction_node_id_arg, byte[] blinding_point_arg, BlindedHop[] blinded_hops_arg) {
		long ret = Bindings.BlindedPathNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(introduction_node_id_arg, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(blinding_point_arg, 33)), InternalUtils.EncodeUint64Array(InternalUtils.MapArray(blinded_hops_arg, blinded_hops_arg_conv_12 => blinded_hops_arg_conv_12 == null ? 0 : blinded_hops_arg_conv_12.ptr)));
		GC.KeepAlive(introduction_node_id_arg);
		GC.KeepAlive(blinding_point_arg);
		GC.KeepAlive(blinded_hops_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPath ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPath(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (BlindedHop blinded_hops_arg_conv_12 in blinded_hops_arg) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(blinded_hops_arg_conv_12); }; };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.BlindedPathClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BlindedPath
	 */
	public BlindedPath clone() {
		long ret = Bindings.BlindedPathClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedPath ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedPath(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the BlindedPath.
	 */
	public long hash() {
		long ret = Bindings.BlindedPathHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two BlindedPaths contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.BlindedPath b) {
		bool ret = Bindings.BlindedPathEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is BlindedPath)) return false;
		return this.eq((BlindedPath)o);
	}
	/**
	 * Create a one-hop blinded path for a message.
	 */
	public static Result_BlindedPathNoneZ one_hop_for_message(byte[] recipient_node_id, org.ldk.structs.EntropySource entropy_source) {
		long ret = Bindings.BlindedPathOneHopForMessage(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(recipient_node_id, 33)), entropy_source.ptr);
		GC.KeepAlive(recipient_node_id);
		GC.KeepAlive(entropy_source);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPathNoneZ ret_hu_conv = Result_BlindedPathNoneZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Create a blinded path for an onion message, to be forwarded along `node_pks`. The last node
	 * pubkey in `node_pks` will be the destination node.
	 * 
	 * Errors if no hops are provided or if `node_pk`(s) are invalid.
	 */
	public static Result_BlindedPathNoneZ new_for_message(byte[][] node_pks, org.ldk.structs.EntropySource entropy_source) {
		long ret = Bindings.BlindedPathNewForMessage(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(node_pks, node_pks_conv_8 => InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(node_pks_conv_8, 33)))), entropy_source.ptr);
		GC.KeepAlive(node_pks);
		GC.KeepAlive(entropy_source);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPathNoneZ ret_hu_conv = Result_BlindedPathNoneZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the BlindedPath object into a byte array which can be read by BlindedPath_read
	 */
	public byte[] write() {
		long ret = Bindings.BlindedPathWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a BlindedPath from a byte array, created by BlindedPath_write
	 */
	public static Result_BlindedPathDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.BlindedPathRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedPathDecodeErrorZ ret_hu_conv = Result_BlindedPathDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
