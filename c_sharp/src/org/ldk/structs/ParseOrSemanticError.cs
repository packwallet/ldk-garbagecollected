using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Indicates that something went wrong while parsing or validating the invoice. Parsing errors
 * should be mostly seen as opaque and are only there for debugging reasons. Semantic errors
 * like wrong signatures, missing fields etc. could mean that someone tampered with the invoice.
 */
public class ParseOrSemanticError : CommonBase {
	protected ParseOrSemanticError(object _dummy, long ptr) : base(ptr) { }
	~ParseOrSemanticError() {
		if (ptr != 0) { Bindings.ParseOrSemanticErrorFree(ptr); }
	}

	internal static ParseOrSemanticError constr_from_ptr(long ptr) {
		long raw_ty = Bindings.LDKParseOrSemanticErrorTyFromPtr(ptr);
		switch (raw_ty) {
			case 0: return new ParseOrSemanticError_ParseError(ptr);
			case 1: return new ParseOrSemanticError_SemanticError(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A ParseOrSemanticError of type ParseError */
	public class ParseOrSemanticError_ParseError : ParseOrSemanticError {
		public Bolt11ParseError parse_error;
		internal ParseOrSemanticError_ParseError(long ptr) : base(null, ptr) {
			long parse_error = Bindings.LDKParseOrSemanticErrorParseErrorGetParseError(ptr);
			org.ldk.structs.Bolt11ParseError parse_error_hu_conv = org.ldk.structs.Bolt11ParseError.constr_from_ptr(parse_error);
			if (parse_error_hu_conv != null) { parse_error_hu_conv.ptrs_to.AddLast(this); };
			this.parse_error = parse_error_hu_conv;
		}
	}
	/** A ParseOrSemanticError of type SemanticError */
	public class ParseOrSemanticError_SemanticError : ParseOrSemanticError {
		public Bolt11SemanticError semantic_error;
		internal ParseOrSemanticError_SemanticError(long ptr) : base(null, ptr) {
			this.semantic_error = Bindings.LDKParseOrSemanticErrorSemanticErrorGetSemanticError(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = Bindings.ParseOrSemanticErrorClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ParseOrSemanticError
	 */
	public ParseOrSemanticError clone() {
		long ret = Bindings.ParseOrSemanticErrorClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ParseOrSemanticError ret_hu_conv = org.ldk.structs.ParseOrSemanticError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ParseError-variant ParseOrSemanticError
	 */
	public static ParseOrSemanticError parse_error(org.ldk.structs.Bolt11ParseError a) {
		long ret = Bindings.ParseOrSemanticErrorParseError(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ParseOrSemanticError ret_hu_conv = org.ldk.structs.ParseOrSemanticError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SemanticError-variant ParseOrSemanticError
	 */
	public static ParseOrSemanticError semantic_error(Bolt11SemanticError a) {
		long ret = Bindings.ParseOrSemanticErrorSemanticError(a);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ParseOrSemanticError ret_hu_conv = org.ldk.structs.ParseOrSemanticError.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ParseOrSemanticErrors contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.ParseOrSemanticError b) {
		bool ret = Bindings.ParseOrSemanticErrorEq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ParseOrSemanticError)) return false;
		return this.eq((ParseOrSemanticError)o);
	}
	/**
	 * Get the string representation of a ParseOrSemanticError object
	 */
	public string to_str() {
		long ret = Bindings.ParseOrSemanticErrorToStr(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.DecodeString(ret);
		return ret_conv;
	}

}
} } }
