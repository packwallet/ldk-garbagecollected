using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Information about a spendable output to a P2WSH script.
 * 
 * See [`SpendableOutputDescriptor::DelayedPaymentOutput`] for more details on how to spend this.
 */
public class DelayedPaymentOutputDescriptor : CommonBase {
	internal DelayedPaymentOutputDescriptor(object _dummy, long ptr) : base(ptr) { }
	~DelayedPaymentOutputDescriptor() {
		if (ptr != 0) { Bindings.DelayedPaymentOutputDescriptorFree(ptr); }
	}

	/**
	 * The outpoint which is spendable.
	 */
	public OutPoint get_outpoint() {
		long ret = Bindings.DelayedPaymentOutputDescriptorGetOutpoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The outpoint which is spendable.
	 */
	public void set_outpoint(org.ldk.structs.OutPoint val) {
		Bindings.DelayedPaymentOutputDescriptorSetOutpoint(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Per commitment point to derive the delayed payment key by key holder.
	 */
	public byte[] get_per_commitment_point() {
		long ret = Bindings.DelayedPaymentOutputDescriptorGetPerCommitmentPoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Per commitment point to derive the delayed payment key by key holder.
	 */
	public void set_per_commitment_point(byte[] val) {
		Bindings.DelayedPaymentOutputDescriptorSetPerCommitmentPoint(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The `nSequence` value which must be set in the spending input to satisfy the `OP_CSV` in
	 * the witness_script.
	 */
	public short get_to_self_delay() {
		short ret = Bindings.DelayedPaymentOutputDescriptorGetToSelfDelay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The `nSequence` value which must be set in the spending input to satisfy the `OP_CSV` in
	 * the witness_script.
	 */
	public void set_to_self_delay(short val) {
		Bindings.DelayedPaymentOutputDescriptorSetToSelfDelay(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The output which is referenced by the given outpoint.
	 */
	public TxOut get_output() {
		long ret = Bindings.DelayedPaymentOutputDescriptorGetOutput(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TxOut ret_conv = new TxOut(null, ret);
		return ret_conv;
	}

	/**
	 * The output which is referenced by the given outpoint.
	 */
	public void set_output(org.ldk.structs.TxOut val) {
		Bindings.DelayedPaymentOutputDescriptorSetOutput(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The revocation point specific to the commitment transaction which was broadcast. Used to
	 * derive the witnessScript for this output.
	 */
	public RevocationKey get_revocation_pubkey() {
		long ret = Bindings.DelayedPaymentOutputDescriptorGetRevocationPubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RevocationKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RevocationKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * The revocation point specific to the commitment transaction which was broadcast. Used to
	 * derive the witnessScript for this output.
	 */
	public void set_revocation_pubkey(org.ldk.structs.RevocationKey val) {
		Bindings.DelayedPaymentOutputDescriptorSetRevocationPubkey(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Arbitrary identification information returned by a call to [`ChannelSigner::channel_keys_id`].
	 * This may be useful in re-deriving keys used in the channel to spend the output.
	 */
	public byte[] get_channel_keys_id() {
		long ret = Bindings.DelayedPaymentOutputDescriptorGetChannelKeysId(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Arbitrary identification information returned by a call to [`ChannelSigner::channel_keys_id`].
	 * This may be useful in re-deriving keys used in the channel to spend the output.
	 */
	public void set_channel_keys_id(byte[] val) {
		Bindings.DelayedPaymentOutputDescriptorSetChannelKeysId(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The value of the channel which this output originated from, possibly indirectly.
	 */
	public long get_channel_value_satoshis() {
		long ret = Bindings.DelayedPaymentOutputDescriptorGetChannelValueSatoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The value of the channel which this output originated from, possibly indirectly.
	 */
	public void set_channel_value_satoshis(long val) {
		Bindings.DelayedPaymentOutputDescriptorSetChannelValueSatoshis(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new DelayedPaymentOutputDescriptor given each field
	 */
	public static DelayedPaymentOutputDescriptor of(org.ldk.structs.OutPoint outpoint_arg, byte[] per_commitment_point_arg, short to_self_delay_arg, org.ldk.structs.TxOut output_arg, org.ldk.structs.RevocationKey revocation_pubkey_arg, byte[] channel_keys_id_arg, long channel_value_satoshis_arg) {
		long ret = Bindings.DelayedPaymentOutputDescriptorNew(outpoint_arg == null ? 0 : outpoint_arg.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(per_commitment_point_arg, 33)), to_self_delay_arg, output_arg.ptr, revocation_pubkey_arg == null ? 0 : revocation_pubkey_arg.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_keys_id_arg, 32)), channel_value_satoshis_arg);
		GC.KeepAlive(outpoint_arg);
		GC.KeepAlive(per_commitment_point_arg);
		GC.KeepAlive(to_self_delay_arg);
		GC.KeepAlive(output_arg);
		GC.KeepAlive(revocation_pubkey_arg);
		GC.KeepAlive(channel_keys_id_arg);
		GC.KeepAlive(channel_value_satoshis_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentOutputDescriptor ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentOutputDescriptor(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(outpoint_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(revocation_pubkey_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.DelayedPaymentOutputDescriptorClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the DelayedPaymentOutputDescriptor
	 */
	public DelayedPaymentOutputDescriptor clone() {
		long ret = Bindings.DelayedPaymentOutputDescriptorClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentOutputDescriptor ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentOutputDescriptor(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the DelayedPaymentOutputDescriptor.
	 */
	public long hash() {
		long ret = Bindings.DelayedPaymentOutputDescriptorHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two DelayedPaymentOutputDescriptors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.DelayedPaymentOutputDescriptor b) {
		bool ret = Bindings.DelayedPaymentOutputDescriptorEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is DelayedPaymentOutputDescriptor)) return false;
		return this.eq((DelayedPaymentOutputDescriptor)o);
	}
	/**
	 * Serialize the DelayedPaymentOutputDescriptor object into a byte array which can be read by DelayedPaymentOutputDescriptor_read
	 */
	public byte[] write() {
		long ret = Bindings.DelayedPaymentOutputDescriptorWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a DelayedPaymentOutputDescriptor from a byte array, created by DelayedPaymentOutputDescriptor_write
	 */
	public static Result_DelayedPaymentOutputDescriptorDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.DelayedPaymentOutputDescriptorRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_DelayedPaymentOutputDescriptorDecodeErrorZ ret_hu_conv = Result_DelayedPaymentOutputDescriptorDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
