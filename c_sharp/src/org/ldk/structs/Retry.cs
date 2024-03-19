using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Strategies available to retry payment path failures.
 */
public class Retry : CommonBase {
	protected Retry(object _dummy, long ptr) : base(ptr) { }
	~Retry() {
		if (ptr != 0) { Bindings.RetryFree(ptr); }
	}

	internal static Retry constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKRetryTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new Retry_Attempts(ptr);
			case 1: return new Retry_Timeout(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Retry of type Attempts */
	public class Retry_Attempts : Retry {
		public int attempts;
		internal Retry_Attempts(long ptr) : base(null, ptr) {
			this.attempts = Bindings.LDKRetryAttemptsGetAttempts(ptr);
		}
	}
	/** A Retry of type Timeout */
	public class Retry_Timeout : Retry {
		public long timeout;
		internal Retry_Timeout(long ptr) : base(null, ptr) {
			this.timeout = Bindings.LDKRetryTimeoutGetTimeout(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.RetryClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Retry
	 */
	public Retry clone() {
		long ret = Bindings.RetryClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Retry ret_hu_conv = org.ldk.structs.Retry.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Attempts-variant Retry
	 */
	public static Retry attempts(int a) {
		long ret = Bindings.RetryAttempts(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Retry ret_hu_conv = org.ldk.structs.Retry.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Timeout-variant Retry
	 */
	public static Retry timeout(long a) {
		long ret = Bindings.RetryTimeout(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Retry ret_hu_conv = org.ldk.structs.Retry.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two Retrys contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.Retry b) {
		bool ret = Bindings.RetryEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Retry)) return false;
		return this.eq((Retry)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the Retry.
	 */
	public long hash() {
		long ret = Bindings.RetryHash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Serialize the Retry object into a byte array which can be read by Retry_read
	 */
	public byte[] write() {
		long ret = Bindings.RetryWrite(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a Retry from a byte array, created by Retry_write
	 */
	public static Result_RetryDecodeErrorZ read(byte[] ser) {
		long ret = Bindings.RetryRead(InternalUtils.EncodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RetryDecodeErrorZ ret_hu_conv = Result_RetryDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
