using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * When signing using a fallible method either an user-supplied `SignError` or a [`CreationError`]
 * may occur.
 */
public class SignOrCreationError : CommonBase {
	protected SignOrCreationError(object _dummy, long ptr) : base(ptr) { }
	~SignOrCreationError() {
		if (ptr != 0) { Bindings.SignOrCreationErrorFree(ptr); }
	}

	internal static SignOrCreationError constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKSignOrCreationErrorTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new SignOrCreationError_SignError(ptr);
			case 1: return new SignOrCreationError_CreationError(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A SignOrCreationError of type SignError */
	public class SignOrCreationError_SignError : SignOrCreationError {
		internal SignOrCreationError_SignError(long ptr) : base(null, ptr) {
		}
	}
	/** A SignOrCreationError of type CreationError */
	public class SignOrCreationError_CreationError : SignOrCreationError {
		public CreationError creation_error;
		internal SignOrCreationError_CreationError(long ptr) : base(null, ptr) {
			this.creation_error = Bindings.LDKSignOrCreationErrorCreationErrorGetCreationError(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.SignOrCreationErrorClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the SignOrCreationError
	 */
	public SignOrCreationError clone() {
		long ret = Bindings.SignOrCreationErrorClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignOrCreationError ret_hu_conv = org.ldk.structs.SignOrCreationError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SignError-variant SignOrCreationError
	 */
	public static SignOrCreationError sign_error() {
		long ret = Bindings.SignOrCreationErrorSignError();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignOrCreationError ret_hu_conv = org.ldk.structs.SignOrCreationError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new CreationError-variant SignOrCreationError
	 */
	public static SignOrCreationError creation_error(CreationError a) {
		long ret = Bindings.SignOrCreationErrorCreationError(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.SignOrCreationError ret_hu_conv = org.ldk.structs.SignOrCreationError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two SignOrCreationErrors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.SignOrCreationError b) {
		bool ret = Bindings.SignOrCreationErrorEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is SignOrCreationError)) return false;
		return this.eq((SignOrCreationError)o);
	}
	/**
	 * Get the string representation of a SignOrCreationError object
	 */
	public string to_str() {
		long ret = Bindings.SignOrCreationErrorToStr(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.DecodeString(ret);
		return ret_conv;
	}

}
} } }
