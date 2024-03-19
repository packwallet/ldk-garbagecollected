using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Data to construct a [`BlindedHop`] for receiving a payment. This payload is custom to LDK and
 * may not be valid if received by another lightning implementation.
 */
public class ReceiveTlvs : CommonBase {
	internal ReceiveTlvs(object _dummy, long ptr) : base(ptr) { }
	~ReceiveTlvs() {
		if (ptr != 0) { Bindings.ReceiveTlvsFree(ptr); }
	}

	/**
	 * Used to authenticate the sender of a payment to the receiver and tie MPP HTLCs together.
	 */
	public byte[] get_payment_secret() {
		long ret = Bindings.ReceiveTlvsGetPaymentSecret(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Used to authenticate the sender of a payment to the receiver and tie MPP HTLCs together.
	 */
	public void set_payment_secret(byte[] val) {
		Bindings.ReceiveTlvsSetPaymentSecret(this.ptr, InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(val, 32)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constraints for the receiver of this payment.
	 */
	public PaymentConstraints get_payment_constraints() {
		long ret = Bindings.ReceiveTlvsGetPaymentConstraints(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentConstraints ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentConstraints(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constraints for the receiver of this payment.
	 */
	public void set_payment_constraints(org.ldk.structs.PaymentConstraints val) {
		Bindings.ReceiveTlvsSetPaymentConstraints(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Constructs a new ReceiveTlvs given each field
	 */
	public static ReceiveTlvs of(byte[] payment_secret_arg, org.ldk.structs.PaymentConstraints payment_constraints_arg) {
		long ret = Bindings.ReceiveTlvsNew(InternalUtils.EncodeUint8Array(InternalUtils.CheckArrLen(payment_secret_arg, 32)), payment_constraints_arg == null ? 0 : payment_constraints_arg.ptr);
		GC.KeepAlive(payment_secret_arg);
		GC.KeepAlive(payment_constraints_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(payment_constraints_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ReceiveTlvsClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ReceiveTlvs
	 */
	public ReceiveTlvs clone() {
		long ret = Bindings.ReceiveTlvsClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ReceiveTlvs ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ReceiveTlvs(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ReceiveTlvs object into a byte array which can be read by ReceiveTlvs_read
	 */
	public byte[] write() {
		long ret = Bindings.ReceiveTlvsWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
