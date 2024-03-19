using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Constraints for relaying over a given [`BlindedHop`].
 * 
 * [`BlindedHop`]: crate::blinded_path::BlindedHop
 */
public class PaymentConstraints : CommonBase {
	internal PaymentConstraints(object _dummy, long ptr) : base(ptr) { }
	~PaymentConstraints() {
		if (ptr != 0) { Bindings.PaymentConstraintsFree(ptr); }
	}

	/**
	 * The maximum total CLTV that is acceptable when relaying a payment over this [`BlindedHop`].
	 */
	public int get_max_cltv_expiry() {
		int ret = Bindings.PaymentConstraintsGetMaxCltvExpiry(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum total CLTV that is acceptable when relaying a payment over this [`BlindedHop`].
	 */
	public void set_max_cltv_expiry(int val) {
		Bindings.PaymentConstraintsSetMaxCltvExpiry(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The minimum value, in msat, that may be accepted by the node corresponding to this
	 * [`BlindedHop`].
	 */
	public long get_htlc_minimum_msat() {
		long ret = Bindings.PaymentConstraintsGetHtlcMinimumMsat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum value, in msat, that may be accepted by the node corresponding to this
	 * [`BlindedHop`].
	 */
	public void set_htlc_minimum_msat(long val) {
		Bindings.PaymentConstraintsSetHtlcMinimumMsat(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PaymentConstraints given each field
	 */
	public static PaymentConstraints of(int max_cltv_expiry_arg, long htlc_minimum_msat_arg) {
		long ret = Bindings.PaymentConstraintsNew(max_cltv_expiry_arg, htlc_minimum_msat_arg);
		GC.KeepAlive(max_cltv_expiry_arg);
		GC.KeepAlive(htlc_minimum_msat_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentConstraints ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentConstraints(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.PaymentConstraintsClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentConstraints
	 */
	public PaymentConstraints clone() {
		long ret = Bindings.PaymentConstraintsClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentConstraints ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentConstraints(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the PaymentConstraints object into a byte array which can be read by PaymentConstraints_read
	 */
	public byte[] write() {
		long ret = Bindings.PaymentConstraintsWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a PaymentConstraints from a byte array, created by PaymentConstraints_write
	 */
	public static Result_PaymentConstraintsDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.PaymentConstraintsRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentConstraintsDecodeErrorZ ret_hu_conv = Result_PaymentConstraintsDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
