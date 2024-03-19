using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A hash for use in a specific context by tweaking with a context-dependent tag as per [BIP 340]
 * and computed over the merkle root of a TLV stream to sign as defined in [BOLT 12].
 * 
 * [BIP 340]: https://github.com/bitcoin/bips/blob/master/bip-0340.mediawiki
 * [BOLT 12]: https://github.com/rustyrussell/lightning-rfc/blob/guilt/offers/12-offer-encoding.md#signature-calculation
 */
public class TaggedHash : CommonBase {
	internal TaggedHash(object _dummy, long ptr) : base(ptr) { }
	~TaggedHash() {
		if (ptr != 0) { Bindings.TaggedHashFree(ptr); }
	}

	internal long clone_ptr() {
		long ret = Bindings.TaggedHashClonePtr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the TaggedHash
	 */
	public TaggedHash clone() {
		long ret = Bindings.TaggedHashClone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TaggedHash ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TaggedHash(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns the digest to sign.
	 */
	public byte[] as_digest() {
		long ret = Bindings.TaggedHashAsDigest(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Returns the tag used in the tagged hash.
	 */
	public string tag() {
		long ret = Bindings.TaggedHashTag(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		string ret_conv = InternalUtils.DecodeString(ret);
		return ret_conv;
	}

	/**
	 * Returns the merkle root used in the tagged hash.
	 */
	public byte[] merkle_root() {
		long ret = Bindings.TaggedHashMerkleRoot(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.DecodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
