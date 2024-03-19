using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Represents the different types of transactions, originating from LDK, to be bumped.
 */
public class BumpTransactionEvent : CommonBase {
	protected BumpTransactionEvent(object _dummy, long ptr) : base(ptr) { }
	~BumpTransactionEvent() {
		if (ptr != 0) { Bindings.BumpTransactionEventFree(ptr); }
	}

	internal static BumpTransactionEvent constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKBumpTransactionEventTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new BumpTransactionEvent_ChannelClose(ptr);
			case 1: return new BumpTransactionEvent_HTLCResolution(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A BumpTransactionEvent of type ChannelClose */
	public class BumpTransactionEvent_ChannelClose : BumpTransactionEvent {
		/**
		 * The unique identifier for the claim of the anchor output in the commitment transaction.
		 * 
		 * The identifier must map to the set of external UTXOs assigned to the claim, such that
		 * they can be reused when a new claim with the same identifier needs to be made, resulting
		 * in a fee-bumping attempt.
		 */
		public byte[] claim_id;
		/**
		 * The target feerate that the transaction package, which consists of the commitment
		 * transaction and the to-be-crafted child anchor transaction, must meet.
		 */
		public int package_target_feerate_sat_per_1000_weight;
		/**
		 * The channel's commitment transaction to bump the fee of. This transaction should be
		 * broadcast along with the anchor transaction constructed as a result of consuming this
		 * event.
		 */
		public byte[] commitment_tx;
		/**
		 * The absolute fee in satoshis of the commitment transaction. This can be used along the
		 * with weight of the commitment transaction to determine its feerate.
		 */
		public long commitment_tx_fee_satoshis;
		/**
		 * The descriptor to sign the anchor input of the anchor transaction constructed as a
		 * result of consuming this event.
		 */
		public AnchorDescriptor anchor_descriptor;
		/**
		 * The set of pending HTLCs on the commitment transaction that need to be resolved once the
		 * commitment transaction confirms.
		 */
		public HTLCOutputInCommitment[] pending_htlcs;
		internal BumpTransactionEvent_ChannelClose(long ptr) : base(null, ptr) {
			long claim_id = Bindings.LDKBumpTransactionEventChannelCloseGetClaimId(ptr);
			byte[] claim_id_conv = InternalUtils.DecodeUint8Array(claim_id);
			this.claim_id = claim_id_conv;
			this.package_target_feerate_sat_per_1000_weight = Bindings.LDKBumpTransactionEventChannelCloseGetPackageTargetFeerateSatPer1000Weight(ptr);
			long commitment_tx = Bindings.LDKBumpTransactionEventChannelCloseGetCommitmentTx(ptr);
			byte[] commitment_tx_conv = InternalUtils.DecodeUint8Array(commitment_tx);
			this.commitment_tx = commitment_tx_conv;
			this.commitment_tx_fee_satoshis = Bindings.LDKBumpTransactionEventChannelCloseGetCommitmentTxFeeSatoshis(ptr);
			long anchor_descriptor = Bindings.LDKBumpTransactionEventChannelCloseGetAnchorDescriptor(ptr);
			org.ldk.structs.AnchorDescriptor anchor_descriptor_hu_conv = null; if (anchor_descriptor < 0 || anchor_descriptor > 4096) { anchor_descriptor_hu_conv = new org.ldk.structs.AnchorDescriptor(null, anchor_descriptor); }
			if (anchor_descriptor_hu_conv != null) { anchor_descriptor_hu_conv.ptrs_to.AddLast(this); };
			this.anchor_descriptor = anchor_descriptor_hu_conv;
			long pending_htlcs = Bindings.LDKBumpTransactionEventChannelCloseGetPendingHtlcs(ptr);
			int pending_htlcs_conv_24_len = InternalUtils.GetArrayLength(pending_htlcs);
			HTLCOutputInCommitment[] pending_htlcs_conv_24_arr = new HTLCOutputInCommitment[pending_htlcs_conv_24_len];
			for (int y = 0; y < pending_htlcs_conv_24_len; y++) {
				long pending_htlcs_conv_24 = InternalUtils.GetU64ArrayElem(pending_htlcs, y);
				org.ldk.structs.HTLCOutputInCommitment pending_htlcs_conv_24_hu_conv = null; if (pending_htlcs_conv_24 < 0 || pending_htlcs_conv_24 > 4096) { pending_htlcs_conv_24_hu_conv = new org.ldk.structs.HTLCOutputInCommitment(null, pending_htlcs_conv_24); }
				if (pending_htlcs_conv_24_hu_conv != null) { pending_htlcs_conv_24_hu_conv.ptrs_to.AddLast(this); };
				pending_htlcs_conv_24_arr[y] = pending_htlcs_conv_24_hu_conv;
			}
			Bindings.FreeBuffer(pending_htlcs);
			this.pending_htlcs = pending_htlcs_conv_24_arr;
		}
	}
	/** A BumpTransactionEvent of type HTLCResolution */
	public class BumpTransactionEvent_HTLCResolution : BumpTransactionEvent {
		/**
		 * The unique identifier for the claim of the HTLCs in the confirmed commitment
		 * transaction.
		 * 
		 * The identifier must map to the set of external UTXOs assigned to the claim, such that
		 * they can be reused when a new claim with the same identifier needs to be made, resulting
		 * in a fee-bumping attempt.
		 */
		public byte[] claim_id;
		/**
		 * The target feerate that the resulting HTLC transaction must meet.
		 */
		public int target_feerate_sat_per_1000_weight;
		/**
		 * The set of pending HTLCs on the confirmed commitment that need to be claimed, preferably
		 * by the same transaction.
		 */
		public HTLCDescriptor[] htlc_descriptors;
		/**
		 * The locktime required for the resulting HTLC transaction.
		 */
		public int tx_lock_time;
		internal BumpTransactionEvent_HTLCResolution(long ptr) : base(null, ptr) {
			long claim_id = Bindings.LDKBumpTransactionEventHTLCResolutionGetClaimId(ptr);
			byte[] claim_id_conv = InternalUtils.DecodeUint8Array(claim_id);
			this.claim_id = claim_id_conv;
			this.target_feerate_sat_per_1000_weight = Bindings.LDKBumpTransactionEventHTLCResolutionGetTargetFeerateSatPer1000Weight(ptr);
			long htlc_descriptors = Bindings.LDKBumpTransactionEventHTLCResolutionGetHtlcDescriptors(ptr);
			int htlc_descriptors_conv_16_len = InternalUtils.GetArrayLength(htlc_descriptors);
			HTLCDescriptor[] htlc_descriptors_conv_16_arr = new HTLCDescriptor[htlc_descriptors_conv_16_len];
			for (int q = 0; q < htlc_descriptors_conv_16_len; q++) {
				long htlc_descriptors_conv_16 = InternalUtils.GetU64ArrayElem(htlc_descriptors, q);
				org.ldk.structs.HTLCDescriptor htlc_descriptors_conv_16_hu_conv = null; if (htlc_descriptors_conv_16 < 0 || htlc_descriptors_conv_16 > 4096) { htlc_descriptors_conv_16_hu_conv = new org.ldk.structs.HTLCDescriptor(null, htlc_descriptors_conv_16); }
				if (htlc_descriptors_conv_16_hu_conv != null) { htlc_descriptors_conv_16_hu_conv.ptrs_to.AddLast(this); };
				htlc_descriptors_conv_16_arr[q] = htlc_descriptors_conv_16_hu_conv;
			}
			Bindings.FreeBuffer(htlc_descriptors);
			this.htlc_descriptors = htlc_descriptors_conv_16_arr;
			this.tx_lock_time = Bindings.LDKBumpTransactionEventHTLCResolutionGetTxLockTime(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.BumpTransactionEventClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BumpTransactionEvent
	 */
	public BumpTransactionEvent clone() {
		long ret = Bindings.BumpTransactionEventClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BumpTransactionEvent ret_hu_conv = org.ldk.structs.BumpTransactionEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ChannelClose-variant BumpTransactionEvent
	 */
	public static BumpTransactionEvent channel_close(byte[] claim_id, int package_target_feerate_sat_per_1000_weight, byte[] commitment_tx, long commitment_tx_fee_satoshis, org.ldk.structs.AnchorDescriptor anchor_descriptor, HTLCOutputInCommitment[] pending_htlcs) {
		long ret = Bindings.BumpTransactionEventChannelClose(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(claim_id, 32)), package_target_feerate_sat_per_1000_weight, InternalUtils.EncodeUint8Array(commitment_tx), commitment_tx_fee_satoshis, anchor_descriptor == null ? 0 : anchor_descriptor.ptr, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(pending_htlcs, pending_htlcs_conv_24 => pending_htlcs_conv_24 == null ? 0 : pending_htlcs_conv_24.ptr)));
		GC.KeepAlive(claim_id);
		GC.KeepAlive(package_target_feerate_sat_per_1000_weight);
		GC.KeepAlive(commitment_tx);
		GC.KeepAlive(commitment_tx_fee_satoshis);
		GC.KeepAlive(anchor_descriptor);
		GC.KeepAlive(pending_htlcs);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BumpTransactionEvent ret_hu_conv = org.ldk.structs.BumpTransactionEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(anchor_descriptor); };
		foreach (HTLCOutputInCommitment pending_htlcs_conv_24 in pending_htlcs) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(pending_htlcs_conv_24); }; };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new HTLCResolution-variant BumpTransactionEvent
	 */
	public static BumpTransactionEvent htlcresolution(byte[] claim_id, int target_feerate_sat_per_1000_weight, HTLCDescriptor[] htlc_descriptors, int tx_lock_time) {
		long ret = Bindings.BumpTransactionEventHtlcresolution(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(claim_id, 32)), target_feerate_sat_per_1000_weight, InternalUtils.EncodeUint64Array(InternalUtils.MapArray(htlc_descriptors, htlc_descriptors_conv_16 => htlc_descriptors_conv_16 == null ? 0 : htlc_descriptors_conv_16.ptr)), tx_lock_time);
		GC.KeepAlive(claim_id);
		GC.KeepAlive(target_feerate_sat_per_1000_weight);
		GC.KeepAlive(htlc_descriptors);
		GC.KeepAlive(tx_lock_time);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BumpTransactionEvent ret_hu_conv = org.ldk.structs.BumpTransactionEvent.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (HTLCDescriptor htlc_descriptors_conv_16 in htlc_descriptors) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(htlc_descriptors_conv_16); }; };
		return ret_hu_conv;
	}

	/**
	 * Checks if two BumpTransactionEvents contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.BumpTransactionEvent b) {
		bool ret = Bindings.BumpTransactionEventEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is BumpTransactionEvent)) return false;
		return this.eq((BumpTransactionEvent)o);
	}
}
} } }
