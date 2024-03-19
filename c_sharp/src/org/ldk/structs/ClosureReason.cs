using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * The reason the channel was closed. See individual variants for more details.
 */
public class ClosureReason : CommonBase {
	protected ClosureReason(object _dummy, long ptr) : base(ptr) { }
	~ClosureReason() {
		if (ptr != 0) { Bindings.ClosureReasonFree(ptr); }
	}

	internal static ClosureReason constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKClosureReasonTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new ClosureReason_CounterpartyForceClosed(ptr);
			case 1: return new ClosureReason_HolderForceClosed(ptr);
			case 2: return new ClosureReason_CooperativeClosure(ptr);
			case 3: return new ClosureReason_CommitmentTxConfirmed(ptr);
			case 4: return new ClosureReason_FundingTimedOut(ptr);
			case 5: return new ClosureReason_ProcessingError(ptr);
			case 6: return new ClosureReason_DisconnectedPeer(ptr);
			case 7: return new ClosureReason_OutdatedChannelManager(ptr);
			case 8: return new ClosureReason_CounterpartyCoopClosedUnfundedChannel(ptr);
			case 9: return new ClosureReason_FundingBatchClosure(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A ClosureReason of type CounterpartyForceClosed */
	public class ClosureReason_CounterpartyForceClosed : ClosureReason {
		/**
		 * The error which the peer sent us.
		 * 
		 * Be careful about printing the peer_msg, a well-crafted message could exploit
		 * a security vulnerability in the terminal emulator or the logging subsystem.
		 * To be safe, use `Display` on `UntrustedString`
		 * 
		 * [`UntrustedString`]: crate::util::string::UntrustedString
		 */
		public UntrustedString peer_msg;
		internal ClosureReason_CounterpartyForceClosed(long ptr) : base(null, ptr) {
			long peer_msg = Bindings.LDKClosureReasonCounterpartyForceClosedGetPeerMsg(ptr);
			org.ldk.structs.UntrustedString peer_msg_hu_conv = null; if (peer_msg < 0 || peer_msg > 4096) { peer_msg_hu_conv = new org.ldk.structs.UntrustedString(null, peer_msg); }
			if (peer_msg_hu_conv != null) { peer_msg_hu_conv.ptrs_to.AddLast(this); };
			this.peer_msg = peer_msg_hu_conv;
		}
	}
	/** A ClosureReason of type HolderForceClosed */
	public class ClosureReason_HolderForceClosed : ClosureReason {
		internal ClosureReason_HolderForceClosed(long ptr) : base(null, ptr) {
		}
	}
	/** A ClosureReason of type CooperativeClosure */
	public class ClosureReason_CooperativeClosure : ClosureReason {
		internal ClosureReason_CooperativeClosure(long ptr) : base(null, ptr) {
		}
	}
	/** A ClosureReason of type CommitmentTxConfirmed */
	public class ClosureReason_CommitmentTxConfirmed : ClosureReason {
		internal ClosureReason_CommitmentTxConfirmed(long ptr) : base(null, ptr) {
		}
	}
	/** A ClosureReason of type FundingTimedOut */
	public class ClosureReason_FundingTimedOut : ClosureReason {
		internal ClosureReason_FundingTimedOut(long ptr) : base(null, ptr) {
		}
	}
	/** A ClosureReason of type ProcessingError */
	public class ClosureReason_ProcessingError : ClosureReason {
		/**
		 * A developer-readable error message which we generated.
		 */
		public string err;
		internal ClosureReason_ProcessingError(long ptr) : base(null, ptr) {
			long err = Bindings.LDKClosureReasonProcessingErrorGetErr(ptr);
			string err_conv = InternalUtils.DecodeString(err);
			this.err = err_conv;
		}
	}
	/** A ClosureReason of type DisconnectedPeer */
	public class ClosureReason_DisconnectedPeer : ClosureReason {
		internal ClosureReason_DisconnectedPeer(long ptr) : base(null, ptr) {
		}
	}
	/** A ClosureReason of type OutdatedChannelManager */
	public class ClosureReason_OutdatedChannelManager : ClosureReason {
		internal ClosureReason_OutdatedChannelManager(long ptr) : base(null, ptr) {
		}
	}
	/** A ClosureReason of type CounterpartyCoopClosedUnfundedChannel */
	public class ClosureReason_CounterpartyCoopClosedUnfundedChannel : ClosureReason {
		internal ClosureReason_CounterpartyCoopClosedUnfundedChannel(long ptr) : base(null, ptr) {
		}
	}
	/** A ClosureReason of type FundingBatchClosure */
	public class ClosureReason_FundingBatchClosure : ClosureReason {
		internal ClosureReason_FundingBatchClosure(long ptr) : base(null, ptr) {
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.ClosureReasonClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ClosureReason
	 */
	public ClosureReason clone() {
		long ret = Bindings.ClosureReasonClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CounterpartyForceClosed-variant ClosureReason
	 */
	public static ClosureReason counterparty_force_closed(org.ldk.structs.UntrustedString peer_msg) {
		long ret = Bindings.ClosureReasonCounterpartyForceClosed(peer_msg == null ? 0 : peer_msg.ptr);
		GC.KeepAlive(peer_msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(peer_msg); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new HolderForceClosed-variant ClosureReason
	 */
	public static ClosureReason holder_force_closed() {
		long ret = Bindings.ClosureReasonHolderForceClosed();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CooperativeClosure-variant ClosureReason
	 */
	public static ClosureReason cooperative_closure() {
		long ret = Bindings.ClosureReasonCooperativeClosure();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CommitmentTxConfirmed-variant ClosureReason
	 */
	public static ClosureReason commitment_tx_confirmed() {
		long ret = Bindings.ClosureReasonCommitmentTxConfirmed();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new FundingTimedOut-variant ClosureReason
	 */
	public static ClosureReason funding_timed_out() {
		long ret = Bindings.ClosureReasonFundingTimedOut();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ProcessingError-variant ClosureReason
	 */
	public static ClosureReason processing_error(string err) {
		long ret = Bindings.ClosureReasonProcessingError(InternalUtils.EncodeString(err));
		GC.KeepAlive(err);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DisconnectedPeer-variant ClosureReason
	 */
	public static ClosureReason disconnected_peer() {
		long ret = Bindings.ClosureReasonDisconnectedPeer();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OutdatedChannelManager-variant ClosureReason
	 */
	public static ClosureReason outdated_channel_manager() {
		long ret = Bindings.ClosureReasonOutdatedChannelManager();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CounterpartyCoopClosedUnfundedChannel-variant ClosureReason
	 */
	public static ClosureReason counterparty_coop_closed_unfunded_channel() {
		long ret = Bindings.ClosureReasonCounterpartyCoopClosedUnfundedChannel();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new FundingBatchClosure-variant ClosureReason
	 */
	public static ClosureReason funding_batch_closure() {
		long ret = Bindings.ClosureReasonFundingBatchClosure();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosureReason ret_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ClosureReasons contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.ClosureReason b) {
		bool ret = Bindings.ClosureReasonEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ClosureReason)) return false;
		return this.eq((ClosureReason)o);
	}
	/**
	 * Serialize the ClosureReason object into a byte array which can be read by ClosureReason_read
	 */
	public byte[] write() {
		long ret = Bindings.ClosureReasonWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
