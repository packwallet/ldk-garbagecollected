using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Some information provided on receipt of payment depends on whether the payment received is a
 * spontaneous payment or a \"conventional\" lightning payment that's paying an invoice.
 */
public class PaymentPurpose : CommonBase {
	protected PaymentPurpose(object _dummy, long ptr) : base(ptr) { }
	~PaymentPurpose() {
		if (ptr != 0) { Bindings.PaymentPurposeFree(ptr); }
	}

	internal static PaymentPurpose constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKPaymentPurposeTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new PaymentPurpose_InvoicePayment(ptr);
			case 1: return new PaymentPurpose_SpontaneousPayment(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A PaymentPurpose of type InvoicePayment */
	public class PaymentPurpose_InvoicePayment : PaymentPurpose {
		/**
		 * The preimage to the payment_hash, if the payment hash (and secret) were fetched via
		 * [`ChannelManager::create_inbound_payment`]. If provided, this can be handed directly to
		 * [`ChannelManager::claim_funds`].
		 * 
		 * [`ChannelManager::create_inbound_payment`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		 */
		public Option_ThirtyTwoBytesZ payment_preimage;
		/**
		 * The \"payment secret\". This authenticates the sender to the recipient, preventing a
		 * number of deanonymization attacks during the routing process.
		 * It is provided here for your reference, however its accuracy is enforced directly by
		 * [`ChannelManager`] using the values you previously provided to
		 * [`ChannelManager::create_inbound_payment`] or
		 * [`ChannelManager::create_inbound_payment_for_hash`].
		 * 
		 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
		 * [`ChannelManager::create_inbound_payment`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment
		 * [`ChannelManager::create_inbound_payment_for_hash`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment_for_hash
		 */
		public byte[] payment_secret;
		internal PaymentPurpose_InvoicePayment(long ptr) : base(null, ptr) {
			long payment_preimage = Bindings.LDKPaymentPurposeInvoicePaymentGetPaymentPreimage(ptr);
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_preimage);
			if (payment_preimage_hu_conv != null) { payment_preimage_hu_conv.ptrs_to.AddLast(this); };
			this.payment_preimage = payment_preimage_hu_conv;
			long payment_secret = Bindings.LDKPaymentPurposeInvoicePaymentGetPaymentSecret(ptr);
			byte[] payment_secret_conv = InternalUtils.DecodeUint8Array(payment_secret);
			this.payment_secret = payment_secret_conv;
		}
	}
	/** A PaymentPurpose of type SpontaneousPayment */
	public class PaymentPurpose_SpontaneousPayment : PaymentPurpose {
		public byte[] spontaneous_payment;
		internal PaymentPurpose_SpontaneousPayment(long ptr) : base(null, ptr) {
			long spontaneous_payment = Bindings.LDKPaymentPurposeSpontaneousPaymentGetSpontaneousPayment(ptr);
			byte[] spontaneous_payment_conv = InternalUtils.DecodeUint8Array(spontaneous_payment);
			this.spontaneous_payment = spontaneous_payment_conv;
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.PaymentPurposeClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentPurpose
	 */
	public PaymentPurpose clone() {
		long ret = Bindings.PaymentPurposeClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoicePayment-variant PaymentPurpose
	 */
	public static PaymentPurpose invoice_payment(org.ldk.structs.Option_ThirtyTwoBytesZ payment_preimage, byte[] payment_secret) {
		long ret = Bindings.PaymentPurposeInvoicePayment(payment_preimage.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_secret, 32)));
		GC.KeepAlive(payment_preimage);
		GC.KeepAlive(payment_secret);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(payment_preimage); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SpontaneousPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose spontaneous_payment(byte[] a) {
		long ret = Bindings.PaymentPurposeSpontaneousPayment(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(a, 32)));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two PaymentPurposes contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.PaymentPurpose b) {
		bool ret = Bindings.PaymentPurposeEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is PaymentPurpose)) return false;
		return this.eq((PaymentPurpose)o);
	}
	/**
	 * Returns the preimage for this payment, if it is known.
	 */
	public Option_ThirtyTwoBytesZ preimage() {
		long ret = Bindings.PaymentPurposePreimage(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_ThirtyTwoBytesZ ret_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the PaymentPurpose object into a byte array which can be read by PaymentPurpose_read
	 */
	public byte[] write() {
		long ret = Bindings.PaymentPurposeWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a PaymentPurpose from a byte array, created by PaymentPurpose_write
	 */
	public static Result_PaymentPurposeDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.PaymentPurposeRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentPurposeDecodeErrorZ ret_hu_conv = Result_PaymentPurposeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
