using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Details about the balance(s) available for spending once the channel appears on chain.
 * 
 * See [`ChannelMonitor::get_claimable_balances`] for more details on when these will or will not
 * be provided.
 */
public class Balance : CommonBase {
	protected Balance(object _dummy, long ptr) : base(ptr) { }
	~Balance() {
		if (ptr != 0) { Bindings.BalanceFree(ptr); }
	}

	internal static Balance constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKBalanceTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Balance_ClaimableOnChannelClose(ptr);
			case 1: return new Balance_ClaimableAwaitingConfirmations(ptr);
			case 2: return new Balance_ContentiousClaimable(ptr);
			case 3: return new Balance_MaybeTimeoutClaimableHTLC(ptr);
			case 4: return new Balance_MaybePreimageClaimableHTLC(ptr);
			case 5: return new Balance_CounterpartyRevokedOutputClaimable(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Balance of type ClaimableOnChannelClose */
	public class Balance_ClaimableOnChannelClose : Balance {
		/**
		 * The amount available to claim, in satoshis, excluding the on-chain fees which will be
		 * required to do so.
		 */
		public long amount_satoshis;
		internal Balance_ClaimableOnChannelClose(long ptr) : base(null, ptr) {
			this.amount_satoshis = Bindings.LDKBalanceClaimableOnChannelCloseGetAmountSatoshis(ptr);
		}
	}
	/** A Balance of type ClaimableAwaitingConfirmations */
	public class Balance_ClaimableAwaitingConfirmations : Balance {
		/**
		 * The amount available to claim, in satoshis, possibly excluding the on-chain fees which
		 * were spent in broadcasting the transaction.
		 */
		public long amount_satoshis;
		/**
		 * The height at which an [`Event::SpendableOutputs`] event will be generated for this
		 * amount.
		 */
		public int confirmation_height;
		internal Balance_ClaimableAwaitingConfirmations(long ptr) : base(null, ptr) {
			this.amount_satoshis = Bindings.LDKBalanceClaimableAwaitingConfirmationsGetAmountSatoshis(ptr);
			this.confirmation_height = Bindings.LDKBalanceClaimableAwaitingConfirmationsGetConfirmationHeight(ptr);
		}
	}
	/** A Balance of type ContentiousClaimable */
	public class Balance_ContentiousClaimable : Balance {
		/**
		 * The amount available to claim, in satoshis, excluding the on-chain fees which will be
		 * required to do so.
		 */
		public long amount_satoshis;
		/**
		 * The height at which the counterparty may be able to claim the balance if we have not
		 * done so.
		 */
		public int timeout_height;
		/**
		 * The payment hash that locks this HTLC.
		 */
		public byte[] payment_hash;
		/**
		 * The preimage that can be used to claim this HTLC.
		 */
		public byte[] payment_preimage;
		internal Balance_ContentiousClaimable(long ptr) : base(null, ptr) {
			this.amount_satoshis = Bindings.LDKBalanceContentiousClaimableGetAmountSatoshis(ptr);
			this.timeout_height = Bindings.LDKBalanceContentiousClaimableGetTimeoutHeight(ptr);
			long payment_hash = Bindings.LDKBalanceContentiousClaimableGetPaymentHash(ptr);
			byte[] payment_hash_conv = InternalUtils.DecodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			long payment_preimage = Bindings.LDKBalanceContentiousClaimableGetPaymentPreimage(ptr);
			byte[] payment_preimage_conv = InternalUtils.DecodeUint8Array(payment_preimage);
			this.payment_preimage = payment_preimage_conv;
		}
	}
	/** A Balance of type MaybeTimeoutClaimableHTLC */
	public class Balance_MaybeTimeoutClaimableHTLC : Balance {
		/**
		 * The amount potentially available to claim, in satoshis, excluding the on-chain fees
		 * which will be required to do so.
		 */
		public long amount_satoshis;
		/**
		 * The height at which we will be able to claim the balance if our counterparty has not
		 * done so.
		 */
		public int claimable_height;
		/**
		 * The payment hash whose preimage our counterparty needs to claim this HTLC.
		 */
		public byte[] payment_hash;
		internal Balance_MaybeTimeoutClaimableHTLC(long ptr) : base(null, ptr) {
			this.amount_satoshis = Bindings.LDKBalanceMaybeTimeoutClaimableHTLCGetAmountSatoshis(ptr);
			this.claimable_height = Bindings.LDKBalanceMaybeTimeoutClaimableHTLCGetClaimableHeight(ptr);
			long payment_hash = Bindings.LDKBalanceMaybeTimeoutClaimableHTLCGetPaymentHash(ptr);
			byte[] payment_hash_conv = InternalUtils.DecodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
		}
	}
	/** A Balance of type MaybePreimageClaimableHTLC */
	public class Balance_MaybePreimageClaimableHTLC : Balance {
		/**
		 * The amount potentially available to claim, in satoshis, excluding the on-chain fees
		 * which will be required to do so.
		 */
		public long amount_satoshis;
		/**
		 * The height at which our counterparty will be able to claim the balance if we have not
		 * yet received the preimage and claimed it ourselves.
		 */
		public int expiry_height;
		/**
		 * The payment hash whose preimage we need to claim this HTLC.
		 */
		public byte[] payment_hash;
		internal Balance_MaybePreimageClaimableHTLC(long ptr) : base(null, ptr) {
			this.amount_satoshis = Bindings.LDKBalanceMaybePreimageClaimableHTLCGetAmountSatoshis(ptr);
			this.expiry_height = Bindings.LDKBalanceMaybePreimageClaimableHTLCGetExpiryHeight(ptr);
			long payment_hash = Bindings.LDKBalanceMaybePreimageClaimableHTLCGetPaymentHash(ptr);
			byte[] payment_hash_conv = InternalUtils.DecodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
		}
	}
	/** A Balance of type CounterpartyRevokedOutputClaimable */
	public class Balance_CounterpartyRevokedOutputClaimable : Balance {
		/**
		 * The amount, in satoshis, of the output which we can claim.
		 * 
		 * Note that for outputs from HTLC balances this may be excluding some on-chain fees that
		 * were already spent.
		 */
		public long amount_satoshis;
		internal Balance_CounterpartyRevokedOutputClaimable(long ptr) : base(null, ptr) {
			this.amount_satoshis = Bindings.LDKBalanceCounterpartyRevokedOutputClaimableGetAmountSatoshis(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.BalanceClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Balance
	 */
	public Balance clone() {
		long ret = Bindings.BalanceClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Balance ret_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ClaimableOnChannelClose-variant Balance
	 */
	public static Balance claimable_on_channel_close(long amount_satoshis) {
		long ret = Bindings.BalanceClaimableOnChannelClose(amount_satoshis);
		GC.KeepAlive(amount_satoshis);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Balance ret_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ClaimableAwaitingConfirmations-variant Balance
	 */
	public static Balance claimable_awaiting_confirmations(long amount_satoshis, int confirmation_height) {
		long ret = Bindings.BalanceClaimableAwaitingConfirmations(amount_satoshis, confirmation_height);
		GC.KeepAlive(amount_satoshis);
		GC.KeepAlive(confirmation_height);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Balance ret_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ContentiousClaimable-variant Balance
	 */
	public static Balance contentious_claimable(long amount_satoshis, int timeout_height, byte[] payment_hash, byte[] payment_preimage) {
		long ret = Bindings.BalanceContentiousClaimable(amount_satoshis, timeout_height, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_hash, 32)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_preimage, 32)));
		GC.KeepAlive(amount_satoshis);
		GC.KeepAlive(timeout_height);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(payment_preimage);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Balance ret_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new MaybeTimeoutClaimableHTLC-variant Balance
	 */
	public static Balance maybe_timeout_claimable_htlc(long amount_satoshis, int claimable_height, byte[] payment_hash) {
		long ret = Bindings.BalanceMaybeTimeoutClaimableHtlc(amount_satoshis, claimable_height, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_hash, 32)));
		GC.KeepAlive(amount_satoshis);
		GC.KeepAlive(claimable_height);
		GC.KeepAlive(payment_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Balance ret_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new MaybePreimageClaimableHTLC-variant Balance
	 */
	public static Balance maybe_preimage_claimable_htlc(long amount_satoshis, int expiry_height, byte[] payment_hash) {
		long ret = Bindings.BalanceMaybePreimageClaimableHtlc(amount_satoshis, expiry_height, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_hash, 32)));
		GC.KeepAlive(amount_satoshis);
		GC.KeepAlive(expiry_height);
		GC.KeepAlive(payment_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Balance ret_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CounterpartyRevokedOutputClaimable-variant Balance
	 */
	public static Balance counterparty_revoked_output_claimable(long amount_satoshis) {
		long ret = Bindings.BalanceCounterpartyRevokedOutputClaimable(amount_satoshis);
		GC.KeepAlive(amount_satoshis);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Balance ret_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two Balances contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.Balance b) {
		bool ret = Bindings.BalanceEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Balance)) return false;
		return this.eq((Balance)o);
	}
	/**
	 * The amount claimable, in satoshis. This excludes balances that we are unsure if we are able
	 * to claim, this is because we are waiting for a preimage or for a timeout to expire. For more
	 * information on these balances see [`Balance::MaybeTimeoutClaimableHTLC`] and
	 * [`Balance::MaybePreimageClaimableHTLC`].
	 * 
	 * On-chain fees required to claim the balance are not included in this amount.
	 */
	public long claimable_amount_satoshis() {
		long ret = Bindings.BalanceClaimableAmountSatoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
