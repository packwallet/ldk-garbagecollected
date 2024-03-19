using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Error when parsing a bech32 encoded message using [`str::parse`].
 */
public class Bolt12ParseError : CommonBase {
	internal Bolt12ParseError(object _dummy, long ptr) : base(ptr) { }
	~Bolt12ParseError() {
		if (ptr != 0) { Bindings.Bolt12ParseErrorFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.Bolt12ParseErrorClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Bolt12ParseError
	 */
	public Bolt12ParseError clone() {
		long ret = Bindings.Bolt12ParseErrorClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Bolt12ParseError ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.Bolt12ParseError(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
