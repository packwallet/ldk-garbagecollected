using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A tx_signatures message containing the sender's signatures for a transaction constructed with
 * interactive transaction construction.
 */
public class TxSignatures : CommonBase {
	internal TxSignatures(object _dummy, long ptr) : base(ptr) { }
	~TxSignatures() {
		if (ptr != 0) { Bindings.TxSignaturesFree(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		long ret = Bindings.TxSignaturesGetChannelId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		Bindings.TxSignaturesSetChannelId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The TXID
	 */
	public byte[] get_tx_hash() {
		long ret = Bindings.TxSignaturesGetTxHash(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The TXID
	 */
	public void set_tx_hash(byte[] val) {
		Bindings.TxSignaturesSetTxHash(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The list of witnesses
	 * 
	 * Returns a copy of the field.
	 */
	public byte[][] get_witnesses() {
		long ret = Bindings.TxSignaturesGetWitnesses(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		int ret_conv_8_len = InternalUtils.GetArrayLength(ret);
		byte[][] ret_conv_8_arr = new byte[ret_conv_8_len][];
		for (int i = 0; i < ret_conv_8_len; i++) {
			long ret_conv_8 = InternalUtils.GetU64ArrayElem(ret, i);
			byte[] ret_conv_8_conv = InternalUtils.DecodeUint8Array(ret_conv_8);
			ret_conv_8_arr[i] = ret_conv_8_conv;
		}
		Bindings.FreeBuffer(ret);
		return ret_conv_8_arr;
	}

	/**
	 * The list of witnesses
	 */
	public void set_witnesses(byte[][] val) {
		Bindings.TxSignaturesSetWitnesses(this.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(val, val_conv_8 => InternalUtils.EncodeUint8Array(val_conv_8))));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new TxSignatures given each field
	 */
	public static TxSignatures of(byte[] channel_id_arg, byte[] tx_hash_arg, byte[][] witnesses_arg) {
		long ret = Bindings.TxSignaturesNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id_arg, 32)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(tx_hash_arg, 32)), InternalUtils.EncodeUint64Array(InternalUtils.MapArray(witnesses_arg, witnesses_arg_conv_8 => InternalUtils.EncodeUint8Array(witnesses_arg_conv_8))));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(tx_hash_arg);
		GC.KeepAlive(witnesses_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxSignatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxSignatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.TxSignaturesClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxSignatures
	 */
	public TxSignatures clone() {
		long ret = Bindings.TxSignaturesClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxSignatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxSignatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the TxSignatures.
	 */
	public long hash() {
		long ret = Bindings.TxSignaturesHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two TxSignaturess contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.TxSignatures b) {
		bool ret = Bindings.TxSignaturesEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is TxSignatures)) return false;
		return this.eq((TxSignatures)o);
	}
	/**
	 * Serialize the TxSignatures object into a byte array which can be read by TxSignatures_read
	 */
	public byte[] write() {
		long ret = Bindings.TxSignaturesWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a TxSignatures from a byte array, created by TxSignatures_write
	 */
	public static Result_TxSignaturesDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.TxSignaturesRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxSignaturesDecodeErrorZ ret_hu_conv = Result_TxSignaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
