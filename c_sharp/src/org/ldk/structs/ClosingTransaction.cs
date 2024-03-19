using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * This class tracks the per-transaction information needed to build a closing transaction and will
 * actually build it and sign.
 * 
 * This class can be used inside a signer implementation to generate a signature given the relevant
 * secret key.
 */
public class ClosingTransaction : CommonBase {
	internal ClosingTransaction(object _dummy, long ptr) : base(ptr) { }
	~ClosingTransaction() {
		if (ptr != 0) { Bindings.ClosingTransactionFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.ClosingTransactionClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ClosingTransaction
	 */
	public ClosingTransaction clone() {
		long ret = Bindings.ClosingTransactionClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosingTransaction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ClosingTransaction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ClosingTransaction.
	 */
	public long hash() {
		long ret = Bindings.ClosingTransactionHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ClosingTransactions contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ClosingTransaction b) {
		bool ret = Bindings.ClosingTransactionEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ClosingTransaction)) return false;
		return this.eq((ClosingTransaction)o);
	}
	/**
	 * Construct an object of the class
	 */
	public static ClosingTransaction of(long to_holder_value_sat, long to_counterparty_value_sat, byte[] to_holder_script, byte[] to_counterparty_script, org.ldk.structs.OutPoint funding_outpoint) {
		long ret = Bindings.ClosingTransactionNew(to_holder_value_sat, to_counterparty_value_sat, InternalUtils.EncodeUint8Array(to_holder_script), InternalUtils.EncodeUint8Array(to_counterparty_script), funding_outpoint == null ? 0 : funding_outpoint.ptr);
		GC.KeepAlive(to_holder_value_sat);
		GC.KeepAlive(to_counterparty_value_sat);
		GC.KeepAlive(to_holder_script);
		GC.KeepAlive(to_counterparty_script);
		GC.KeepAlive(funding_outpoint);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosingTransaction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ClosingTransaction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(funding_outpoint); };
		return ret_hu_conv;
	}

	/**
	 * Trust our pre-built transaction.
	 * 
	 * Applies a wrapper which allows access to the transaction.
	 * 
	 * This should only be used if you fully trust the builder of this object. It should not
	 * be used by an external signer - instead use the verify function.
	 */
	public TrustedClosingTransaction trust() {
		long ret = Bindings.ClosingTransactionTrust(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TrustedClosingTransaction ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TrustedClosingTransaction(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Verify our pre-built transaction.
	 * 
	 * Applies a wrapper which allows access to the transaction.
	 * 
	 * An external validating signer must call this method before signing
	 * or using the built transaction.
	 */
	public Result_TrustedClosingTransactionNoneZ verify(org.ldk.structs.OutPoint funding_outpoint) {
		long ret = Bindings.ClosingTransactionVerify(this.ptr, funding_outpoint == null ? 0 : funding_outpoint.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(funding_outpoint);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TrustedClosingTransactionNoneZ ret_hu_conv = Result_TrustedClosingTransactionNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(funding_outpoint); };
		return ret_hu_conv;
	}

	/**
	 * The value to be sent to the holder, or zero if the output will be omitted
	 */
	public long to_holder_value_sat() {
		long ret = Bindings.ClosingTransactionToHolderValueSat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The value to be sent to the counterparty, or zero if the output will be omitted
	 */
	public long to_counterparty_value_sat() {
		long ret = Bindings.ClosingTransactionToCounterpartyValueSat(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The destination of the holder's output
	 */
	public byte[] to_holder_script() {
		long ret = Bindings.ClosingTransactionToHolderScript(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The destination of the counterparty's output
	 */
	public byte[] to_counterparty_script() {
		long ret = Bindings.ClosingTransactionToCounterpartyScript(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
