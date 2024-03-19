using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Intended destination of a failed HTLC as indicated in [`Event::HTLCHandlingFailed`].
 */
public class HTLCDestination : CommonBase {
	protected HTLCDestination(object _dummy, long ptr) : base(ptr) { }
	~HTLCDestination() {
		if (ptr != 0) { Bindings.HTLCDestinationFree(ptr); }
	}

	internal static HTLCDestination constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKHTLCDestinationTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new HTLCDestination_NextHopChannel(ptr);
			case 1: return new HTLCDestination_UnknownNextHop(ptr);
			case 2: return new HTLCDestination_InvalidForward(ptr);
			case 3: return new HTLCDestination_FailedPayment(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A HTLCDestination of type NextHopChannel */
	public class HTLCDestination_NextHopChannel : HTLCDestination {
		/**
		 * The `node_id` of the next node. For backwards compatibility, this field is
		 * marked as optional, versions prior to 0.0.110 may not always be able to provide
		 * counterparty node information.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public byte[] node_id;
		/**
		 * The outgoing `channel_id` between us and the next node.
		 */
		public byte[] channel_id;
		internal HTLCDestination_NextHopChannel(long ptr) : base(null, ptr) {
			long node_id = Bindings.LDKHTLCDestinationNextHopChannelGetNodeId(ptr);
			byte[] node_id_conv = InternalUtils.DecodeUint8Array(node_id);
			this.node_id = node_id_conv;
			long channel_id = Bindings.LDKHTLCDestinationNextHopChannelGetChannelId(ptr);
			byte[] channel_id_conv = InternalUtils.DecodeUint8Array(channel_id);
			this.channel_id = channel_id_conv;
		}
	}
	/** A HTLCDestination of type UnknownNextHop */
	public class HTLCDestination_UnknownNextHop : HTLCDestination {
		/**
		 * Short channel id we are requesting to forward an HTLC to.
		 */
		public long requested_forward_scid;
		internal HTLCDestination_UnknownNextHop(long ptr) : base(null, ptr) {
			this.requested_forward_scid = Bindings.LDKHTLCDestinationUnknownNextHopGetRequestedForwardScid(ptr);
		}
	}
	/** A HTLCDestination of type InvalidForward */
	public class HTLCDestination_InvalidForward : HTLCDestination {
		/**
		 * Short channel id we are requesting to forward an HTLC to.
		 */
		public long requested_forward_scid;
		internal HTLCDestination_InvalidForward(long ptr) : base(null, ptr) {
			this.requested_forward_scid = Bindings.LDKHTLCDestinationInvalidForwardGetRequestedForwardScid(ptr);
		}
	}
	/** A HTLCDestination of type FailedPayment */
	public class HTLCDestination_FailedPayment : HTLCDestination {
		/**
		 * The payment hash of the payment we attempted to process.
		 */
		public byte[] payment_hash;
		internal HTLCDestination_FailedPayment(long ptr) : base(null, ptr) {
			long payment_hash = Bindings.LDKHTLCDestinationFailedPaymentGetPaymentHash(ptr);
			byte[] payment_hash_conv = InternalUtils.DecodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.HTLCDestinationClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the HTLCDestination
	 */
	public HTLCDestination clone() {
		long ret = Bindings.HTLCDestinationClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new NextHopChannel-variant HTLCDestination
	 */
	public static HTLCDestination next_hop_channel(byte[] node_id, byte[] channel_id) {
		long ret = Bindings.HTLCDestinationNextHopChannel(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(node_id, 33)), InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(channel_id, 32)));
		GC.KeepAlive(node_id);
		GC.KeepAlive(channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new UnknownNextHop-variant HTLCDestination
	 */
	public static HTLCDestination unknown_next_hop(long requested_forward_scid) {
		long ret = Bindings.HTLCDestinationUnknownNextHop(requested_forward_scid);
		GC.KeepAlive(requested_forward_scid);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvalidForward-variant HTLCDestination
	 */
	public static HTLCDestination invalid_forward(long requested_forward_scid) {
		long ret = Bindings.HTLCDestinationInvalidForward(requested_forward_scid);
		GC.KeepAlive(requested_forward_scid);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new FailedPayment-variant HTLCDestination
	 */
	public static HTLCDestination failed_payment(byte[] payment_hash) {
		long ret = Bindings.HTLCDestinationFailedPayment(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_hash, 32)));
		GC.KeepAlive(payment_hash);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HTLCDestination ret_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two HTLCDestinations contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.HTLCDestination b) {
		bool ret = Bindings.HTLCDestinationEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is HTLCDestination)) return false;
		return this.eq((HTLCDestination)o);
	}
	/**
	 * Serialize the HTLCDestination object into a byte array which can be read by HTLCDestination_read
	 */
	public byte[] write() {
		long ret = Bindings.HTLCDestinationWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
