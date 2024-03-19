using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The minimum and maximum fees which the sender is willing to place on the closing transaction.
 * 
 * This is provided in [`ClosingSigned`] by both sides to indicate the fee range they are willing
 * to use.
 */
public class ClosingSignedFeeRange : CommonBase {
	internal ClosingSignedFeeRange(object _dummy, long ptr) : base(ptr) { }
	~ClosingSignedFeeRange() {
		if (ptr != 0) { Bindings.ClosingSignedFeeRangeFree(ptr); }
	}

	/**
	 * The minimum absolute fee, in satoshis, which the sender is willing to place on the closing
	 * transaction.
	 */
	public long get_min_fee_satoshis() {
		long ret = Bindings.ClosingSignedFeeRangeGetMinFeeSatoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The minimum absolute fee, in satoshis, which the sender is willing to place on the closing
	 * transaction.
	 */
	public void set_min_fee_satoshis(long val) {
		Bindings.ClosingSignedFeeRangeSetMinFeeSatoshis(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum absolute fee, in satoshis, which the sender is willing to place on the closing
	 * transaction.
	 */
	public long get_max_fee_satoshis() {
		long ret = Bindings.ClosingSignedFeeRangeGetMaxFeeSatoshis(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum absolute fee, in satoshis, which the sender is willing to place on the closing
	 * transaction.
	 */
	public void set_max_fee_satoshis(long val) {
		Bindings.ClosingSignedFeeRangeSetMaxFeeSatoshis(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ClosingSignedFeeRange given each field
	 */
	public static ClosingSignedFeeRange of(long min_fee_satoshis_arg, long max_fee_satoshis_arg) {
		long ret = Bindings.ClosingSignedFeeRangeNew(min_fee_satoshis_arg, max_fee_satoshis_arg);
		GC.KeepAlive(min_fee_satoshis_arg);
		GC.KeepAlive(max_fee_satoshis_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosingSignedFeeRange ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ClosingSignedFeeRange(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.ClosingSignedFeeRangeClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ClosingSignedFeeRange
	 */
	public ClosingSignedFeeRange clone() {
		long ret = Bindings.ClosingSignedFeeRangeClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ClosingSignedFeeRange ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ClosingSignedFeeRange(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ClosingSignedFeeRange.
	 */
	public long hash() {
		long ret = Bindings.ClosingSignedFeeRangeHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ClosingSignedFeeRanges contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ClosingSignedFeeRange b) {
		bool ret = Bindings.ClosingSignedFeeRangeEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ClosingSignedFeeRange)) return false;
		return this.eq((ClosingSignedFeeRange)o);
	}
	/**
	 * Serialize the ClosingSignedFeeRange object into a byte array which can be read by ClosingSignedFeeRange_read
	 */
	public byte[] write() {
		long ret = Bindings.ClosingSignedFeeRangeWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ClosingSignedFeeRange from a byte array, created by ClosingSignedFeeRange_write
	 */
	public static Result_ClosingSignedFeeRangeDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.ClosingSignedFeeRangeRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ClosingSignedFeeRangeDecodeErrorZ ret_hu_conv = Result_ClosingSignedFeeRangeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
