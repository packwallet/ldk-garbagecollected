using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Late-bound per-channel counterparty data used to build transactions.
 */
public class CounterpartyChannelTransactionParameters : CommonBase {
	internal CounterpartyChannelTransactionParameters(object _dummy, long ptr) : base(ptr) { }
	~CounterpartyChannelTransactionParameters() {
		if (ptr != 0) { Bindings.CounterpartyChannelTransactionParametersFree(ptr); }
	}

	/**
	 * Counter-party public keys
	 */
	public ChannelPublicKeys get_pubkeys() {
		long ret = Bindings.CounterpartyChannelTransactionParametersGetPubkeys(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelPublicKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelPublicKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Counter-party public keys
	 */
	public void set_pubkeys(org.ldk.structs.ChannelPublicKeys val) {
		Bindings.CounterpartyChannelTransactionParametersSetPubkeys(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * The contest delay selected by the counterparty, which applies to holder-broadcast transactions
	 */
	public short get_selected_contest_delay() {
		short ret = Bindings.CounterpartyChannelTransactionParametersGetSelectedContestDelay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The contest delay selected by the counterparty, which applies to holder-broadcast transactions
	 */
	public void set_selected_contest_delay(short val) {
		Bindings.CounterpartyChannelTransactionParametersSetSelectedContestDelay(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new CounterpartyChannelTransactionParameters given each field
	 */
	public static CounterpartyChannelTransactionParameters of(org.ldk.structs.ChannelPublicKeys pubkeys_arg, short selected_contest_delay_arg) {
		long ret = Bindings.CounterpartyChannelTransactionParametersNew(pubkeys_arg == null ? 0 : pubkeys_arg.ptr, selected_contest_delay_arg);
		GC.KeepAlive(pubkeys_arg);
		GC.KeepAlive(selected_contest_delay_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CounterpartyChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CounterpartyChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(pubkeys_arg); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = Bindings.CounterpartyChannelTransactionParametersClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the CounterpartyChannelTransactionParameters
	 */
	public CounterpartyChannelTransactionParameters clone() {
		long ret = Bindings.CounterpartyChannelTransactionParametersClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.CounterpartyChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.CounterpartyChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the CounterpartyChannelTransactionParameters.
	 */
	public long hash() {
		long ret = Bindings.CounterpartyChannelTransactionParametersHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two CounterpartyChannelTransactionParameterss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.CounterpartyChannelTransactionParameters b) {
		bool ret = Bindings.CounterpartyChannelTransactionParametersEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is CounterpartyChannelTransactionParameters)) return false;
		return this.eq((CounterpartyChannelTransactionParameters)o);
	}
	/**
	 * Serialize the CounterpartyChannelTransactionParameters object into a byte array which can be read by CounterpartyChannelTransactionParameters_read
	 */
	public byte[] write() {
		long ret = Bindings.CounterpartyChannelTransactionParametersWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a CounterpartyChannelTransactionParameters from a byte array, created by CounterpartyChannelTransactionParameters_write
	 */
	public static Result_CounterpartyChannelTransactionParametersDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.CounterpartyChannelTransactionParametersRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CounterpartyChannelTransactionParametersDecodeErrorZ ret_hu_conv = Result_CounterpartyChannelTransactionParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
