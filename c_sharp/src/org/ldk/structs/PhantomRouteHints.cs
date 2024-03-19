using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Route hints used in constructing invoices for [phantom node payents].
 * 
 * [phantom node payments]: crate::sign::PhantomKeysManager
 */
public class PhantomRouteHints : CommonBase {
	internal PhantomRouteHints(object _dummy, long ptr) : base(ptr) { }
	~PhantomRouteHints() {
		if (ptr != 0) { Bindings.PhantomRouteHintsFree(ptr); }
	}

	/**
	 * The list of channels to be included in the invoice route hints.
	 */
	public ChannelDetails[] get_channels() {
		long ret = Bindings.PhantomRouteHintsGetChannels(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_16_len = InternalUtils.GetArrayLength(ret);
		ChannelDetails[] ret_conv_16_arr = new ChannelDetails[ret_conv_16_len];
		for (int q = 0; q < ret_conv_16_len; q++) {
			long ret_conv_16 = InternalUtils.GetU64ArrayElem(ret, q);
			org.ldk.structs.ChannelDetails ret_conv_16_hu_conv = null; if (ret_conv_16 < 0 || ret_conv_16 > 4096) { ret_conv_16_hu_conv = new org.ldk.structs.ChannelDetails(null, ret_conv_16); }
			if (ret_conv_16_hu_conv != null) { ret_conv_16_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_16_arr[q] = ret_conv_16_hu_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_16_arr;
	}

	/**
	 * The list of channels to be included in the invoice route hints.
	 */
	public void set_channels(ChannelDetails[] val) {
		Bindings.PhantomRouteHintsSetChannels(this.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(val, val_conv_16 => val_conv_16 == null ? 0 : val_conv_16.ptr)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		foreach (ChannelDetails val_conv_16 in val) { if (this != null) { this.ptrs_to.AddLast(val_conv_16); }; };
	}

	/**
	 * A fake scid used for representing the phantom node's fake channel in generating the invoice
	 * route hints.
	 */
	public long get_phantom_scid() {
		long ret = Bindings.PhantomRouteHintsGetPhantomScid(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A fake scid used for representing the phantom node's fake channel in generating the invoice
	 * route hints.
	 */
	public void set_phantom_scid(long val) {
		Bindings.PhantomRouteHintsSetPhantomScid(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The pubkey of the real backing node that would ultimately receive the payment.
	 */
	public byte[] get_real_node_pubkey() {
		long ret = Bindings.PhantomRouteHintsGetRealNodePubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The pubkey of the real backing node that would ultimately receive the payment.
	 */
	public void set_real_node_pubkey(byte[] val) {
		Bindings.PhantomRouteHintsSetRealNodePubkey(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PhantomRouteHints given each field
	 */
	public static PhantomRouteHints of(ChannelDetails[] channels_arg, long phantom_scid_arg, byte[] real_node_pubkey_arg) {
		long ret = Bindings.PhantomRouteHintsNew(InternalUtils.EncodeUint64Array(InternalUtils.MapArray(channels_arg, channels_arg_conv_16 => channels_arg_conv_16 == null ? 0 : channels_arg_conv_16.ptr)), phantom_scid_arg, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(real_node_pubkey_arg, 33)));
		GC.KeepAlive(channels_arg);
		GC.KeepAlive(phantom_scid_arg);
		GC.KeepAlive(real_node_pubkey_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PhantomRouteHints ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PhantomRouteHints(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (ChannelDetails channels_arg_conv_16 in channels_arg) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channels_arg_conv_16); }; };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.PhantomRouteHintsClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PhantomRouteHints
	 */
	public PhantomRouteHints clone() {
		long ret = Bindings.PhantomRouteHintsClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PhantomRouteHints ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PhantomRouteHints(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the PhantomRouteHints object into a byte array which can be read by PhantomRouteHints_read
	 */
	public byte[] write() {
		long ret = Bindings.PhantomRouteHintsWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a PhantomRouteHints from a byte array, created by PhantomRouteHints_write
	 */
	public static Result_PhantomRouteHintsDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.PhantomRouteHintsRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PhantomRouteHintsDecodeErrorZ ret_hu_conv = Result_PhantomRouteHintsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
